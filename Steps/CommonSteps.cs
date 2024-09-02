using FluentAssertions;
using LicUiTests.Helpers;
using LicUiTests.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace LicUiTests.Steps
{
    [Binding]
    public class CommonSteps
    {

        [Then(@"the following toast message is displayed: (.*)")]
        public void ThenTheFollowingToastMessageIsDisplayed(string toastMessage)
        {
            Sync.FindElementWait(By.CssSelector(".chakra-alert__title.css-tidvy5"));
            LicentaPages.CommonPage.ToastMessage.Text.Should().Be(toastMessage);
            Sync.ExplicitWait(1);
        }

        [When(@"I select (.*) button from '(.*)' page")]
        [When(@"I select (.*) button from '(.*)' tab")]
        public void WhenISelectButtonFromPage(string button, string tab)
        {
            Sync.ExplicitWait(1);
            switch (button)
            {
                case "Adauga":
                    LicentaPages.CompanyPage.AddNewCompanyButton.Click();
                    break;
                case "Adauga produs":
                    LicentaPages.ProductsPage.AddProductButton.Click();
                    break;
                case "Actualizeaza":
                    LicentaPages.CompanyPage.UpdateButton.Click();
                    break;
                case "Creeaza comanda manual":
                    LicentaPages.OrdersPage.CreateManualOrderButton.Click();
                    break;
                case "Creeaza comanda automat":
                    LicentaPages.OrdersPage.CreateFileOrderButton.Click();
                    break;
                case "Vezi stoc":
                    LicentaPages.ProductsPage.ViewStockButton.Click();
                    break;
                case "Actualizeaza stoc":
                    LicentaPages.StockPage.UpdateStockButton.Click();
                    break;
                case "Modifica status":
                    LicentaPages.OrdersPage.UpdateFirstOrderStatus.Click();
                    break;
                case "Genereaza si descarca factura":
                    LicentaPages.OrdersPage.GenerateOrderBillButton.Click();
                    break;
            }
        }

        [When(@"I navigate to '(.*)' tab")]
        [Then(@"I navigate to '(.*)' tab")]
        public void WhenINavigateToTab(string tab)
        {
            Sync.ExplicitWait(1);
            LicentaPages.CommonPage.GetTab(tab).Click();
        }

        [Then(@"the button (.*) is available for the admin")]
        [Then(@"the button (.*) is avaialble for the customer")]
        public void ThenTheButtonIsAvailableForTheAdmin(string buttonName)
        {
            Sync.ExplicitWait(1);
            switch (buttonName)
            {
                case "Adauga produs":
                    LicentaPages.ProductsPage.AddProductButton.Displayed.Should().Be(true);
                    break;
                case "Creeaza comanda manual":
                    LicentaPages.OrdersPage.CreateManualOrderButton.Displayed.Should().Be(true);
                    break;
            }
        }

        [Then(@"the button (.*) is not avaialble for the customer")]
        [Then(@"the button (.*) is not avaialble for the admin")]
        public void ThenTheButtonIsNotAvaialbleForTheCustomer(string buttonName)
        {
            switch (buttonName)
            {
                case "Adauga produs":
                    LicentaPages.ProductsPage.AddProductButton.Exists().Should().Be(false);
                    break;
                case "Creeaza comanda manual":
                    LicentaPages.OrdersPage.CreateManualOrderButton.Exists().Should().Be(false);
                    break;
            }
        }

        [Then(@"the following info message is displayed: (.*)")]
        public void ThenTheFollowingInfoMessageIsDisplayed(string infoMessage)
        {
            Sync.ExplicitWait(2);
            LicentaPages.CommonPage.GetInfoMessage(infoMessage).Displayed.Should().Be(true);
        }

        [Then(@"the following error message is displayed: (.*)")]
        public void ThenTheFollowingErrorMessageIsDisplayed(string errorMessage)
        {
            Sync.ExplicitWait(1);
            LicentaPages.CommonPage.GetErrorMessage(errorMessage).Displayed.Should().Be(true);
        }

        [Then(@"the following tab info message is displayed: (.*)")]
        public void ThenTheFollowingTabInfoMessageIsDisplayed(string infoMessage)
        {
            Sync.ExplicitWait(1);
            LicentaPages.CommonPage.TabInfoMeesage.Text.Should().Be(infoMessage);
        }

        [Then(@"the searched company (.*) is the only one displayed")]
        [Then(@"the searched workpoint (.*) is the only one displayed")]
        public void ThenTheSearchedCompanyIsTheOnlyOneDisplayed(string searchedCompany)
        {
            LicentaPages.CommonPage.CompanyWorkpointBox.Displayed.Should().Be(true);
            LicentaPages.CommonPage.CompanyWorkpointBoxName.Text.Should().Be(searchedCompany);
        }
    }
}
