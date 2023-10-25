using OpenQA.Selenium;
using Reply1CRM.Helpers;

namespace Reply1CRM.PageObjects
{
    public class CrmMainPageMenuNavPage : BasePage
    {
        private IWebElement SalesNMarkeringTab(string tabName) => _driver.FindElement(By.CssSelector($"a[title='{tabName}']"),30);

        public CrmMainPageMenuNavPage(IWebDriver driver) : base(driver)
        {
        }

        public CrmMainPageMenuNavPage ChooseSalesNMarketingTab(string tabName)
        {
            SalesNMarkeringTab(tabName).Click();
            return this;
        }
    }
}
