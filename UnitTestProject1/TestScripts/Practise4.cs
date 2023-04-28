using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.TestScripts
{
    [TestClass]
    public class Practise4
    {
        [TestMethod]
        public void test()
        {
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://secure.indeed.com/auth?hl=en_IN&co=IN&continue=https%3A%2F%2Fin.indeed.com%2F%3Fr%3Dus&tmpl=desktop&service=my&from=gnav-util-homepage&jsContinue=https%3A%2F%2Fin.indeed.com%2F&empContinue=https%3A%2F%2Faccount.indeed.com%2Fmyaccess&_ga=2.11004604.942636905.1682611851-567037357.1682611851";
            driver.FindElement(By.XPath("//button[@id='login-google-button']")).Click();
            driver.FindElement(By.XPath("//button[@id='login-facebook-button']")).Click();
            driver.FindElement(By.XPath("//button[@id='apple-signin-button']")).Click();

            IReadOnlyCollection<String> allWh = driver.WindowHandles;

            foreach(String wh in allWh)
            {
               var tit = driver.SwitchTo().Window(wh);
               var title = tit.Title;
                Console.WriteLine(title);
                
            }
        }

    }
}
