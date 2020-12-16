using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPageObject.PageObject
{
    public class CreateAccountPage : BasePage
    {
        public CreateAccountPage(IWebDriver driver) : base(driver)
        {

        }
        //Locator for CreateAccountPage
        public By maleRadioBtn = By.Id("id_gender1");
        public By femaleRadioBtn = By.Id("id_gender2");
        public By firstNameField = By.Id("customer_firstname");
        public By lastNameField = By.Id("customer_lastname");
        public By passwordField = By.Id("passwd");
        public By daysDropdown = By.Id("days");
        public By monthDropdown = By.Id("months");
        public By yearDropdown = By.Id("years");
        public By newsletterChkBox = By.Id("newsletter");
        public By optInChkBox = By.Id("optin");
        public By companyField = By.Id("company");
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
        public By registerBtn = By.Id("submitAccount");


        //Methods for CreateAccountPage
        public void ClickMaleRadioButton()
        {
            weBdriver.FindElement(maleRadioBtn).Click();
        }

        public void ClickFemaleRadioButton()
        {
            weBdriver.FindElement(femaleRadioBtn).Click();
        }

        public void EnterFirstName(string fname)
        {
            weBdriver.FindElement(firstNameField).SendKeys(fname);
        }

        public void EnterLastName(string lname)
        {
            weBdriver.FindElement(lastNameField).SendKeys(lname);
        }

        public void EnterPassword(string pword)
        {
            weBdriver.FindElement(passwordField).SendKeys(pword);
        }

        public void SelectDate(string days, string month, string year)
        {
            var selectDays = new SelectElement(weBdriver.FindElement(daysDropdown));
            selectDays.SelectByValue(days);
            var selectMonth = new SelectElement(weBdriver.FindElement(monthDropdown));
            selectMonth.SelectByValue(month);
            var selectYear = new SelectElement(weBdriver.FindElement(yearDropdown));
            selectYear.SelectByValue(year);
        }

        public void ClickSignUpForNewsLetter()
        {
            weBdriver.FindElement(newsletterChkBox).Click();
        }

        public void ClickOptInCheckBox()
        {
            weBdriver.FindElement(optInChkBox).Click();
        }
        public void EnterCompanyName(string company)
        {
            weBdriver.FindElement(companyField).SendKeys(company);
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

        public void ClickRegisterBtn()
        {
            weBdriver.FindElement(registerBtn).Click();
        }
    }

}

    


 