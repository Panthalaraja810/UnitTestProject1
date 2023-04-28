using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace UnitTestProject1.TestScripts
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1() //alert popup
        {
            IWebDriver driver =new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            driver.Url = "https://demoqa.com/alerts";
            driver.FindElement(By.XPath("//button[@id='timerAlertButton']")).Click();
           WebDriverWait wait =new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("timerAlertButton")));

            driver.SwitchTo().Alert().Accept();

        }
    }
}
