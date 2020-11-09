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
    class HomePage
    {

        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".fusion-main-menu a[href*='about']")]
        private readonly IWebElement about;

        [FindsBy(How = How.ClassName, Using = "fusion-main-menu-icon")]
        private readonly IWebElement searchIcon;

        public void goToPage()
        {
            driver.Navigate().GoToUrl("http://www.swtestacademy.com");
        }

        public AboutPage goToAboutPage()
        {
            searchIcon.Click();
            return new AboutPage(driver);
        }                         

    }
}