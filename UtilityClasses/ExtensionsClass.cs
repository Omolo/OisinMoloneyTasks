using OpenQA.Selenium;


namespace OisinMoloneySeleniumTasks.UtilityClasses
{
    public static class ExtensionsClass
    {
        public static bool CheckElementExists(this IWebElement element)
        {
            if (element == null)
            {
                return false;
            }
            else
            {
                return true;

            }
        }



    }
}
