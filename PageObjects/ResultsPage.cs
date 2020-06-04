using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using SeleniumExtras.PageObjects;

namespace OisinMoloneySeleniumTasks.PageObjects
{
    class ResultsPage
    {
        [FindsBy(How = How.PartialLinkText, Using = "Hamptons Lamp")]
        public IWebElement SearchResult {get; set;}
    }
}
