namespace NugetPackageUpdater
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
            this.buttonProcess = new System.Windows.Forms.Button();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.labelRootDirectory = new System.Windows.Forms.Label();
            this.buttonSelectDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxPackageName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPackageVersion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHintNeedle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHintReplacement = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSelectTemplate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(383, 492);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonProcess.TabIndex = 1;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Location = new System.Drawing.Point(21, 80);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(435, 20);
            this.textBoxDirectory.TabIndex = 2;
            this.textBoxDirectory.Text = "C:\\Users\\Administrator\\Documents\\Mercurial\\TPS\\NET";
            // 
            // labelRootDirectory
            // 
            this.labelRootDirectory.AutoSize = true;
            this.labelRootDirectory.Location = new System.Drawing.Point(18, 64);
            this.labelRootDirectory.Name = "labelRootDirectory";
            this.labelRootDirectory.Size = new System.Drawing.Size(75, 13);
            this.labelRootDirectory.TabIndex = 3;
            this.labelRootDirectory.Text = "Root Directory";
            // 
            // buttonSelectDirectory
            // 
            this.buttonSelectDirectory.Location = new System.Drawing.Point(347, 106);
            this.buttonSelectDirectory.Name = "buttonSelectDirectory";
            this.buttonSelectDirectory.Size = new System.Drawing.Size(109, 23);
            this.buttonSelectDirectory.TabIndex = 4;
            this.buttonSelectDirectory.Text = "Select Directory";
            this.buttonSelectDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectDirectory.Click += new System.EventHandler(this.buttonSelectDirectory_Click);
            // 
            // textBoxPackageName
            // 
            this.textBoxPackageName.Location = new System.Drawing.Point(21, 143);
            this.textBoxPackageName.Name = "textBoxPackageName";
            this.textBoxPackageName.Size = new System.Drawing.Size(146, 20);
            this.textBoxPackageName.TabIndex = 5;
            this.textBoxPackageName.Text = "NLog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Package Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Package Version";
            // 
            // textBoxPackageVersion
            // 
            this.textBoxPackageVersion.Location = new System.Drawing.Point(21, 198);
            this.textBoxPackageVersion.Name = "textBoxPackageVersion";
            this.textBoxPackageVersion.Size = new System.Drawing.Size(146, 20);
            this.textBoxPackageVersion.TabIndex = 7;
            this.textBoxPackageVersion.Text = "9.9.9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hint Needle";
            // 
            // textBoxHintNeedle
            // 
            this.textBoxHintNeedle.Location = new System.Drawing.Point(21, 247);
            this.textBoxHintNeedle.Multiline = true;
            this.textBoxHintNeedle.Name = "textBoxHintNeedle";
            this.textBoxHintNeedle.Size = new System.Drawing.Size(435, 99);
            this.textBoxHintNeedle.TabIndex = 9;
            this.textBoxHintNeedle.Text = "NLog.dll";
            this.textBoxHintNeedle.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hint Replacement";
            // 
            // textBoxHintReplacement
            // 
            this.textBoxHintReplacement.Location = new System.Drawing.Point(21, 365);
            this.textBoxHintReplacement.Name = "textBoxHintReplacement";
            this.textBoxHintReplacement.Size = new System.Drawing.Size(146, 20);
            this.textBoxHintReplacement.TabIndex = 11;
            this.textBoxHintReplacement.Text = "NLog.9.9.9";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(17, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(451, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Make sure your repository is in a clean state before processing.";
            // 
            // buttonSelectTemplate
            // 
            this.buttonSelectTemplate.Location = new System.Drawing.Point(173, 140);
            this.buttonSelectTemplate.Name = "buttonSelectTemplate";
            this.buttonSelectTemplate.Size = new System.Drawing.Size(109, 23);
            this.buttonSelectTemplate.TabIndex = 14;
            this.buttonSelectTemplate.Text = "SelectTemplate";
            this.buttonSelectTemplate.UseVisualStyleBackColor = true;
            this.buttonSelectTemplate.Click += new System.EventHandler(this.buttonSelectTemplate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 530);
            this.Controls.Add(this.buttonSelectTemplate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHintReplacement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxHintNeedle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPackageVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPackageName);
            this.Controls.Add(this.buttonSelectDirectory);
            this.Controls.Add(this.labelRootDirectory);
            this.Controls.Add(this.textBoxDirectory);
            this.Controls.Add(this.buttonProcess);
            this.Name = "Form1";
            this.Text = "Nuget Package Updater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Label labelRootDirectory;
        private System.Windows.Forms.Button buttonSelectDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBoxPackageName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPackageVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHintNeedle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHintReplacement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSelectTemplate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

