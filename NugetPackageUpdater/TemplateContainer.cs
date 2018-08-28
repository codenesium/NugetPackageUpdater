using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetPackageUpdater
{
    public class TemplateContainer
    {
        public List<Template> Templates { get; private set; } = new List<Template>();

        public void AddTemplate(Template template)
        {
            this.Templates.Add(template);
        }
    }
}
