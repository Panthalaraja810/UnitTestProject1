using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace UnitTestProject1.Main
{
    [TestClass]
    public class BaseCls
    {
       public static IWebDriver driver;
        public static ExtentReports extentReports;
        public ExtentTest extentTest;
        public static string screenShotPath;
        public static ExtentHtmlReporter extentHtmlReporter;
        public static string testResultPath = "C:\\Users\\panth\\source\\repos\\UnitTestProject1\\UnitTestProject1\\GenericUtilities\\Reports\\";
        public TestContext testContext;

        public TestContext Test
        {
            get { return testContext; }
            set { testContext = value; }
        }

        [AssemblyInitialize]
        public static void AssemblyInitializeMethod(TestContext testContext)
        {
            extentReports = new ExtentReports();
            extentHtmlReporter = new ExtentHtmlReporter(testResultPath);
            extentHtmlReporter.Start();
            extentReports.AttachReporter(extentHtmlReporter);
        }

        [AssemblyCleanup]
        public static void AssemblyCleanupMethod()
        {
            extentReports.Flush();
            extentHtmlReporter.Stop();
        }


    }
}
