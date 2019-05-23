using CSharpSeleniumTestExampleWithSpecFlow.Actions;
using CSharpSeleniumTestExampleWithSpecFlow.Pages;
using CSharpSeleniumTestExampleWithSpecFlow.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace CSharpSeleniumTestExampleWithSpecFlow
{
    [Binding]
    public class BuyingAMacBookProOnTheWebsiteSteps
    {
        private IWebDriver driver;
        private Enter enter;
        private Click click;

        [BeforeScenario("choose")]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            enter = new Enter(driver);
            click = new Click(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Given(@"the url ‘https://www\.apple\.com/uk/’")]
        public void GivenTheUrlHttpsWww_Apple_ComUk()
        {
            //An improvment here would be to refactor and place the URL in a helper folder as an example
            driver.Navigate().GoToUrl("https://www.apple.com/uk/");
            Assert.AreEqual("Apple (United Kingdom)", driver.Title);
        }

        [Given(@"I go to the url")]
        public void GivenIGoToTheUrl()
        {
            click.On(HomePage.MAC);
            Assert.AreEqual("Mac - Apple (UK)", driver.Title);
            //An improvment here would be to refactor this using the table
            click.On(MacPage.MAC_BOOK_PRO);
            click.On(MacbookProPage.BUY);
            click.On(MacbookProBuyPage.FIFTEEN_INCH);
            click.On(MacbookProBuyPage.SILVER);
            click.On(MacbookProBuyPage.SELECT);
            //TO DO
            //click.On(MacbookProBuyPage.LOGIC_PRO);
            click.On(MacbookProBuyPage.ADD_TO_BAG);
            click.On(MacbookProBuyPage.ADD_USB_C);
            click.On(MacbookProBuyPage.REVIEW_BAG);

        }
        
        [Given(@"when I choose the following items:")]
        public void GivenWhenIChooseTheFollowingItems(Table table)
        {
            //TO DO
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I choose a MacBook Pro with the following features and accessories")]
        public void WhenIChooseAMacBookProWithTheFollowingFeaturesAndAccessories(Table table)
        {
            //TO DO
            //var credentials = table.CreateInstance<MacbookPro>();
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I proceed to the checkout")]
        public void WhenIProceedToTheCheckout()
        {
            //TO DO
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can place an order for it\.")]
        public void ThenICanPlaceAnOrderForIt_()
        {
            //TO DO
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a total price of £(.*) will be displayed")]
        public void ThenATotalPriceOfWillBeDisplayed(Decimal p0)
        {
            //TO DO
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"£(.*) will be listed for VAT\.VAT")]
        public void ThenWillBeListedForVAT_VAT(Decimal p0)
        {
            //TO DO
            ScenarioContext.Current.Pending();
        }
    }
}
