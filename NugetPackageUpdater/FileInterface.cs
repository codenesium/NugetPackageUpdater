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

        public List<string> ReadFileLines(string path)
        {
            return File.ReadAllLines(path).ToList();
        }

        public void WriteFile(string path, List<String> lines)
        {
            File.WriteAllText(path, string.Join(Environment.NewLine,lines.ToArray()).TrimEnd());
        }


        public void WriteFile(string path, string contents)
        {
            File.WriteAllText(path, contents);
        }

        public string ReadFile(string path)
        {
            return File.ReadAllText(path);
        }

        public bool FileExists(string path)
        {
            return File.Exists(path);
        }

        public void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }
    }
}
