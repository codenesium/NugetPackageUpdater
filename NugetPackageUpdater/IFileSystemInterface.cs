using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetPackageUpdater
{
    public interface IFileSystemInterface
    {
        List<string> ReadFile(string path);

        void WriteFile(string path, List<string> lines);

        List<string> GetFiles(string rootDirectory, string search);
    }
}
