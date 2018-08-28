using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using Moq;
namespace NugetPackageUpdater.Tests
{
    [TestClass]
    public class ProjectUpdaterTests
    {
     
        [TestMethod]
        public void ProjectConfigVersion()
        {
            var projectUpdater = new ProjectUpdater(new Mock<IFileSystemInterface>().Object);

            string line = @"<Reference Include=""NLog, Version=4.0.0.0, Culture=neutral, PublicKeyToken=5120e14c03d0593c, processorArchitecture=MSIL"">";

            string result = projectUpdater.ProcessVersion(line, "NLog", "9.9.9.9");

            result.Should().Be(@"<Reference Include=""NLog, Culture=neutral, PublicKeyToken=5120e14c03d0593c, processorArchitecture=MSIL"">");
        }

        [TestMethod]
        public void ProjectConfigHint()
        {
            var projectUpdater = new ProjectUpdater(new Mock<IFileSystemInterface>().Object);

            string line = @"<HintPath>..\packages\NLog.4.5.3\lib\net45\NLog.dll</HintPath>";

            string result = projectUpdater.ProcessHint(line, new List<string>() { "NLog" } , "NLog.9.9.9");

            result.Should().Be(@"<HintPath>..\packages\NLog.9.9.9\lib\net45\NLog.dll</HintPath>");
        }


    }
}
