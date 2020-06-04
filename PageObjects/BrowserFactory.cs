using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace OisinMoloneySeleniumTasks.PageObjects
{
    class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                }
                         
                return driver;         
            }
            private set
            {
                driver = value;
            }
        }
        
        public static void InitBrowser(string browserName)
        {
            if (Driver == null)
            {
                driver = new ChromeDriver();
                
            }

        }

    }
}
