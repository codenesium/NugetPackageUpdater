using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NugetPackageUpdater
{
    public partial class Form1 : MetroForm
    {
        string templateRootDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "templates");

        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonProcess_Click(object sender, EventArgs e)
        {
            PackageUpdater packageUpdater = new PackageUpdater(new FileInterface());
            ProjectUpdater projectUpdater = new ProjectUpdater(new FileInterface());
            TemplateManager templateManager = new TemplateManager(templateRootDirectory, new FileInterface());

            Template template = new Template(textBoxPackageName.Text, textBoxPackageVersion.Text, textBoxHintNeedle.Lines.ToList(), textBoxHintReplacement.Text);

            await Task.Run(() =>
            {
                packageUpdater.ProcessFiles(textBoxDirectory.Text, textBoxPackageName.Text, textBoxPackageVersion.Text);
                projectUpdater.ProcessFiles(textBoxDirectory.Text, textBoxPackageName.Text, textBoxPackageVersion.Text, textBoxHintNeedle.Lines.ToList(), textBoxHintReplacement.Text);
                templateManager.WriteTemplate(template);
            });

            MessageBox.Show("Done!");
        }

        private void buttonSelectDirectory_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonSelectTemplate_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = this.templateRootDirectory;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TemplateManager templateManager = new TemplateManager(templateRootDirectory, new FileInterface());
                Template template = templateManager.ReadTemplate(openFileDialog1.FileName);

                textBoxHintNeedle.Lines = template.HintNeedles.ToArray();
                textBoxHintReplacement.Text = template.HintVersion;
                textBoxPackageName.Text = template.PackageName;
                textBoxPackageVersion.Text = template.PackageVersion;
            }
        }
    }
}
