using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OisinMoloneyTasks
{
    public class UtilityClass
    {
        public static void LaunchChromeBrowser()
        {
            string Address = "https://www.dunnesstores.com/";
            IWebDriver driver = new ChromeDriver();
            driver.Url = Address;
        }
    }

}
