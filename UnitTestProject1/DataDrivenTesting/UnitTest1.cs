using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace UnitTestProject1.DataDrivenTesting
{
    [TestClass]
    public class UnitTest1
    {
        public static IWebDriver driver;

        [TestMethod]
        [DataTestMethod]
        [DataRow("https://www.facebook.com/","Facebook")]
        [DataRow("https://medium.com/","Medium")]
        [DataRow("https://www.bbc.com/","BBC")]
        public void DataRowAndDataDriven(String url, String eTitle)
        {
            driver.Url = url;
            String  aTitle = driver.Title;
            Console.WriteLine(aTitle);
            try
            {
                Assert.IsTrue(aTitle.Contains(eTitle));
            }
            catch(Exception e) 
            { 
            Console.WriteLine(eTitle+" title not matching");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                driver.Close();
                driver.Dispose();
                Assert.IsTrue(aTitle.Contains(eTitle));
            }
        }

        [TestInitialize]
        [DataTestMethod]
       
        public void Initialize()
        { 
            driver = new ChromeDriver();
           

        }

    }
}
