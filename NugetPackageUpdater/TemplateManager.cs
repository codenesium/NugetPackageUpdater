using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetPackageUpdater
{
    public class TemplateManager
    {
        string templateDirectory;
        IFileSystemInterface fileSystemInterface;

        public TemplateManager(string templateDirectory, IFileSystemInterface fileSystemInterface)
        {
            this.templateDirectory = templateDirectory;
            this.fileSystemInterface = fileSystemInterface;
            this.fileSystemInterface.CreateDirectory(this.templateDirectory);
        }
        public void WriteTemplate(Template template)
        {
            string path = this.GetTemplatePath(template.PackageName);
            string contents = JsonConvert.SerializeObject(template, Formatting.Indented);
            this.fileSystemInterface.WriteFile(path, contents);
        }

        public Template ReadTemplate(string filename)
        {
            if (this.fileSystemInterface.FileExists(filename))
            {
                string contents = this.fileSystemInterface.ReadFile(filename);
                return JsonConvert.DeserializeObject<Template>(contents);
            }
            else
            {
                return null;
            }
        }

        private string GetTemplatePath(string packageName)
        {
            return Path.Combine(this.templateDirectory, packageName + ".json");
        }
    }
}
