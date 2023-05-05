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
        String eTitle = "actiTIME - Enter Time-Track"; //expected title

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
        }

        [TestMethod]
        [TestCategory("LoginPage")]
        public void VerificationOfTest()
        {
            LoginPageElements loginPageElements = new LoginPageElements(driver);
            webDriverUtilities.ImplicitlyWait(driver, 10); //implicit wait
            webDriverUtilities.MaximizeWindow(driver);
            String Url = excelUtilities.excelData(0, 1); //fetching url from excelsheet
              driver.Navigate().GoToUrl(Url); //go to Url actiTIME
           // driver.Url = "Url"; 

            String Username =  excelUtilities.excelData(1, 1); //fetching username from excelsheet
            String Password = excelUtilities.excelData(2, 1); //fetching password from excel sheet
            loginPageElements.Login(Username, Password);  //Login method to login to actiTIME
           webDriverUtilities.ExplicitWait(driver, 10); //explicit wait

            String aTitle = driver.Title;
            Console.WriteLine(aTitle);
            Console.WriteLine(eTitle);
            Assert.AreEqual(eTitle,aTitle); //assert statement to compare the expected and actual title
          
        }

    }
}
