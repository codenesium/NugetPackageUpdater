using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NugetPackageUpdater
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonProcess_Click(object sender, EventArgs e)
        {
            PackageUpdater packageUpdater = new PackageUpdater(new FileInterface());
            ProjectUpdater projectUpdater = new ProjectUpdater(new FileInterface());

            await Task.Run(() =>
            {
                packageUpdater.ProcessFiles(textBoxDirectory.Text, textBoxPackageName.Text, textBoxPackageVersion.Text);
                projectUpdater.ProcessFiles(textBoxDirectory.Text, textBoxPackageName.Text, textBoxPackageVersion.Text, textBoxHintNeedle.Text, textBoxHintReplacement.Text);
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
    }
}
