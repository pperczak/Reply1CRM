using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Reply1CRM.Helpers
{
    public static class WebDriverWaitHelper
    {
        public static void WaitForVisible(this IWebDriver driver, By byElement)
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(byElement).Displayed);
        }

        public static void WaitForClickable(this IWebDriver driver, By byElement)
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(byElement).Enabled && d.FindElement(byElement).Displayed);
        }
    }
}
