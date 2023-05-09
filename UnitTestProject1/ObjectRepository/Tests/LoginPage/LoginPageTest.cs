using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
       IWebDriverUtilities webDriverUtilities = new IWebDriverUtilities(); //initializing the webdriver utilities
        ExcelUtilities excelUtilities = new ExcelUtilities();
     //   String eTitle = "actiTIME - Enter Time-Track1"; //expected title
  
        [TestInitialize]
        public void InitializaTest() //test initializer method
        {
            //opening the browser
            driver = new ChromeDriver();
        }

        [TestCleanup]
        public void TestCleanupMethod()
        {
            driver.Quit(); //closing the browser
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
        [DataTestMethod]
        [TestCategory("ExtentHtmlReporter")]
        [DataRow("https://www.facebook.com/", "Facebook – log in or sign up")]
        [DataRow("https://medium.com/", "Medium32e")]
        [DataRow("https://www.bbc.com/", "BBC - Homepage")]
        public void DataRowAndDataDriven(String url, String eTitle)
        {
           
            driver.Url = url;
           webDriverUtilities.ImplicitlyWait(driver, 10);
            String aTitle = driver.Title;
            extentTest = extentReports.CreateTest(url + eTitle + "Test");
            extentTest.Info(url + aTitle);
            Console.WriteLine(aTitle);
            Console.WriteLine(eTitle);
            try
            {
                Assert.AreEqual(eTitle, aTitle);
                extentTest.Pass("passed");    
            }
            catch (Exception e)
            {
                extentTest.Fail("failed");
                extentTest.Info(e);
                IWebDriverUtilities.ScreenShot(driver);
                extentTest.AddScreenCaptureFromPath(screenShotPath);
            }
            
        }




    }
}
