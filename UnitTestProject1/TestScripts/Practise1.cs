using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace UnitTestProject1.TestScripts
{
    [TestClass]
    public class Practise1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Url = "https://www.google.com/";
            Console.WriteLine(  driver.Url);
        }
    }
}
