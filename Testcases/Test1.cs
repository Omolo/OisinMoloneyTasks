using NUnit.Framework;
using OisinMoloneySeleniumTasks.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.IO;

namespace OisinMoloneySeleniumTasks.Testcases
{
    class Test1
    {
        string Address = "https://www.dunnesstores.com/";


        [Test]
        public void ClickResultLink()
        {
            IWebDriver driver = new ChromeDriver();
            string searchQuery = "Hamptons Lamp";

            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);

            var resultsPage = new ResultsPage();
            PageFactory.InitElements(driver, resultsPage);

            var resultPage = new ResultPage();
            PageFactory.Equals(driver, resultPage);

            // Launch browser at page
            driver.Url = Address;

            // Close cookie policy banner, if open
            homePage.CloseCookiesBanner();

            // Enter search query
            homePage.CreateAndRunSearch(searchQuery);

            // Validate result is returned
            Assert.IsTrue(UtilityClasses.ExtensionsClass.CheckElementExists(resultsPage.SearchResult));

            // Click into result link
            resultsPage.SearchResult.Click();

            // Validate page is loaded
            Assert.AreEqual("Dunnes Stores | Blue Paul Costelloe Living Hamptons Lamp", driver.Title);

            driver.Close();

        }

    }
    


}