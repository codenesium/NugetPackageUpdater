﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetPackageUpdater
{
    public class ProjectUpdater
    {
        IFileSystemInterface fileInterface;
        public ProjectUpdater(IFileSystemInterface fileInterface)
        {
            this.fileInterface = fileInterface;
        }

        public void ProcessFiles(string rooDirectory, string packageName, string packageVersion, List<string> hintNeedles, string hintReplacement, string extension = "*.csproj")
        {
            List<string> files = this.fileInterface.GetFiles(rooDirectory, extension);
            for(int i=0; i < files.Count; i++)
            {
                List<string> lines = ProcessFile(files[i], packageName, packageVersion, hintNeedles, hintReplacement);
                this.fileInterface.WriteFile(files[i], lines);
            }
        }

        public List<string> ProcessFile(string path, string packageName, string packageVersion, List<string> hintNeedles, string hintReplacement)
        {
            List<string> contents = this.fileInterface.ReadFileLines(path);

            return this.ProcessFileContents(contents, packageName, packageVersion, hintNeedles, hintReplacement);
        }

        public List<string> ProcessFileContents(List<string> lines, string packageName, string packageVersion, List<string> hintNeedles, string hintReplacement)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = this.ProcessVersion(lines[i], packageName, packageVersion);
            }

            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = this.ProcessHint(lines[i], hintNeedles, hintReplacement);
            }

            return lines;
        }

        public string ProcessVersion(string line, string packageName, string packageVersion)
        {
            if (line.Contains(packageName) && !line.Contains("HintPath"))
            {
                string versionNeedle = @"Version=";
                int versionEqualsStartIndex = line.IndexOf(versionNeedle);

                if (versionEqualsStartIndex == -1)
                {
                    return line;
                }

                int versionEqualsEndIndex = line.IndexOf(@",", versionEqualsStartIndex + versionNeedle.Length);

                string currentVersion = line.Substring(versionEqualsStartIndex + versionNeedle.Length, versionEqualsEndIndex - versionEqualsStartIndex - versionNeedle.Length);

                string replacedLine = line.Substring(0, versionEqualsStartIndex -1) + line.Substring(versionEqualsEndIndex + 1);

                return replacedLine;
            }
            else
            {
                return line;
            }
        }

        public string ProcessHint(string line, List<string> hintNeedles, string hintReplacement)
        {
            if (line.ToUpper().Contains("HINTPATH"))
            {

                bool found = false;
                hintNeedles.ForEach(x =>
                {
                    if(line.ToUpper().Contains(x.ToUpper()))
                    {
                        found = true;
                    }
                });

                if(!found)
                {
                    return line;
                }

                string needle = "packages\\";
                int startIndex = line.IndexOf(needle);
                if (startIndex == -1)
                {
                    return line;
                }
                int endIndex = line.IndexOf("\\lib", startIndex);

                string currentVersion = line.Substring(startIndex + needle.Length, endIndex - startIndex - needle.Length);

                return line.Replace(currentVersion, hintReplacement);
            }
            else
            {
                return line;
            }
        }
    }
}
