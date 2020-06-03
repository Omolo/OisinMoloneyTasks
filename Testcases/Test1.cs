using NUnit.Framework;
using OisinMoloneyTasks.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.IO;

namespace OisinMoloneyTasks
{
    class Task1
    {
        string Address = "https://www.dunnesstores.com/";
        
        [Test]
        public void GoToWebPage()
        {
            
            IWebDriver driver = new ChromeDriver();
            // Launch browser at page
            driver.Url = Address;

            // Validate page is loaded
            Assert.AreEqual("Dunnes Stores | Fashion, Home, Kids & More", driver.Title);

            // Close browser
            driver.Close();
        }

        [Test]
        public void RunASearch()
        {
            IWebDriver driver = new ChromeDriver();
            string searchQuery = "Hamptons Lamp";

            // Launch browser at page
            driver.Url = Address;

            // Close cookie policy banner, if open
            WebPages.homePage.CloseCookiesBanner();

            // Enter search query
            WebPages.homePage.CreateAndRunSearch(searchQuery);

            // Validate result is returned
            Assert.IsTrue(UtilityClasses.ExtensionsClass.CheckElementExists(WebPages.resultsPage.SearchResult));

            // Close browser
            driver.Close();
        }

        [Test]
        public void ClickResultLink()
        {
            IWebDriver driver = new ChromeDriver();
            string searchQuery = "Hamptons Lamp";

            // Launch browser at page
            driver.Url = Address;

            // Close cookie policy banner, if open
            WebPages.homePage.CloseCookiesBanner();

            // Enter search query
            WebPages.homePage.CreateAndRunSearch(searchQuery);

            // Validate result is returned
            Assert.IsTrue(UtilityClasses.ExtensionsClass.CheckElementExists(WebPages.resultsPage.SearchResult));

            // Click into result link
            WebPages.resultsPage.SearchResult.Click();


        //    driver.Close();

        }

    }
    


}