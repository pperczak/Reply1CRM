using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace Reply1CRM.Helpers
{
    public static class WebDriverFindElementsHelper
    {
        public static IWebElement FindElement(this ISearchContext context, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new DefaultWait<ISearchContext>(context);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.Timeout = TimeSpan.FromSeconds(timeoutInSeconds);
                return wait.Until(c => c.FindElement(by));
            }
            return context.FindElement(by);
        }

        public static ReadOnlyCollection<IWebElement> FindElements(this ISearchContext context, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new DefaultWait<ISearchContext>(context);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                wait.Timeout = TimeSpan.FromSeconds(timeoutInSeconds);
                return wait.Until(c => (c.FindElements(by).Count > 0) ? c.FindElements(by) : null);
            }
            return context.FindElements(by);
        }
    }
}
