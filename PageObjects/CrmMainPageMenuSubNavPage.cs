using OpenQA.Selenium;
using Reply1CRM.Helpers;

namespace Reply1CRM.PageObjects
{
    public class CrmMainPageMenuSubNavPage : BasePage
    {
        private By ContactsButton(string subNavTitle) => By.XPath($"//a[@class='menu-tab-sub-list'][normalize-space()='{subNavTitle}']");

        public CrmMainPageMenuSubNavPage(IWebDriver driver) : base(driver)
        {
        }

        public CrmMainPageMenuSubNavPage ChooseSubNav(string subNavTitle)
        {
            var element = ContactsButton(subNavTitle);
            _driver.WaitForClickable(element);
            _driver.FindElement(element, 30).Click();
            return this;
        }
    }
}
