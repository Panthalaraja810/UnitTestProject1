    using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.GenericUtilities
{
    public class IWebDriverUtilities 
    {
        ExtentTest extentTest;
        public void ImplicitlyWait(IWebDriver driver, long time)
        {
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(time);
        }

        public void ExplicitWait(IWebDriver driver, long time)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));

            // wait.Until(ExpectedConditions.ElementIsVisible(By.Id("logoutLink")));
            wait.Until(ExpectedConditions.TitleContains("actiTIME - Enter Time-Track"));
        }

        public void MaximizeWindow(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }

        public void ScreenShot(IWebDriver driver)
        {
            ITakesScreenshot takeScreenShot = (ITakesScreenshot)driver;

            Screenshot screenShot = takeScreenShot.GetScreenshot();
            Main.BaseCls.screenShotPath = "C:\\Users\\panth\\source\\repos\\UnitTestProject1\\UnitTestProject1\\GenericUtilities\\ScreenShot\\screens.png";
            screenShot.SaveAsFile(Main.BaseCls.screenShotPath, ScreenshotImageFormat.Png);
        }

    }
}
