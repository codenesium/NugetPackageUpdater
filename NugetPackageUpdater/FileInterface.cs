using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NugetPackageUpdater
{
    public class FileInterface : IFileSystemInterface
    {
        public List<string> GetFiles(string rootDirectory, string search)
        {
            return Directory.GetFiles(rootDirectory, search, SearchOption.AllDirectories).ToList();
        }

        public List<string> ReadFile(string path)
        {
            return File.ReadAllLines(path).ToList();
        }

        public void WriteFile(string path, List<String> lines)
        {
            File.WriteAllText(path, string.Join(Environment.NewLine,lines.ToArray()).TrimEnd());
        }
    }
}
