using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.ObjectRepository.ActitimeLogin
{
    public class LoginPageElements
    {
        //DECLARATION
        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement username { get; set; }

        [FindsBy(How =How.Name, Using = "pwd")]
        private IWebElement password { get; set; }

        [FindsBy(How =How.ClassName, Using = "initial")]
        private IWebElement loginBtn { get; set; }

        //initialization
        public LoginPageElements(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

      
        //utilization
        public void Login(string Username, string Password)
        {
             username.SendKeys(Username);
            password.SendKeys(Password);
            loginBtn.Click();
        }
    }
}
