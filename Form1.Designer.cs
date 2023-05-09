namespace VitaPkg2App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSelectPkg2Zip = new System.Windows.Forms.Button();
            this.BtnSelectTsvFile = new System.Windows.Forms.Button();
            this.BtnSelectPkgFiles = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.BtnSelectOutputFolder = new System.Windows.Forms.Button();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.lblInstruction3 = new System.Windows.Forms.Label();
            this.lblInstruction4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // BtnSelectPkg2Zip
            // 
            this.BtnSelectPkg2Zip.Location = new System.Drawing.Point(317, 43);
            this.BtnSelectPkg2Zip.Name = "BtnSelectPkg2Zip";
            this.BtnSelectPkg2Zip.Size = new System.Drawing.Size(137, 30);
            this.BtnSelectPkg2Zip.TabIndex = 0;
            this.BtnSelectPkg2Zip.Text = "Pkg2Zip EXE";
            this.BtnSelectPkg2Zip.UseVisualStyleBackColor = true;
            this.BtnSelectPkg2Zip.Click += new System.EventHandler(this.BtnSelectPkg2Zip_Click);
            // 
            // BtnSelectTsvFile
            // 
            this.BtnSelectTsvFile.Location = new System.Drawing.Point(317, 92);
            this.BtnSelectTsvFile.Name = "BtnSelectTsvFile";
            this.BtnSelectTsvFile.Size = new System.Drawing.Size(137, 27);
            this.BtnSelectTsvFile.TabIndex = 1;
            this.BtnSelectTsvFile.Text = "Vita TSV File";
            this.BtnSelectTsvFile.UseVisualStyleBackColor = true;
            this.BtnSelectTsvFile.Click += new System.EventHandler(this.BtnSelectTsvFile_Click);
            // 
            // BtnSelectPkgFiles
            // 
            this.BtnSelectPkgFiles.Location = new System.Drawing.Point(317, 193);
            this.BtnSelectPkgFiles.Name = "BtnSelectPkgFiles";
            this.BtnSelectPkgFiles.Size = new System.Drawing.Size(137, 28);
            this.BtnSelectPkgFiles.TabIndex = 2;
            this.BtnSelectPkgFiles.Text = "Select PKG Files";
            this.BtnSelectPkgFiles.UseVisualStyleBackColor = true;
            this.BtnSelectPkgFiles.Click += new System.EventHandler(this.BtnSelectPkgFiles_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(12, 238);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 16);
            this.lblProgress.TabIndex = 3;
            // 
            // BtnSelectOutputFolder
            // 
            this.BtnSelectOutputFolder.Location = new System.Drawing.Point(317, 145);
            this.BtnSelectOutputFolder.Name = "BtnSelectOutputFolder";
            this.BtnSelectOutputFolder.Size = new System.Drawing.Size(137, 30);
            this.BtnSelectOutputFolder.TabIndex = 4;
            this.BtnSelectOutputFolder.Text = "Output Location";
            this.BtnSelectOutputFolder.UseVisualStyleBackColor = true;
            this.BtnSelectOutputFolder.Click += new System.EventHandler(this.BtnSelectOutputFolder_Click);
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.Location = new System.Drawing.Point(86, 50);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(156, 16);
            this.lblInstruction1.TabIndex = 5;
            this.lblInstruction1.Text = "1. Select pkg2zip.exe file.";
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.Location = new System.Drawing.Point(86, 97);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(111, 16);
            this.lblInstruction2.TabIndex = 6;
            this.lblInstruction2.Text = "2. Select TSV file.";
            // 
            // lblInstruction3
            // 
            this.lblInstruction3.AutoSize = true;
            this.lblInstruction3.Location = new System.Drawing.Point(86, 199);
            this.lblInstruction3.Name = "lblInstruction3";
            this.lblInstruction3.Size = new System.Drawing.Size(118, 16);
            this.lblInstruction3.TabIndex = 7;
            this.lblInstruction3.Text = "4. Select PKG files.";
            // 
            // lblInstruction4
            // 
            this.lblInstruction4.AutoSize = true;
            this.lblInstruction4.Location = new System.Drawing.Point(86, 149);
            this.lblInstruction4.Name = "lblInstruction4";
            this.lblInstruction4.Size = new System.Drawing.Size(189, 16);
            this.lblInstruction4.TabIndex = 8;
            this.lblInstruction4.Text = "3. Select Destination(Optional).";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(460, 50);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(143, 16);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Download pkg2zip.exe";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(460, 97);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(123, 16);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Download TSV File";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblInstruction4);
            this.Controls.Add(this.lblInstruction3);
            this.Controls.Add(this.lblInstruction2);
            this.Controls.Add(this.lblInstruction1);
            this.Controls.Add(this.BtnSelectOutputFolder);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.BtnSelectPkgFiles);
            this.Controls.Add(this.BtnSelectTsvFile);
            this.Controls.Add(this.BtnSelectPkg2Zip);
            this.Name = "Form1";
            this.Text = "PKG to ZIP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSelectPkg2Zip;
        private System.Windows.Forms.Button BtnSelectTsvFile;
        private System.Windows.Forms.Button BtnSelectPkgFiles;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button BtnSelectOutputFolder;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.Label lblInstruction3;
        private System.Windows.Forms.Label lblInstruction4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

