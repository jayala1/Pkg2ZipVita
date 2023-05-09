using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using CsvHelper;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace VitaPkg2App
{
    public partial class Form1 : Form
    {
        private string exePath;
        private string tsvFilePath;
        private string[] pkgFileNames;
        private string outputFolderPath;
        private string defaultOutputFolderPath;

        public Form1()
        {
            InitializeComponent();
            defaultOutputFolderPath = Directory.GetCurrentDirectory();
        }

        private void BtnSelectPkg2Zip_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable files (*.exe)|*.exe";
                openFileDialog.Title = "Select pkg2zip.exe";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    exePath = openFileDialog.FileName;
                    BtnSelectPkg2Zip.Text = $"Selected: {Path.GetFileName(exePath)}";
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify the URL to navigate to when the link is clicked.
            string url = "https://github.com/mmozeiko/pkg2zip/releases";

            // Change the color of the link text to show it has been visited.
            linkLabel1.LinkVisited = true;

            // Open the URL in the default web browser.
            System.Diagnostics.Process.Start(url);

            // Update lblProgress with instructions for linkLabel1
            lblProgress.Text = "Download pkg2zip_64bit.zip and then extract. Once extracted press the pkg2zip button and select the pkg2zip.exe file";
        }

        private void BtnSelectTsvFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "TSV files (*.tsv)|*.tsv";
                openFileDialog.Title = "Select TSV file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tsvFilePath = openFileDialog.FileName;
                    BtnSelectTsvFile.Text = $"Selected: {Path.GetFileName(tsvFilePath)}";
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify the URL to navigate to when the link is clicked.
            string url = "https://nopaystation.com/";

            // Change the color of the link text to show it has been visited.
            linkLabel2.LinkVisited = true;

            // Open the URL in the default web browser.
            System.Diagnostics.Process.Start(url);

            // Update lblProgress with instructions for linkLabel2
            lblProgress.Text = "Look for TSV Files on the right of the site, press PSV and press PSV Games to download TSV, then press the select TSV file button";
        }

        private void BtnSelectOutputFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    outputFolderPath = folderBrowserDialog.SelectedPath;
                    BtnSelectOutputFolder.Text = $"Selected: {outputFolderPath}";
                }
            }
        }

        private void BtnSelectPkgFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PKG files (*.pkg)|*.pkg";
                openFileDialog.Title = "Select pkg files";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pkgFileNames = openFileDialog.FileNames;
                    BtnSelectPkgFiles.Text = $"Selected {pkgFileNames.Length} pkg files";
                    ProcessPkgs();
                }
            }
        }

        private string FindPkgAndKey(string filename, string tsvFile)
        {
            using (var reader = new StreamReader(tsvFile))
            {
                var config = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = "\t",
                    HeaderValidated = null,
                    MissingFieldFound = null
                };

                using (var csv = new CsvReader(reader, config))
                {
                    var records = csv.GetRecords<dynamic>().ToList();

                    foreach (var row in records)
                    {
                        // Cast row to IDictionary<string, object>
                        var rowDict = row as IDictionary<string, object>;
                        if (rowDict != null && ((string)rowDict["PKG direct link"]).EndsWith(filename))
                            return (string)rowDict["zRIF"];
                    }
                }
            }

            return null;
        }



        private void RunPkg2Zip(string pkgFilename, string zrif)
        {
            var cmd = $"{exePath} {pkgFilename} {zrif}";
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true, // Redirect standard output
                    RedirectStandardError = true, // Redirect standard error
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WorkingDirectory = outputFolderPath
                }
            };

            process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data); // Handle output data
            process.ErrorDataReceived += (sender, e) => Console.WriteLine(e.Data); // Handle error data

            process.Start();
            process.StandardInput.WriteLine(cmd);
            process.StandardInput.Close();
            process.BeginOutputReadLine(); // Start reading output data
            process.BeginErrorReadLine(); // Start reading error data
            process.WaitForExit();
        }

        private void ProcessPkgs()
        {
            if (string.IsNullOrEmpty(exePath) || string.IsNullOrEmpty(tsvFilePath) || pkgFileNames == null || pkgFileNames.Length == 0)
            {
                lblProgress.Text = "Please select all required files.";
                return;
            }

            for (int i = 0; i < pkgFileNames.Length; i++)
            {
                var pkgFileName = pkgFileNames[i];
                lblProgress.Text = $"Processing {i + 1}/{pkgFileNames.Length}: {Path.GetFileName(pkgFileName)}";
                lblProgress.Update();
                string zrif = FindPkgAndKey(Path.GetFileName(pkgFileName), tsvFilePath);

                if (zrif != null)
                {
                    RunPkg2Zip(pkgFileName, zrif);
                    lblProgress.Text = $"Done processing {i + 1}/{pkgFileNames.Length}: {Path.GetFileName(pkgFileName)}";
                }
                else
                {
                    lblProgress.Text = $"zRIF not found for {i + 1}/{pkgFileNames.Length}: {Path.GetFileName(pkgFileName)}";
                }
            }

            lblProgress.Text = $"Completed processing {pkgFileNames.Length} pkg files. Output folder: {(string.IsNullOrEmpty(outputFolderPath) ? defaultOutputFolderPath : outputFolderPath)}";
        }
    }
}
