using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reply1CRM.PageObjects;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Reply1CRM.StepDefinitions
{
    [Binding]
    public sealed class OneCrmStepDefinitions : IDisposable
    {
        private IWebDriver _webDriver;
        private readonly LoginPage _loginPage;
        private readonly CrmMainPageMenuNavPage _crmMainPageMenuTabPage;
        private readonly CrmMainPageMenuSubNavPage _crmMainPageMenuSubNavPage;
        private readonly ContactsPage _contactsPage;

        public OneCrmStepDefinitions(/*IWebDriver webdriver*/)
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();

            _loginPage = new(_webDriver);
            _crmMainPageMenuTabPage = new(_webDriver);
            _crmMainPageMenuSubNavPage = new(_webDriver);
            _contactsPage = new(_webDriver);
        }

        [Given(@"I am logged into OneCrm Page")]
        public void GivenIAmLoggedIntoOneCrmPage()
        {
             _loginPage
                .NavigateToLoginPage()
                .PerformLogin()
                .EnsureUserIsLoggedIn();
        }

        [When(@"I choose The Tab '([^']*)'")]
        public void WhenIChooseTheTab(string tabName)
        {
            _crmMainPageMenuTabPage.ChooseSalesNMarketingTab(tabName);
        }

        [When(@"I choose The Sub Nav '([^']*)'")]
        public void WhenIChooseTheSubNav(string subNav)
        {
            _crmMainPageMenuSubNavPage.ChooseSubNav(subNav);
        }

        [When(@"I choose to create a new '([^']*)'")]
        public void WhenIChooseToCreateANew(string contact)
        {
            _contactsPage.ClickCreateNewContactButton();
            Thread.Sleep(9000);
        }



        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            throw new PendingStepException();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            throw new PendingStepException();
        }

        public void Dispose()
        {
            this._webDriver.Dispose();
            this._webDriver = null;
        }
    }
}