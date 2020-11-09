using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
// For supporting Page Object Model
// Obsolete - using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace NUnitTestProject1.Src.PageObject.Pages
{
    class AboutPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public AboutPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "fusion-main-menu-icon")]
        private readonly IWebElement searchIcon;

        [FindsBy(How = How.CssSelector, Using = "#menu-main > li.fusion-custom-menu-item.fusion-main-menu-search.fusion-main-menu-search-open > div > form > div > div.fusion-search-field.search-field > label > input")]
        private readonly IWebElement searchText;

        public ResultPage search(string text)
        {
           // wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("fusion-main-menu-icon"))).Click();
            searchText.SendKeys(text);
            return new ResultPage(driver);
        }


    }
}