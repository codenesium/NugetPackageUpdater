using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetPackageUpdater
{
    public interface IFileSystemInterface
    {
        List<string> ReadFileLines(string path);

        void WriteFile(string path, List<string> lines);

        List<string> GetFiles(string rootDirectory, string search);

        void WriteFile(string path, string contents);

        string ReadFile(string path);

        bool FileExists(string path);

        void CreateDirectory(string path);
    }
}
