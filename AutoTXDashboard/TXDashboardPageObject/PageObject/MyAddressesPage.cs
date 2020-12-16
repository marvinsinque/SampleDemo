using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPageObject.PageObject
{
    public class MyAddressesPage : BasePage
    {
        public MyAddressesPage(IWebDriver driver) : base(driver)
        {

        }
        //Locators for MyAddressesPage
        public By addNewAddressBtn = By.XPath("//a[@title ='Add an address']");
        public By addressField1 = By.Id("address1");
        public By addressField2 = By.Id("address2");
        public By cityField = By.Id("city");
        public By stateDropdown = By.Id("id_state");
        public By postCodeField = By.Id("postcode");
        public By countryDropdown = By.Id("id_country");
        public By additionalInfoField = By.Id("other");
        public By homePhoneField = By.Id("phone");
        public By mobilePhoneField = By.Id("phone_mobile");
        public By addressAliasField = By.Id("alias");
        public By saveBtn = By.Id("submitAddress");


        //Methods for MyAddressesPage
        public void EnterRequiredFormDetailsForNewAddress(string address, string city, string state, string zipcode,string homephone, string mobilephone)
       {
            EnterAddressLine1(address);
            EnterCity(city);
            SelectState(state);
            EnterPostalCode(zipcode);
            EnterHomePhone(homephone);
            EnterMobilePhone(mobilephone);
        }
        public void ClickAddNewAddressesBtn()
        {
            weBdriver.FindElement(addNewAddressBtn).Click();
        }

        public void ClickSaveBtn()
        {
            weBdriver.FindElement(saveBtn).Click();
        }

        public void EnterAddressLine1(string address1)
        {
             weBdriver.FindElement(addressField1).SendKeys(address1);
        }

        public void EnterAddressLine2(string address2)
        {
            weBdriver.FindElement(addressField2).SendKeys(address2);
        }

        public void EnterCity(string city)
        {
            weBdriver.FindElement(cityField).SendKeys(city);
        }

        public void SelectState(string state)
        {
            var selectState = new SelectElement(weBdriver.FindElement(stateDropdown));
            selectState.SelectByValue(state);
        }

        public void EnterPostalCode(string postCode)
        {
            weBdriver.FindElement(postCodeField).SendKeys(postCode);
        }

        public void SelectCountry(string country)
        {
            var selectCountry = new SelectElement(weBdriver.FindElement(countryDropdown));
            selectCountry.SelectByText(country);
        }

        public void EnterAdditionalInfo(string addInfo)
        {
            weBdriver.FindElement(additionalInfoField).SendKeys(addInfo);
        }

        public void EnterHomePhone(string homePhone)
        {
            weBdriver.FindElement(homePhoneField).SendKeys(homePhone);
        }

        public void EnterMobilePhone(string mobilePhone)
        {
            weBdriver.FindElement(mobilePhoneField).SendKeys(mobilePhone);
        }

        public void EnterAddressAlias(string addressAlias)
        {
            weBdriver.FindElement(addressAliasField).SendKeys(addressAlias);
        }






    }
}

    


 