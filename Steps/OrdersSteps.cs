using FluentAssertions;
using LicUiTests.Helpers;
using LicUiTests.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using static LicUiTests.Helpers.Utils;

namespace LicUiTests.Steps
{
    [Binding]
    public class OrdersSteps
    {
        private ScenarioContext scenarioContext;

        public OrdersSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Then(@"all the orders are displayed through the table")]
        [Then(@"all my orders are displayed through the table")]
        public void ThenAllTheOrdersAreDisplayedThroughTheTable()
        {
            Sync.ExplicitWait(1);
            LicentaPages.OrdersPage.TableHead.Displayed.Should().Be(true);
        }

        [When(@"I select Detalii button for the order (.*) from the table")]
        public void WhenISelectDetaliiButtonForTheOrderFromTheTable(string orderNumber)
        {
            Sync.ExplicitWait(1);
            LicentaPages.OrdersPage.OrderNoFilter.Click();
            Sync.ExplicitWait(1);
            LicentaPages.OrdersPage.OrderNoFilterInput.Click();
            LicentaPages.OrdersPage.OrderNoFilterInput.SendKeys(orderNumber);
            Sync.ExplicitWait(1);
            LicentaPages.OrdersPage.OrderNoFilterInput.SendKeys(Keys.Escape);
            Sync.ExplicitWait(1);
            LicentaPages.OrdersPage.OrderDetailsButton.Click();
        }

        [Then(@"every product from the order is displayed")]
        public void ThenEveryProductFromTheOrderIsDisplayed()
        {
            Sync.ExplicitWait(1);
            LicentaPages.OrdersPage.OrderDetailsTableHead.Displayed.Should().Be(true);
        }

        [When(@"I select (.*) from workpoints dropdown on Create manual order modal")]
        public void WhenISelectFromWorkpointsDropdownOnCreateManualOrderModal(string workpoint)
        {
            Sync.ExplicitWait(1);
            LicentaPages.OrdersPage.WorkpointsDropdownManualOrder.Click();
            Sync.ExplicitWait(1);
            LicentaPages.OrdersPage.GetWorkpointForManualOrder(workpoint).Click();
        }

        [When(@"I select the following list of products for the new order with a (.*) of (.*) RON")]
        public void WhenISelectTheFollowingListOfProductsForTheNewOrder(string totalPriceKey, decimal total, Table manualOrderProductsTable)
        {
            var dictionary = TableExtensions.ToDictionary(manualOrderProductsTable);
            Sync.ExplicitWait(1);

            int q1 = int.Parse(dictionary["Product Demo 1"]);
            int q2 = int.Parse(dictionary["Product Demo 2"]);
            int q3 = int.Parse(dictionary["Product Demo 3"]);

            LicentaPages.OrdersPage.FirstProductManualOrderInput.SendKeys(q1.ToString());
            LicentaPages.OrdersPage.SecondProductManualOrderInput.SendKeys(q2.ToString());
            LicentaPages.OrdersPage.ThirdProductManualOrderInput.SendKeys(q3.ToString());

            decimal firstProductPrice = decimal.Parse(LicentaPages.OrdersPage.FirstProductPrice.Text.ToString());
            decimal secondProductPrice = decimal.Parse(LicentaPages.OrdersPage.SecondProductPrice.Text.ToString());
            decimal thirdProductPrice = decimal.Parse(LicentaPages.OrdersPage.ThirdProductPrice.Text.ToString());
            decimal totalPrice = firstProductPrice * q1 + secondProductPrice * q2 + thirdProductPrice * q3;

            scenarioContext.Add(totalPriceKey, totalPrice);
        }

        [When(@"I select Creeaza comanda button on Create manual order modal")]
        public void WhenISelectButtonOnCreateManualOrderModal()
        {
            Sync.ExplicitWait(1);
            LicentaPages.OrdersPage.CreateOrderButton.Click();
        }

        [Then(@"the new order is displayed through orders table")]
        public void ThenTheNewOrderIsDisplayedThroughOrdersTable()
        {
            Sync.ExplicitWait(1);
            LicentaPages.OrdersPage.FirstOrderDateFromTable.Text.Should().Be(DateTime.Now.ToString("dd.MM.yyyy"));
        }

        [When(@"I filter the list of orders by order number: (.*)")]
        public void WhenIFilterTheListOfOrdersByOrderNumber(string orderNumber)
        {
            Sync.ExplicitWait(1);
            LicentaPages.OrdersPage.OrderNoFilter.Click();
            Sync.ExplicitWait(1);
            LicentaPages.OrdersPage.OrderNoFilterInput.Click();
            LicentaPages.OrdersPage.OrderNoFilterInput.SendKeys(orderNumber);
            LicentaPages.OrdersPage.OrderNoFilterInput.SendKeys(Keys.Escape);
        }

        [Then(@"the order (.*) is displayed")]
        public void ThenTheOrderIsDisplayed(string orderNumber)
        {
            Sync.ExplicitWait(1);
            LicentaPages.OrdersPage.GetDisplayedOrderNumber(orderNumber).Displayed.Should().Be(true);
        }

        [When(@"I filter the list of orders by status: (.*)")]
        public void WhenIFilterTheListOfOrdersByStatus(string status)
        {
            Sync.ExplicitWait(1);
            LicentaPages.OrdersPage.OrderStatusFilter.Click();
            LicentaPages.OrdersPage.GetStatusFromFilter(status).Click();
            Sync.ExplicitWait(1);
        }

        [Then(@"the all the orders displayed have status: (.*)")]
        public void ThenTheAllTheOrdersDisplayedHaveStatus(string status)
        {
            Sync.ExplicitWait(1);

            IWebElement tableElement = Helpers.WebDriver.Driver.FindElement(By.XPath("//table[contains(@class,'chakra-table ordersTable css-5605sr')]//td[4]"));
            IList<IWebElement> tableData = tableElement.FindElements(By.XPath("//table[contains(@class,'chakra-table ordersTable css-5605sr')]//td[4]"));

            foreach (IWebElement row in tableData)
            {
                row.Text.Should().Contain(status);
            }
        }

        [Then(@"the following info message is displayed on orders tab: Nu s-au gasit rezultate.")]
        public void ThenTheFollowingInfoMessageIsDisplayedOnOrdersTabNuSAuGasitRezultate()
        {
            Sync.ExplicitWait(1);
            LicentaPages.OrdersPage.NoResultsOnOrdersTable.Displayed.Should().Be(true);
        }

        [When(@"I select (.*) workpoint for my new file order")]
        public void WhenISelectWorkpointForMyNewFileOrder(string workpoint)
        {
            Sync.ExplicitWait(1);
            LicentaPages.OrdersPage.WorkpointsDropdownFileOrder.Click();
            LicentaPages.OrdersPage.GetWorkpointForFileOrder(workpoint).Click();
            LicentaPages.OrdersPage.WorkpointsDropdownFileOrder.Click();
        }

        [When(@"I upload the file (.*) for the new order")]
        public void WhenIUploadTheFileForTheNewOrder(string fileName)
        {
            UploadFile(fileName);            
        }

        [Then(@"I confirm (.*) is corecct for the selected products and quantities: (.*) RON")]
        public void ThenIConfirmTotalPriceIsCorecctForTheSelectedProductsAndQuantities(string totalPriceKey, decimal totalPrice)
        {
            Sync.ExplicitWait(1);
            decimal actualTotalPrice = scenarioContext.Get<decimal>(totalPriceKey);

            actualTotalPrice.Should().Be(totalPrice);
        }

    }
}
