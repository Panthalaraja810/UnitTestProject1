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
using UnitTestProject1.ObjectRepository.ActitimeLogin;

namespace UnitTestProject1.ObjectRepository.Tests.LoginPage
{
    [TestClass]
    public class LoginPageTest
    {
        IWebDriver driver;
        IWebDriverUtilities webDriverUtilities = new IWebDriverUtilities(); //initializing the webdriver utilities
        ExcelUtilities excelUtilities = new ExcelUtilities();
        String eTitle = "actiTIME - Enter Time-Track";

        [TestCleanup]
        public void TestCleanupMethod()
        {
            driver.Close();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("LoginPage")]
        public void VerificationOfTest()
        {
            driver = new ChromeDriver(); //opening the browser

            LoginPageElements loginPageElements = new LoginPageElements(driver);
            webDriverUtilities.ImplicitlyWait(driver, 10);
            webDriverUtilities.MaximizeWindow(driver);
            String Url = excelUtilities.excelData(0, 1);
            driver.Navigate().GoToUrl(Url);
            

            String Username =  excelUtilities.excelData(1, 1);
            String Password = excelUtilities.excelData(2, 1);
            loginPageElements.Login(Username, Password);
            Thread.Sleep(6000);
           webDriverUtilities.ExplicitWait(driver, 10);

            String aTitle = driver.Title;
            Console.WriteLine(aTitle);
            Console.WriteLine(eTitle);
            Assert.AreEqual(eTitle,aTitle);
          
        }

    }
}
