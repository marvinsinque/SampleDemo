using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPageObject.PageObject
{
    public class MyAccountPage : BasePage
    {
        public MyAccountPage(IWebDriver driver) : base(driver)
        {

        }
        //Locator for MyAccountPage
        public By myAddressesBtn = By.XPath("//a[@title ='Addresses']");
     

        //Method for MyAccountPage
        public void ClickMyAddressesBtn()
        {
            weBdriver.FindElement(myAddressesBtn).Click();
        }

        




       
    }
}

    


 