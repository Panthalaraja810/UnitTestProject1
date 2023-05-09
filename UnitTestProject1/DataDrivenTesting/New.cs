using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using UnitTestProject1.Main;
using AventStack.ExtentReports;
using System.Security.Policy;

namespace UnitTestProject1.DataDrivenTesting
{
 //   [TestClass]
    public class New : BaseCls
    {
       IWebDriver driver;

        [TestMethod]
        [DataTestMethod]
        [DataRow("https://www.facebook.com/", "Facebook")]
        [DataRow("https://medium.com/", "Medium")]
        [DataRow("https://www.bbc.com/", "BBC")]
        public void DataRowAndDataDriven(String url, String eTitle)
        {
            driver.Url = url;
            String aTitle = driver.Title;
            Console.WriteLine(aTitle);
            try
            {
                Assert.IsTrue(aTitle.Contains(eTitle));
            }
            catch (Exception e)
            {
                Console.WriteLine(eTitle + " title not matching");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                driver.Close();
                driver.Dispose();
                Assert.IsTrue(aTitle.Contains(eTitle));
            }


            extentTest = extentReports.CreateTest("methodNew");

          

            
        }

      //  [TestInitialize]
        [DataTestMethod]

        public void Initialize()
        {
            driver = new ChromeDriver();


        }



    }
}

