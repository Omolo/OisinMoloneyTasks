using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using SeleniumExtras.PageObjects;

namespace OisinMoloneyTasks.PageObjects
{
    class WebPages
    {
        private static IWebDriver driver = new ChromeDriver();

        private static T CreatePage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(driver, page);
            return page;
        }

        public static HomePage homePage
        {
            get { return CreatePage<HomePage>(); }
        }

        public static ResultsPage resultsPage
        {
            get { return CreatePage<ResultsPage>(); }
        }

    }
}
