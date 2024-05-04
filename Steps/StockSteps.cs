using FluentAssertions;
using LicUiTests.Helpers;
using LicUiTests.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TechTalk.SpecFlow;

namespace LicUiTests.Steps
{
    [Binding]
    public class StockSteps
    {
        private ScenarioContext scenarioContext;

        public StockSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Then(@"stock table is displayed")]
        public void ThenStockTableIsDisplayed()
        {
            Sync.ExplicitWait(1);
            LicentaPages.StockPage.StockTableHead.Displayed.Should().Be(true);
        }

        [When(@"I filter stock by (.*) product")]
        public void WhenIFilterStockByProduct(string stockProduct)
        {
            Sync.ExplicitWait(1);
            LicentaPages.StockPage.StockTableFilter.Click();
            LicentaPages.StockPage.StockTableFilterInput.Click();
            LicentaPages.StockPage.StockTableFilterInput.SendKeys(stockProduct);
            LicentaPages.StockPage.StockTableFilterInput.SendKeys(Keys.Escape);
        }

        [Then(@"I confirm the current available stock is displayed in modal's header: (.*) buc.")]
        public void ThenIConfirmTheCurrentAvailableStockIsDisplayedInModalsHeaderBuc(string availableStock)
        {
            Sync.ExplicitWait(1);
            LicentaPages.StockPage.GetAvailableStockForProduct(availableStock).Displayed.Should().Be(true);
        }

        [When(@"I update the new available stock to (.*) buc.")]
        public void WhenIUpdateTheNewAvailableStockToBuc(string newAvailableStock)
        {
            LicentaPages.StockPage.NewAvailableStockInput.Clear();
            LicentaPages.StockPage.NewAvailableStockInput.SendKeys(newAvailableStock);
            LicentaPages.StockPage.UpdateNewAvailableStockButton.Click();
        }

        [Then(@"I can confirm the new stock has been saved for (.*) - (.*): (.*) buc.")]
        public void ThenICanConfirmTheNewStockHasBeenSavedForProduct(string productNameKey, string stockProduct, string newAvailableStock)
        {
            Sync.ExplicitWait(1);
            scenarioContext.Add(productNameKey, stockProduct);
            LicentaPages.StockPage.StockTableFilter.Click();
            Sync.ExplicitWait(1);
            LicentaPages.StockPage.StockTableFilterInput.Click();
            LicentaPages.StockPage.StockTableFilterInput.SendKeys(stockProduct);
            LicentaPages.StockPage.StockTableFilterInput.SendKeys(Keys.Escape);
            Sync.ExplicitWait(1);
            LicentaPages.StockPage.UpdateStockButton.Click();
            Sync.ExplicitWait(1);
            LicentaPages.StockPage.GetAvailableStockForProduct(newAvailableStock).Displayed.Should().Be(true);
        }

    }
}
