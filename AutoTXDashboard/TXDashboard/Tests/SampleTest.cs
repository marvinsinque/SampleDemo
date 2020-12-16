using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using DemoPageObject.PageObject;
using Demo;

namespace Demo
{
    [TestClass]
    public class SampleTest : BaseTest
    {

        /// <summary>
        /// This will execute once for the test class
        /// </summary>
        /// <param name="context"></param>
        [ClassInitialize]
        public static void TestFixtureSetup(TestContext context)
        {
            extent = new ExtentReports();
            var htmlreporter = new ExtentHtmlReporter(@"C:\ReportResults\Report" + DateTime.Now.ToString("_MMddyyyy_hhmmtt") + ".html");
            extent.AttachReporter(htmlreporter);
        }

        /// <summary>
        /// This will run alweays before every test method
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            var browser = configuration["myConfig:Browser"];
            Browser(browser);
            WaitTime(10);
            var URL = configuration["myConfig:URL"];
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// This Test registers 3 new users and will add an address for each created user
        /// </summary>
        [TestMethod]
        public void CreateThreeNewAccountsAndAddNewAddresses()
        {

            test = extent.CreateTest("Test Case #001 Registering new Users");
            test.Log(Status.Info, "Go to URL");
            AuthenticationPage authenticationPage = new AuthenticationPage(driver);
            try
            {
                authenticationPage.ClickSignIn();
                var email = configuration["myConfig:emailAddress"];
                authenticationPage.CreateAccount(email);
                CreateAccountPage createAccount = new CreateAccountPage(driver);
                createAccount.ClickMaleRadioButton();
                test.Log(Status.Info, "Email Address Valid");
                test.Log(Status.Info, "Filling up Personal Information Details for First User");
                test.Log(Status.Info, "Enter Firstname for First User");
                var fname = configuration["myConfig:firstname"];
                createAccount.EnterFirstName(fname);
                test.Log(Status.Info, "Enter LastName for First User");
                var lname = configuration["myConfig:lastname"];
                createAccount.EnterLastName(lname);
                test.Log(Status.Info, "Enter Password for First User");
                var password = configuration["myConfig:password"];
                createAccount.EnterPassword(password);
                test.Log(Status.Info, "Selecting Date for First User");
                var day = configuration["myConfig:day"];
                var month = configuration["myConfig:month"];
                var year = configuration["myConfig:year"];
                createAccount.SelectDate(day, month, year);
                createAccount.ClickSignUpForNewsLetter();
                test.Log(Status.Info, "Enter Company Name for First User");
                var company = configuration["myConfig:company"];
                createAccount.EnterCompanyName(company);
                test.Log(Status.Info, "Enter Address for First User");
                var address = configuration["myConfig:address1"];
                createAccount.EnterAddressLine1(address);
                test.Log(Status.Info, "Enter City for First User");
                var city = configuration["myConfig:city"];
                createAccount.EnterCity(city);
                test.Log(Status.Info, "Select State for First User");
                var state = configuration["myConfig:state"];
                createAccount.SelectState(state);
                test.Log(Status.Info, "Enter Postal Code for First User");
                var postCode = configuration["myConfig:zip"];
                createAccount.EnterPostalCode(postCode);
                test.Log(Status.Info, "Select Country for First User");
                var country = configuration["myConfig:country"];
                createAccount.SelectCountry(country);
                test.Log(Status.Info, "Enter Additional Info for First User");
                var additionalInfo = configuration["myConfig:additional info"];
                createAccount.EnterAdditionalInfo(additionalInfo);
                test.Log(Status.Info, "Enter Homephone for First User");
                var homePhone = configuration["myConfig:homephone"];
                createAccount.EnterHomePhone(homePhone);
                test.Log(Status.Info, "Enter Mobile Phone for First User");
                var mobilePhone = configuration["myConfig:mobilephone"];
                createAccount.EnterMobilePhone(mobilePhone);
                test.Log(Status.Info, "Enter Address Alias for First User");
                var addressAlias = configuration["myConfig:addressAlias"];
                createAccount.EnterAddressAlias(addressAlias);
                test.Log(Status.Info, "Clicking Register Button");
                createAccount.ClickRegisterBtn();
                createAccount.ClickSignOut();
                test.Log(Status.Info, "Logging in using first created User");
                authenticationPage.Login(email, password);
                test.Log(Status.Info, "Adding a new address");
                MyAccountPage myAccountPage = new MyAccountPage(driver);
                myAccountPage.ClickMyAddressesBtn();
                test.Log(Status.Info, "Click add new address Button");
                MyAddressesPage myAddresses = new MyAddressesPage(driver);
                myAddresses.ClickAddNewAddressesBtn();
                test.Log(Status.Info, "Entering details for new address");
                var newAddress1 = configuration["myConfig:newAddress1"];
                var newCity = configuration["myConfig:newcity"];
                var newState = configuration["myConfig:newstate"];
                var newZip = configuration["myConfig:newzip"];
                var newHomephone = configuration["myConfig:newhomephone"];
                var newMobilephone = configuration["myConfig:newmobilephone"];
                myAddresses.EnterRequiredFormDetailsForNewAddress(newAddress1, newCity, newState, newZip, newHomephone, newMobilephone);
                test.Log(Status.Info, "Saving");
                myAddresses.ClickSaveBtn();
                test.Log(Status.Info, "Click Sign Out");
                myAddresses.ClickSignOut();

                var email1 = configuration["myConfig2:emailAddress"];
                authenticationPage.CreateAccount(email1);
                createAccount.ClickMaleRadioButton();
                test.Log(Status.Info, "Email Address Valid");
                test.Log(Status.Info, "Filling up Personal Information Details for Second User");
                test.Log(Status.Info, "Enter Firstname for Second User");
                var fname1 = configuration["myConfig2:firstname"];
                createAccount.EnterFirstName(fname1);
                test.Log(Status.Info, "Enter LastName for Second User");
                var lname1 = configuration["myConfig2:lastname"];
                createAccount.EnterLastName(lname1);
                test.Log(Status.Info, "Enter Password for Second User");
                var password1 = configuration["myConfig2:password"];
                createAccount.EnterPassword(password1);
                test.Log(Status.Info, "Selecting Date for Second User");
                var day1 = configuration["myConfig2:day"];
                var month1 = configuration["myConfig2:month"];
                var year1 = configuration["myConfig2:year"];
                createAccount.SelectDate(day1, month1, year1);
                createAccount.ClickSignUpForNewsLetter();
                test.Log(Status.Info, "Enter Company Name for Second User");
                var company1 = configuration["myConfig2:company"];
                createAccount.EnterCompanyName(company1);
                test.Log(Status.Info, "Enter Address for Second User");
                var address1 = configuration["myConfig2:address1"];
                createAccount.EnterAddressLine1(address1);
                test.Log(Status.Info, "Enter City for Second User");
                var city1 = configuration["myConfig2:city"];
                createAccount.EnterCity(city1);
                test.Log(Status.Info, "Select State for Second User");
                var state1 = configuration["myConfig2:state"];
                createAccount.SelectState(state1);
                test.Log(Status.Info, "Enter Postal Code for Second User");
                var postCode1 = configuration["myConfig2:zip"];
                createAccount.EnterPostalCode(postCode1);
                test.Log(Status.Info, "Select Country for Second User");
                var country1 = configuration["myConfig2:country"];
                createAccount.SelectCountry(country1);
                test.Log(Status.Info, "Enter Additional Info for Second User");
                var additionalInfo1 = configuration["myConfig2:additional info"];
                createAccount.EnterAdditionalInfo(additionalInfo);
                test.Log(Status.Info, "Enter Homephone for Second User");
                var homePhone1 = configuration["myConfig2:homephone"];
                createAccount.EnterHomePhone(homePhone1);
                test.Log(Status.Info, "Enter Mobile Phone for Second User");
                var mobilePhone1 = configuration["myConfig2:mobilephone"];
                createAccount.EnterMobilePhone(mobilePhone1);
                test.Log(Status.Info, "Enter Address Alias for Second User");
                var addressAlias1 = configuration["myConfig2:addressAlias"];
                createAccount.EnterAddressAlias(addressAlias1);
                createAccount.ClickRegisterBtn();
                createAccount.ClickSignOut();
                test.Log(Status.Info, "Logging in using second created User");
                authenticationPage.Login(email1, password1);
                test.Log(Status.Info, "Adding a new address");
                myAccountPage.ClickMyAddressesBtn();
                test.Log(Status.Info, "Click add new address Button");
                myAddresses.ClickAddNewAddressesBtn();
                test.Log(Status.Info, "Entering details for new address");
                var newAddress2 = configuration["myConfig2:newAddress1"];
                var newCity2 = configuration["myConfig2:newcity"];
                var newState2 = configuration["myConfig2:newstate"];
                var newZip2 = configuration["myConfig2:newzip"];
                var newHomephone2 = configuration["myConfig2:newhomephone"];
                var newMobilephone2 = configuration["myConfig2:newmobilephone"];
                myAddresses.EnterRequiredFormDetailsForNewAddress(newAddress2, newCity2, newState2, newZip2, newHomephone2, newMobilephone2);
                test.Log(Status.Info, "Saving");
                myAddresses.ClickSaveBtn();
                test.Log(Status.Info, "Click Sign Out");
                myAddresses.ClickSignOut();

                var email2 = configuration["myConfig3:emailAddress"];
                authenticationPage.CreateAccount(email2);
                createAccount.ClickMaleRadioButton();
                test.Log(Status.Info, "Email Address Valid");
                test.Log(Status.Info, "Filling up Personal Information Details for Third User");
                test.Log(Status.Info, "Enter Firstname for Third User");
                var fname2 = configuration["myConfig3:firstname"];
                createAccount.EnterFirstName(fname2);
                test.Log(Status.Info, "Enter LastName for Third User");
                var lname2 = configuration["myConfig3:lastname"];
                createAccount.EnterLastName(lname2);
                test.Log(Status.Info, "Enter Password for Third User");
                var password2 = configuration["myConfig3:password"];
                createAccount.EnterPassword(password2);
                test.Log(Status.Info, "Selecting Date for Third User");
                var day2 = configuration["myConfig3:day"];
                var month2 = configuration["myConfig3:month"];
                var year2 = configuration["myConfig3:year"];
                createAccount.SelectDate(day2, month2, year2);
                createAccount.ClickSignUpForNewsLetter();
                test.Log(Status.Info, "Enter Company Name for Third User");
                var company2 = configuration["myConfig3:company"];
                createAccount.EnterCompanyName(company2);
                test.Log(Status.Info, "Enter Address for Third User");
                var address2 = configuration["myConfig3:address1"];
                createAccount.EnterAddressLine1(address2);
                test.Log(Status.Info, "Enter City for Third User");
                var city2 = configuration["myConfig3:city"];
                createAccount.EnterCity(city2);
                test.Log(Status.Info, "Select State for Third User");
                var state2 = configuration["myConfig3:state"];
                createAccount.SelectState(state2);
                test.Log(Status.Info, "Enter Postal Code for Third User");
                var postcode2 = configuration["myConfig3:zip"];
                createAccount.EnterPostalCode(postcode2);
                test.Log(Status.Info, "Select Country for Third User");
                var country2 = configuration["myConfig3:country"];
                createAccount.SelectCountry(country2);
                test.Log(Status.Info, "Enter Additional Info for Third User");
                var additionalInfo2 = configuration["myConfig3:additional info"];
                createAccount.EnterAdditionalInfo(additionalInfo2);
                test.Log(Status.Info, "Enter Homephone for Third User");
                var homePhone2 = configuration["myConfig3:homephone"];
                createAccount.EnterHomePhone(homePhone2);
                test.Log(Status.Info, "Enter Mobile Phone for Third User");
                var mobilePhone2 = configuration["myConfig3:mobilephone"];
                createAccount.EnterMobilePhone(mobilePhone2);
                test.Log(Status.Info, "Enter Address Alias for Third User");
                var addressAlias2 = configuration["myConfig3:addressAlias"];
                createAccount.EnterAddressAlias(addressAlias2);
                createAccount.ClickRegisterBtn();
                createAccount.ClickSignOut();
                test.Log(Status.Info, "Logging in using third created User");
                authenticationPage.Login(email2, password2);
                test.Log(Status.Info, "Adding a new address");
                myAccountPage.ClickMyAddressesBtn();
                test.Log(Status.Info, "Click add new address Button");
                myAddresses.ClickAddNewAddressesBtn();
                test.Log(Status.Info, "Entering details for new address");
                var newAddress3 = configuration["myConfig3:newAddress1"];
                var newCity3 = configuration["myConfig3:newcity"];
                var newState3 = configuration["myConfig3:newstate"];
                var newZip3 = configuration["myConfig3:newzip"];
                var newHomephone3 = configuration["myConfig3:newhomephone"];
                var newMobilephone3 = configuration["myConfig3:newmobilephone"];
                myAddresses.EnterRequiredFormDetailsForNewAddress(newAddress3, newCity3, newState3, newZip3, newHomephone3, newMobilephone3);
                test.Log(Status.Info, "Saving");
                myAddresses.ClickSaveBtn();
                test.Log(Status.Info, "Click Sign Out");
                myAddresses.ClickSignOut();
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Fail");
                throw e;
            }
        }


        /// <summary>
        /// This Test will show that we can run it on different browsers i.e Chrome, Firefox and IE
        /// </summary>
        [TestMethod]
        public void BrowserTest()
        {

        }


        /// <summary>
        /// This Test will show screenshot upon failure
        /// </summary>
        [TestMethod]
        public void ScreenshotUponFailure()
        {
            UITest(() =>
            {
                AuthenticationPage authentication = new AuthenticationPage(driver);
                authentication.ClickSignIn();
                authentication.LoginFailed("12345", "12345");
            });
        }


        /// <summary>
        /// Browser closing and generating of test report
        /// </summary>
        [TestCleanup]

        public void CleanUp()
        {
            extent.Flush();
            driver.Close();
        }
    }
}
