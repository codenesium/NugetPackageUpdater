using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetPackageUpdater
{
    public class PackageUpdater
    {
        IFileSystemInterface fileInterface;
        public PackageUpdater(IFileSystemInterface fileInterface)
        {
            this.fileInterface = fileInterface;
        }

        public void ProcessFiles(string rooDirectory, string packageName, string packageVersion, string extension = "packages.config")
        {
            List<string> files = this.fileInterface.GetFiles(rooDirectory, extension);
            for (int i = 0; i < files.Count; i++)
            {
                List<string> lines = ProcessFile(files[i], packageName, packageVersion);
                this.fileInterface.WriteFile(files[i], lines);
            }
        }

        public List<string> ProcessFile(string path, string packageName, string packageVersion)
        {
            List<string> contents = this.fileInterface.ReadFile(path);
            return ProcessFileContents(contents, packageName, packageVersion);
        }

        public List<string> ProcessFileContents(List<string> lines, string packageName, string packageVersion)
        {
            for (int i=0; i < lines.Count; i++)
            {
                lines[i] = this.ProcessLine(lines[i], packageName, packageVersion);
            }

            return lines;
        }

        public string ProcessLine(string line, string packageName, string packageVersion)
        {
            if (line.Contains(packageName))
            {
                string versionNeedle = @"version=""";
                int versionEqualsStartIndex = line.IndexOf(versionNeedle);

                if (versionEqualsStartIndex == -1)
                {
                    throw new Exception("versionEquals not found");
                }

                int versionEqualsEndIndex = line.IndexOf(@"""", versionEqualsStartIndex + versionNeedle.Length);

                string currentVersion = line.Substring(versionEqualsStartIndex + versionNeedle.Length, versionEqualsEndIndex - versionEqualsStartIndex - versionNeedle.Length);

                string changedLine = line.Replace(currentVersion, packageVersion);

                return changedLine;
            }
            else
            {
                return line;
            }
        }
    }
}
