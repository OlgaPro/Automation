using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnitTestProject1.Src.PageObject.Pages;
using NUnit.Framework;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
// For supporting Page Object Model
// Obsolete - using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject1
{
    public class Tests
    {

        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void SearchTextFromAboutPage()
        {
            HomePage home = new HomePage(driver);
            home.goToPage();
            AboutPage about = home.goToAboutPage();
            ResultPage result = about.search("selenium c#");
            result.clickOnFirstArticle();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

    }
}