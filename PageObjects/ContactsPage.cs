
using OpenQA.Selenium;
using Reply1CRM.Helpers;

namespace Reply1CRM.PageObjects
{
    public class ContactsPage : BasePage
    {
        private IWebElement createButton => _driver.FindElement(By.CssSelector("[name='SubPanel_create']"), 30);
        public ContactsPage(IWebDriver driver) : base(driver)
        {
        }

        public ContactsPage ClickCreateNewContactButton()
        {
            createButton.Click();
            return this;
        }
    }
}
