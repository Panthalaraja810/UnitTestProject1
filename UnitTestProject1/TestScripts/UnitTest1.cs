using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace UnitTestProject1.TestScripts
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);

            driver.Url = "https://demoqa.com/checkbox";

            var ele = driver.FindElement(By.XPath("//span[@class='rct-checkbox']"));

            bool isDisplayed = ele.Displayed;
            bool isEnabled = ele.Enabled;
            bool isSelected = ele.Selected;

            Console.WriteLine("box displayed "+isDisplayed);
            Console.WriteLine("box enabled "+isEnabled);
            Console.WriteLine("box selected "+isSelected);

            driver.Quit();
        }
    }
}
