using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using SeleniumExtras.PageObjects;

namespace OisinMoloneyTasks.PageObjects
{
    class ResultsPage
    {
        [FindsBy(How = How.PartialLinkText, Using = "Lamp")]
        public IWebElement SearchResult {get; set;}
    }
}
