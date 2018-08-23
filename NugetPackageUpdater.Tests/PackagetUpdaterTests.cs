using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;

namespace NugetPackageUpdater.Tests
{
    [TestClass]
    public class PackageUpdaterTests
    {


        [TestMethod]
        public void PackageConfigTestLine()
        {
            var packageUpdater = new PackageUpdater(new FileInterface());

            string line = @"<package id=""NLog"" version=""4.5.3"" targetFramework=""net461"" />";

            string result = packageUpdater.ProcessLine(line, "NLog", "9.9.9");

            result.Should().Be(@"<package id=""NLog"" version=""9.9.9"" targetFramework=""net461"" />");
        }

        [TestMethod]
        public void PackageConfigTestLine_MissingVersion()
        {
            var packageUpdater = new PackageUpdater(new FileInterface());

            string line = @"<package id=""NLog"" targetFramework=""net461"" />";

            Action act = () => { packageUpdater.ProcessLine(line, "NLog", "9.9.9"); };
            
            act.Should().Throw<Exception>()
           .WithMessage("versionEquals not found");
        }


        [TestMethod]
        public void PackageConfigProcessFile()
        {
            string contents = @"<?xml version=""1.0"" encoding=""utf-8""?>
           <packages>
             <package id =""NLog"" version=""4.5.3"" targetFramework=""net461"" />
           </packages>";

            List<string> lines = contents.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

            var packageUpdater = new PackageUpdater(new FileInterface());

            List<string> result = packageUpdater.ProcessFileContents(lines, "NLog", "9.9.9" );

            string joined = string.Join(Environment.NewLine, result.ToArray());

            joined.Should().Be(@"<?xml version=""1.0"" encoding=""utf-8""?>
           <packages>
             <package id =""NLog"" version=""9.9.9"" targetFramework=""net461"" />
           </packages>");
        }
    }
}
