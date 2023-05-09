using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Main;

namespace UnitTestProject1.GenericUtilities
{

    // [TestClass]
    /*
     public class ExtendReportUtilities : BaseCls
     {
     //    [TestInitialize]
         public void extendReportsMethod()
         {

             driver =new ChromeDriver();

         }

         [TestMethod]
         [TestCategory("ExtentHtmlReporter")]
         [DataTestMethod]
         [DataRow("https://www.facebook.com/", "Facebook")]
         [DataRow("https://medium.com/", "Medium")]
         [DataRow("https://www.bbc.com/", "BBC")]
         public void Medium(String URL, String Title) 
         {
             extentTest =extentReports.CreateTest("Medium");

             driver.Navigate().GoToUrl(URL);

            ITakesScreenshot takeScreenShot= (ITakesScreenshot)driver;

            var screenShot = takeScreenShot.GetScreenshot();
             screenShotPath = "C:\\Users\\panth\\source\\repos\\UnitTestProject1\\UnitTestProject1\\GenericUtilities\\ScreenShot\\Medium.png";
             screenShot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);

              extentTest.Log(Status.Info, "medium screenshot");



         }

         [TestMethod]
         [TestCategory("ExtentHtmlReporter")]
         public void instagram() 
         {
             extentTest = extentReports.CreateTest("Instagram");

             driver.Navigate().GoToUrl("https://www.instagram.com/");

             ITakesScreenshot takeScreenShot = (ITakesScreenshot)driver;

             var screenShot = takeScreenShot.GetScreenshot();
             screenShotPath = "C:\\Users\\panth\\source\\repos\\UnitTestProject1\\UnitTestProject1\\GenericUtilities\\ScreenShot\\Instagram.png";
             screenShot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);

             extentTest.Log(Status.Warning, "Its is a status Waring");
             extentTest.Warning("ExtentTestWarning Method");
             Assert.IsTrue(true);
             extentTest.Pass("TestPassed");


         }

         [TestCleanup]
         public void extentClose()
         {
             driver.Close();
             driver.Dispose();
             extentTest.AddScreenCaptureFromPath(screenShotPath);    
         }



     }
    */
}
