using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace OisinMoloneySeleniumTasks.PageObjects
{
    class LoginPage
    {
        [FindsBy(How = How.Id, Using = "title")]
        public IWebElement TitleBox { get; set; }

        [FindsBy(How = How.Id, Using = "firstName")]
        public IWebElement FirstNameBox { get; set; }

        [FindsBy(How = How.Id, Using = "lastName")]
        public IWebElement LastNameBox { get; set; }

        [FindsBy(How = How.Id, Using = "mobile")]
        public IWebElement MobileNumberBox { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailAddressBox { get; set; }

        [FindsBy(How = How.Id, Using = "newPassword")]
        public IWebElement PasswordBox { get; set; }

        [FindsBy(How = How.Id, Using = "confirmPassword")]
        public IWebElement ConfirmPasswordBox { get; set; }

        [FindsBy(How = How.Id, Using = "registryTandCs")]
        public IWebElement PrivacyAndTermsCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div/div[2]/section[2]/div/form/button")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div/div[2]/section[2]/div/form/div[6]/div/ul/li")]
        public IWebElement PleaseEnterValidEmailAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div/div[2]/section[2]/div/form/div[10]/ul/li")]
        public IWebElement ThisValueIsRequired { get; set; }

        public void EnterUserDetails(IWebDriver driver, string preferredTitle, string firstName, string lastName, string mobileNumber, string password, string confirmPassword)
        {

            // Select Title from dropdown list
            var title = driver.FindElement(By.Id("title"));

            var selectElement = new SelectElement(title);
            selectElement.SelectByValue(preferredTitle);

            // Enter First Name
           FirstNameBox.SendKeys(firstName);

            // Select Last Name
            LastNameBox.SendKeys(lastName);

            // Enter mobile number
            MobileNumberBox.SendKeys(mobileNumber);

            // Enter password
            PasswordBox.SendKeys(password);

            // Confirm password
            ConfirmPasswordBox.SendKeys(confirmPassword);

        }
    }
}
