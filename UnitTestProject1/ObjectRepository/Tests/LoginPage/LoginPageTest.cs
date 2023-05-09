using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTestProject1.GenericUtilities;
using UnitTestProject1.Main;
using UnitTestProject1.ObjectRepository.ActitimeLogin;

namespace UnitTestProject1.ObjectRepository.Tests.LoginPage
{
    [TestClass]
    public class LoginPageTest : BaseCls
    {
       // public IWebDriver driver;
        IWebDriverUtilities webDriverUtilities = new IWebDriverUtilities(); //initializing the webdriver utilities
        ExcelUtilities excelUtilities = new ExcelUtilities();
        String eTitle = "actiTIME - Enter Time-Track1"; //expected title
  
        [TestInitialize]
        public void InitializaTest() //test initializer method
        {
            driver = new ChromeDriver(); //opening the browser
        }

        [TestCleanup]
        public void TestCleanupMethod()
        {
            driver.Close(); //closing the browser
            driver.Dispose(); //clean
          //invalid arguments
        }

       
      /*  [TestMethod]
      
        [TestCategory("ExtentHtmlReporter")]
        public void VerificationOfTest()
        {
            LoginPageElements loginPageElements = new LoginPageElements(driver);
            webDriverUtilities.ImplicitlyWait(driver, 10); //implicit wait
            webDriverUtilities.MaximizeWindow(driver);

            extentTest = extentReports.CreateTest("ACTITIME");


            String Url = excelUtilities.excelData(0, 1); //fetching url from excelsheet
             
            
            
            driver.Navigate().GoToUrl(Url); //go to Url actiTIME

            String Username =  excelUtilities.excelData(1, 1); //fetching username from excelsheet
            String Password = excelUtilities.excelData(2, 1); //fetching password from excel sheet
            loginPageElements.Login(Username, Password);  //Login method to login to actiTIME
           webDriverUtilities.ExplicitWait(driver, 10); //explicit wait

            String aTitle = driver.Title;
            Console.WriteLine(aTitle);
            Console.WriteLine(eTitle);

            try
            {
                Assert.AreEqual(eTitle, aTitle); //assert statement to compare the expected and actual title
            }
            catch(Exception ex)
            {
                extentTest.Log(Status.Info, "Page screenshot");
                webDriverUtilities.ScreenShot(driver);
               
                Console.WriteLine("screenshot taken");
            }
        }
       */

        
        
        [TestMethod]
        [TestCategory("ExtentHtmlReporter")]
        [DataTestMethod]
        [DataRow("https://www.facebook.com/", "Facebook – log in or sign up")]
        [DataRow("https://medium.com/", "Medium")]
        [DataRow("https://www.bbc.com/", "BBC - Homepage")]
        public void DataRowAndDataDriven(String url, String eTitle)
        {
        //    var screenShotPath = "C:\\Users\\panth\\source\\repos\\UnitTestProject1\\UnitTestProject1\\GenericUtilities\\ScreenShot\\screens.png";
            extentTest = extentReports.CreateTest(url+eTitle+"Test");


            driver.Navigate().GoToUrl(url);
            String aTitle = driver.Title;
            Console.WriteLine(aTitle);
            Console.WriteLine(eTitle);
            try
            {
                // Assert.IsTrue(aTitle.Contains(eTitle));
              Assert.AreEqual(eTitle, aTitle);
             //   Assert.IsFalse(false);
            // Assert.Fail();
            }
            catch (Exception e)
            {
               // extentTest.AddScreenCaptureFromPath(screenShotPath); //invalid arguments

                extentTest.Log(Status.Fail,url+aTitle+"Page screenshot");
               webDriverUtilities.ScreenShot(driver);
                extentTest.AddScreenCaptureFromPath(screenShotPath);
            }
        }


  

    }
}
