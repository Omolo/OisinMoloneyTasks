using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;


namespace OisinMoloneyTasks.PageObjects
{
    class HomePage
    {

        [FindsBy(How = How.Id, Using = "keywords")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.Id, Using = "search-btn")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "icon-cross")]
        public IWebElement CookiePolicyBannerCloseButton { get; set; }

        public void CreateAndRunSearch(string query)
        {
            SearchBox.SendKeys(query);
            SearchBox.Submit();
        }

        public void CloseCookiesBanner()
        {
            // Close cookie policy banner, if open
            if (UtilityClasses.ExtensionsClass.CheckElementExists(CookiePolicyBannerCloseButton))
            {
                CookiePolicyBannerCloseButton.Click();
            }

        }
           
    }
}
