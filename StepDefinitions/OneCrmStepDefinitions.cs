using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reply1CRM.PageObjects;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace Reply1CRM.StepDefinitions
{
    [Binding]
    public sealed class OneCrmStepDefinitions : IDisposable
    {
        private IWebDriver _webDriver;
        private readonly LoginPage _loginPage;

        public OneCrmStepDefinitions(/*IWebDriver webdriver*/)
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
            _loginPage = new LoginPage(_webDriver);
        }

        [Given(@"I am logged into OneCrm Page")]
        public void GivenIAmLoggedIntoOneCrmPage()
        {
            _loginPage
                .NavigateToLoginPage()
                .PerformLogin();

            Thread.Sleep(7000);
        }


        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            throw new PendingStepException();
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