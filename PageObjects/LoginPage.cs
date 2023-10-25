using OpenQA.Selenium;
using Reply1CRM.Helpers;

namespace Reply1CRM.PageObjects
{
    public class LoginPage
    {
        private const string url = "https://demo.1crmcloud.com/login.php";
        private IWebDriver webdriver;
        private const string loginData = "admin";

        public LoginPage(IWebDriver driver)
        {
            this.webdriver = driver;
        }

        private IWebElement userNameField => webdriver.FindElement(By.CssSelector("#login_user"), 10);
        private IWebElement passwordField => webdriver.FindElement(By.CssSelector("#login_pass"), 10);
        private IWebElement loginButton => webdriver.FindElement(By.CssSelector("#login_button"), 10);

        public LoginPage NavigateToLoginPage()
        {
            webdriver.Navigate().GoToUrl(url);
            return this;
        }

        public LoginPage PerformLogin()
        {
            userNameField.SendKeys(loginData);
            passwordField.SendKeys(loginData);
            loginButton.Click();

            return this;
        }
    }
}
