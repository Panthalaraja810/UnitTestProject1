using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.TestScripts
{
    [TestClass]
    public class Practise2
    {
        private ReadOnlyCollection<string> handles;

        [TestMethod]
        public void test()
        {
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait =TimeSpan.FromSeconds(5);
            driver.Url = "https://secure.indeed.com/auth?hl=en_IN&co=IN&continue=https%3A%2F%2Fin.indeed.com%2F%3Fr%3Dus&tmpl=desktop&service=my&from=gnav-util-homepage&jsContinue=https%3A%2F%2Fin.indeed.com%2F&empContinue=https%3A%2F%2Faccount.indeed.com%2Fmyaccess&_ga=2.11004604.942636905.1682611851-567037357.1682611851";
            driver.FindElement(By.XPath("//button[@id='login-google-button']")).Click();
            driver.FindElement(By.XPath("//button[@id='login-facebook-button']")).Click();
            handles =driver.WindowHandles;

            foreach(String handle in handles)
            {
                driver.SwitchTo().Window(handle);
                string title = driver.Title;
                Console.WriteLine(title);
            }

           String Page = driver.PageSource;

          String currentUrl = driver.CurrentWindowHandle;

         ReadOnlyCollection<String> handles =  driver.WindowHandles;

            driver.Navigate().Forward();
            driver.Navigate().Back();
            driver.Navigate().Refresh();

            String title =driver.Title;

          

        }
       







    }

    
}
