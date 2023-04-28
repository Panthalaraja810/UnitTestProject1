using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace UnitTestProject1.TestScripts
{
    [TestClass]
    public class Practice5
    {
        [TestMethod]
        public void TestMethod1()
        {
           IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Url = "https://www.selenium.dev/";

          var  element =driver.FindElement(By.XPath("//h4[text()='Selenium WebDriver']"));
          var col = element.GetCssValue("color");
            Console.WriteLine(col);
        }
    }
}
