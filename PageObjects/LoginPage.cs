using OpenQA.Selenium;
using Reply1CRM.Helpers;

namespace Reply1CRM.PageObjects
{
    public class LoginPage : BasePage
    {
        private const string url = "https://demo.1crmcloud.com/login.php";
        private const string loginData = "admin";

        public LoginPage(IWebDriver driver) : base(driver) { }

        private IWebElement userNameField => _driver.FindElement(By.CssSelector("#login_user"), 10);
        private IWebElement passwordField => _driver.FindElement(By.CssSelector("#login_pass"), 10);
        private IWebElement loginButton => _driver.FindElement(By.CssSelector("#login_button"), 10);
        private By avatar => By.CssSelector(".default-avatar");

        public LoginPage NavigateToLoginPage()
        {
            if (_driver.Url != url) 
            {
                _driver.Navigate().GoToUrl(url);
            }

            return this;
        }

        public LoginPage PerformLogin()
        {
            userNameField.SendKeys(loginData);
            passwordField.SendKeys(loginData);
            loginButton.Click();

            return this;
        }

        public void EnsureUserIsLoggedIn()
        {
            _driver.WaitForVisible(avatar);
        }
    }
}
