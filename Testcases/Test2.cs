using NUnit.Framework;
using OisinMoloneySeleniumTasks.PageObjects;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;


namespace OisinMoloneySeleniumTasks.Testcases
{
    class Test2
    {
        string Address = "https://www.dunnesstores.com/";

        [Test]
        public void CreateAccountWithoutEmail()
        {
            IWebDriver driver = new ChromeDriver();

            HomePage homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);

            LoginPage loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);

            // Launch browser at page
            driver.Url = Address;

            // Validate page is loaded
            Assert.AreEqual("Dunnes Stores | Fashion, Home, Kids & More", driver.Title);

            homePage.myAccountLogin.Click();

            // Validate "Login" page has loaded
            Assert.AreEqual("Dunnes Stores | Login / Register", driver.Title);

            // Close cookie policy banner, if open
            homePage.CloseCookiesBanner();

            // Select Title from dropdown list
            loginPage.TitleBox.Click();

            // Enter User Details
            loginPage.EnterUserDetails(driver, "Mr", "John", "Doe", "01234567890", "P4ssw0rd", "P4ssw0rd");

            // Accept terms - DISABLED AS CLICK GETS INTERCEPTED
            // loginPage.PrivacyAndTermsCheckbox.SendKeys(Keys.Enter);

            // Select submit 
            loginPage.SubmitButton.Click();

            // Validate "Enter a valid email address" error message exists", and validate text
            ExpectedConditions.ElementExists(By.XPath("/html/body/main/div/div[2]/section[2]/div/form/div[6]/div/ul/li"));
            Assert.AreEqual("Please enter a valid email address", loginPage.PleaseEnterValidEmailAddress.Text);

            // As "Accept terms and conditions" is not checked, validate error message exists, and validate text
            ExpectedConditions.ElementExists(By.XPath("/html/body/main/div/div[2]/section[2]/div/form/div[10]/ul/li"));
            Assert.AreEqual("This value is required", loginPage.ThisValueIsRequired.Text);

            driver.Close();
        }
    }
}
