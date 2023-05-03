using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Reflection;

namespace UnitTestProject1.DataDrivenTesting
{

   


    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        [TestCategory("DataDriven")]
        [Priority(1)]
        [DataTestMethod]
        [DataRow("https://www.facebook.com/", "Facebook")]
        [DataRow("https://medium.com/", "Medium")]
        [DataRow("https://www.bbc.com/", "BBC")]
        public void DataRowAndDataDriven(String url, String eTitle)
        {
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Url = url;
         String  aTitle = driver.Title;
            try
            {
                Assert.IsTrue(aTitle.Contains(eTitle));
            }
            catch(Exception e) 
            { 
            Console.WriteLine(eTitle+" title not matching");
                Console.WriteLine(e.StackTrace);
            }


        }
    }
}
