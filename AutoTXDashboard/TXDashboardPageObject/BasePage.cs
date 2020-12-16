using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoPageObject.PageObject
{
    /// <summary>
    /// Base class for the Pages
    /// </summary>
   public class BasePage 
    {
        public static IWebDriver weBdriver { get; set; }
		private  static string user = @"C:\Users\MarvinS\Downloads\AutoTXDashboard\AutoTXDashboard\TXDashboard\data.json";
		public  IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile(user, optional: true).Build();

        public BasePage(IWebDriver driver)
        {
            weBdriver = driver;
        }

        //Common Locators for all the pages
        public By signInBtn = By.CssSelector("a.login");
        public By signOutBtn = By.CssSelector("a.logout");



        //Reusable methods for all the pages
        public void ClickSignIn()
        {
             weBdriver.FindElement(signInBtn).Click();
        }

        public void ClickSignOut()
        {
            weBdriver.FindElement(signOutBtn).Click();
        }


        public void WaitTime(int waitTimeInSeconds)
        {
            weBdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(waitTimeInSeconds);
        }

        public void NavigateToUrl(string url)
        {
            weBdriver.Navigate().GoToUrl(url);
        }

        public string GetPageUrl()
        {
            return weBdriver.Url;
        }

        public void VerifyElementIsPresent(IWebElement element)
        {
            try
            {
                Assert.IsTrue(element.Displayed);
            }
            catch (AssertFailedException)
            {
                Console.WriteLine("Failed");
            }
        }

        public void ScrollToElement(By locator)
        {
            var element = weBdriver.FindElement(locator);
            Actions action = new Actions(weBdriver);
            action.MoveToElement(element);
            action.Perform();
        }

        public bool verifyElementIsPresent(By locator)
        {
          var size =  weBdriver.FindElements(locator).Count;

            if (size >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void SwitchTabOnBrowser()
        {
            weBdriver.SwitchTo().Window(weBdriver.WindowHandles.Last());
        }

        public void NavigateForward()
        {
            weBdriver.Navigate().Forward();
        }
		
        public void NavigateBack()
        {
            weBdriver.Navigate().Back();
        }

        public string getTitle()
        {
            return weBdriver.Title;
        }

 


    }
}
