using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;

namespace UnitTestProject1.TestScripts
{
    [TestClass]
    public class UnitTest2
    {

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://www.facebook.com/";

            driver.FindElement(By.XPath("//a[text()='Create new account']")).Click();

            // var sel = driver.FindElement(By.Id("day"));


           // var dayList = driver.FindElement(By.Name("birthday_day"));

         //   SelectElement s1 = new SelectElement(dayList);
           

       var monList =driver.FindElement(By.XPath("//select[@name='birthday_month']"));
          
            SelectElement s2 = new SelectElement(monList);

            

          var  yearList =driver.FindElement(By.Name("birthday_year"));
            SelectElement s3 =new SelectElement(yearList);

            s3.SelectByText("2019");
            s2.SelectByText("Jun");
         //   s1.SelectByIndex(2);

        }
    }
}
