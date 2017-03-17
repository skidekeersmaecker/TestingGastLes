using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Linq;

namespace TestingExercises.loganalyzer
{
    [TestClass]
    public class LogAnalyzerTests
    {
        [TestMethod]
        public void TestError()
        {
            var logSource = Substitute.For<ILogSource>();
            logSource.GetLines().Returns(new[] { "Error: this is an error" }.ToList());
            var logger = Substitute.For<ILogger>();
            var analyzer = new LogAnalyzer(logSource, logger);

            analyzer.Analyze();

            logger.Received().LogError("Error: this is an error");
        }

        [TestMethod]
        public void TestInfo()
        {
            var logSource = Substitute.For<ILogSource>();
            logSource.GetLines().Returns(new[] { "Info: this is info" }.ToList());
            var logger = Substitute.For<ILogger>();
            var analyzer = new LogAnalyzer(logSource, logger);

            analyzer.Analyze();

            logger.Received().LogInfo("Info: this is info");
        }      
    }
}