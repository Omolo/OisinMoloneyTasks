using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using SeleniumExtras.PageObjects;


namespace OisinMoloneySeleniumTasks.PageObjects
{
    class ResultPage
    {
        [FindsBy(How = How.ClassName, Using = "price__offer")]
        public IWebElement ItemPrice { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='content']/article[1]/div[2]/div[2]/section[1]/h1[1]")]
        public IWebElement ItemTitle { get; set; }

        [FindsBy(How = How.ClassName, Using = "c-product-description")]
        public IWebElement ItemDescription { get; set; }
    }
}
