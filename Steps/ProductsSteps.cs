using FluentAssertions;
using LicUiTests.Helpers;
using LicUiTests.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using static LicUiTests.Helpers.Utils;

namespace LicUiTests.Steps
{
    [Binding]
    public class ProductsSteps
    {
        private ScenarioContext scenarioContext;

        public ProductsSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Then(@"all the products are displayed through the table for admin")]
        [Then(@"all the products are displayed through the table for customer")]
        public void ThenAllTheProductsAreDisplayedThroughTheTableFor()
        {
            Sync.ExplicitWait(1);
            LicentaPages.ProductsPage.ProductNameTableHead.Displayed.Should().Be(true);
        }

        [When(@"I fill in the new (.*)'s details")]
        public void WhenIFillInTheNewProductsDetails(string newProductKey, Table newProductTable)
        {
            Sync.ExplicitWait(1);
            var dictionary = TableExtensions.ToDictionary(newProductTable);
            var newProduct = dictionary["Nume produs"] + "-" + Transforms.RandomString(3);
            scenarioContext.Add(newProductKey, newProduct);

            if (dictionary["Nume produs"] != string.Empty)
            {
                LicentaPages.ProductsPage.ProductNameField.SendKeys(newProduct);
            }
            Utils.ClickUsingJS(LicentaPages.ProductsPage.ProductPriceField);
            LicentaPages.ProductsPage.ProductPriceField.SendKeys(Keys.Control + "a" + Keys.Delete);
            Sync.ExplicitWait(1);
            LicentaPages.ProductsPage.ProductPriceField.SendKeys(dictionary["Pret produs"]);
            Utils.ClickUsingJS(LicentaPages.ProductsPage.AvailableStockField);
            LicentaPages.ProductsPage.AvailableStockField.SendKeys(Keys.Control + "a" + Keys.Delete);
            LicentaPages.ProductsPage.AvailableStockField.SendKeys(dictionary["Stoc disponibil"]);
        }

        [Then(@"I confirm the new (.*) is displayed through products table")]
        public void ThenIConfirmTheNewIsDisplayedThroughProductsTable(string newProductKey)
        {
            Sync.ExplicitWait(1);
            var newProduct = scenarioContext.Get<string>(newProductKey);
            Utils.ClickUsingJS(LicentaPages.ProductsPage.ProductNameFilter);
            Sync.ExplicitWait(1);
            LicentaPages.ProductsPage.ProductNameFilterField.Click();
            LicentaPages.ProductsPage.ProductNameFilterField.SendKeys(newProduct);
            Sync.ExplicitWait(1);
            Utils.ClickUsingJS(LicentaPages.ProductsPage.CloseFilterButton);
            LicentaPages.ProductsPage.GetProductFromTable(newProduct).Displayed.Should().Be(true);            
        }

        [Then(@"the following error toast message is displayed: (.*)")]
        public void ThenTheFollowingErrorToastMessageIsDisplayed(string message)
        {
            Sync.ExplicitWait(1);
            LicentaPages.ProductsPage.ToastMessage.Text.Should().Contain(message);
        }

        [When(@"I filter the list of products by name: (.*)")]
        public void WhenIFilterTheListOfProductsByName(string productName)
        {
            Sync.ExplicitWait(1);
            Utils.ClickUsingJS(LicentaPages.ProductsPage.ProductNameFilter);
            Sync.ExplicitWait(1);
            LicentaPages.ProductsPage.ProductNameFilterField.Click();
            LicentaPages.ProductsPage.ProductNameFilterField.SendKeys(productName);
            Sync.ExplicitWait(1);
            Utils.ClickUsingJS(LicentaPages.ProductsPage.CloseFilterButton);
        }

        [Then(@"I confirm the displayed product is (.*)")]
        public void ThenIConfirmTheDisplayedProductIs(string productName)
        {
            Sync.ExplicitWait(1);
            LicentaPages.ProductsPage.GetProductFromTable(productName).Displayed.Should().Be(true);
        }

        [When(@"I filter the list of products by (.*) price")]
        public void WhenIFilterTheListOfProductsByPrice(string ascDesc)
        {
            Sync.ExplicitWait(1);
            LicentaPages.ProductsPage.PriceFilterButton.Click();
            Sync.ExplicitWait(1);
            if (ascDesc == "ascending")
            {
                LicentaPages.ProductsPage.PriceAscendingFilterButton.Click();
            } else
            {
                LicentaPages.ProductsPage.PriceDescendingFilterButton.Click();
            }
        }

        [Then(@"I confirm the first product's price is (.*)")]
        public void ThenIConfirmTheFirstProductsPriceIs(string price)
        {
            Sync.ExplicitWait(1);
            LicentaPages.ProductsPage.FirstProductPriceFromTable.Text.Should().Be(price);
        }

        [Then(@"the stock for the selected product is displayed")]
        public void ThenTheStockForTheSelectedProductIsDisplayed()
        {
            Sync.ExplicitWait(1);
            LicentaPages.ProductsPage.ViewStockDetails.Displayed.Should().Be(true);
        }

    }
}
