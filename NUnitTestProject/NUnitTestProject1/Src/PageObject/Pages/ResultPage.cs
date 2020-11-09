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
    class ResultPage
    {

        private IWebDriver driver;
        private WebDriverWait wait;

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".fusion-posts-container>article:nth-child(1)")]
        private readonly IWebElement firstArticle;

        public void clickOnFirstArticle()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".fusion-posts-container>article:nth-child(1)"))).Click();
            firstArticle.Click();
        }


    }
}