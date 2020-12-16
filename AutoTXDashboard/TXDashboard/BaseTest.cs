using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AventStack.ExtentReports.Reporter;

namespace Demo
{
    /// <summary>
    /// Base Class for the Test
    /// </summary>
    public class BaseTest
    {

        public static ExtentTest test;
        public static ExtentReports extent;
        protected IWebDriver driver;
        private static string user = @"C:\Users\MarvinS\Downloads\AutoTXDashboard\AutoTXDashboard\TXDashboard\data.json";
        public IConfigurationRoot configuration = new ConfigurationBuilder().AddJsonFile(user, optional: true).Build();


        public void Browser(string Browser)
        {
            switch (Browser)
            {
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                case "Chrome":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("no-sandbox");
                    driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
                    driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));
                    break;
            }

        }

        public void WaitTime(int waitTimeInSeconds)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(waitTimeInSeconds);
        }


        protected void UITest(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                ITakesScreenshot screen = driver as ITakesScreenshot;
                var PathToFolder = "C:\\Users\\MarvinS\\Desktop\\Screenshots\\Screenshot";
                Screenshot scrnst = screen.GetScreenshot();  // Screenshot is a class inside OpenQA.Selenium namespace
                string filename = PathToFolder + DateTime.Now.ToString("HHmmss") + ".png";
                scrnst.SaveAsFile(filename, ScreenshotImageFormat.Png);
                throw ex;
            }
        }

    }
}


