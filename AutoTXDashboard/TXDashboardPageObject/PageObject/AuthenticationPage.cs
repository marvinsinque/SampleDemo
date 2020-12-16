using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPageObject.PageObject
{
    public class AuthenticationPage : BasePage
    {
        public AuthenticationPage(IWebDriver driver) : base(driver)
        {

        }

       //Locators for Authentication Page
        public By createEmailAddressField = By.Id("email_create");
        public By createAccountBtn = By.Id("SubmitCreate");
        public By emailLoginField = By.Id("email");
        public By passwordField = By.Id("passwd");
        public By loginInBtn = By.Id("SubmitLogin");
        public By loginInBtnFailed = By.Id("SubmitLogin1");

        //Methods for Authentication Page
        public void Login(string email, string password)
        {
            weBdriver.FindElement(emailLoginField).SendKeys(email);
            weBdriver.FindElement(passwordField).SendKeys(password);
            weBdriver.FindElement(loginInBtn).Click();
        }

        public void LoginFailed(string email, string password)
        {
            weBdriver.FindElement(emailLoginField).SendKeys(email);
            weBdriver.FindElement(passwordField).SendKeys(password);
            weBdriver.FindElement(loginInBtnFailed).Click();
        }

        public void CreateAccount(string email)
        {
            weBdriver.FindElement(createEmailAddressField).SendKeys(email + Keys.Tab);
            WebDriverWait wait = new WebDriverWait(weBdriver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='create-account_form']/div/div[@class='form-group form-ok']")));
            weBdriver.FindElement(createAccountBtn).Click();
        }




       
    }
}

    


 