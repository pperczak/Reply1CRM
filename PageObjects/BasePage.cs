﻿using OpenQA.Selenium;

namespace Reply1CRM.PageObjects
{
    public class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
