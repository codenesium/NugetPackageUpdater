using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetPackageUpdater
{
    public class Template
    {
        public string PackageName { get; set; } = string.Empty;

        public string PackageVersion { get; set; } = string.Empty;

        public List<string> HintNeedles { get; set; } = new List<string>();

        public string HintVersion { get; set; } = string.Empty;

        public Template()
        {

        }

        public Template(string packageName, string packageVersion, List<string> hintNeedles, string hintVersion)
        {
            this.PackageName = packageName;
            this.PackageVersion = packageVersion;
            this.HintNeedles = hintNeedles;
            this.HintVersion = hintVersion;
        }
    }
}
