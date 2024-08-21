using FluentAssertions;
using LicUiTests.Helpers;
using LicUiTests.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static LicUiTests.Helpers.Utils;

namespace LicUiTests.Steps
{
    [Binding]
    public class UsersSteps
    {
        private ScenarioContext scenarioContext;

        public UsersSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [When(@"I select '(.*)' button from Clienti tab")]
        public void WhenISelectButtonFromClientiTab(string button)
        {
            Sync.ExplicitWait(1);
            LicentaPages.UsersPage.AddNewUserButton.Click();
            Sync.FindElementWait(By.XPath("//button[contains(@class,'chakra-button css-jut409') and (text()='Adauga client')]"));
        }

        [When(@"I select '(.*)' button from Register modal")]
        public void WhenISelectButtonFromRegisterModal(string button)
        {
            Sync.ExplicitWait(1);
            LicentaPages.UsersPage.AddUserButton.Click();
        }

        [Then(@"the new (.*) is displayed through Customers page")]
        public void ThenTheNewUsernameIsDisplayedThroughCustomersPage(string key)
        {
            Sync.ExplicitWait(1);
            var newCustomerUsername = scenarioContext.Get<string>(key);
            Sync.ExplicitWait(2);
            LicentaPages.UsersPage.GetNewUsername(newCustomerUsername).Displayed.Should().Be(true);
        }

        [When(@"I register the (.*) with the following details")]
        public void WhenIRegisterTheCustomerWithTheFollowingDetails(string key, Table newCustomerTable)
        {
            var dictionary = TableExtensions.ToDictionary(newCustomerTable);

            LicentaPages.UsersPage.FirstnameField.SendKeys(dictionary["Prenume"]);
            LicentaPages.UsersPage.LastnameField.SendKeys(dictionary["Nume"]);
            LicentaPages.UsersPage.UsernameField.SendKeys(dictionary["Username"]);
            LicentaPages.UsersPage.PasswordField.SendKeys(dictionary["Parola"]);
            LicentaPages.UsersPage.EmailField.SendKeys(dictionary["Email"]);

            LicentaPages.UsersPage.CompanyDropdown.Click();
            LicentaPages.UsersPage.GetCompanyFromDropdown(dictionary["Companie"]).Click();
            scenarioContext.Add(key, dictionary["Username"]);
        }

        [When(@"I select '(.*)' button from Clienti tab for the (.*) username")]
        public void WhenISelectButtonFromClientiTabForTheCustomerUItestUsername(string action, string username)
        {
            Sync.FindElementWait(By.XPath("//input[contains(@class,'chakra-input css-c51tnq')]"));
            LicentaPages.UsersPage.CustomerSearchBar.SendKeys(username);
            LicentaPages.UsersPage.GetNewUsername(username).Displayed.Should().Be(true);
            LicentaPages.UsersPage.UpdateCustomerButton.Click();
            Sync.ExplicitWait(1);
        }

        [When(@"I update the following data for the customer selected")]
        public void WhenIUpdateTheFollowingDataForTheCustomerSelected(Table updateCustomerTable)
        {
            var dictionary = TableExtensions.ToDictionary(updateCustomerTable);

            LicentaPages.UsersPage.FirstnameUpdateField.Click();
            LicentaPages.UsersPage.FirstnameUpdateField.Clear();
            LicentaPages.UsersPage.FirstnameUpdateField.SendKeys(dictionary["Prenume"]);
        }

        [Then(@"I select Actualizeaza button on customer update modal")]
        public void ThenISelectButtonOnCustomerUpdateModal()
        {
            LicentaPages.StockPage.UpdateNewAvailableStockButton.Click();
        }

        [When(@"I navigate to user's profile")]
        public void WhenINavigateToUsersProfile()
        {
            Sync.ExplicitWait(1);
            LicentaPages.UsersPage.UserSettingsButton.Click();
            Sync.ExplicitWait(1);
            LicentaPages.UsersPage.UserProfileButton.Click();
            Sync.FindElementWait(By.XPath("//button[contains(@class,'chakra-button css-jut409') and (text()='Schimba parola')]"));
        }

        [When(@"I update user's password")]
        public void WhenIUpdateUsersPassword(Table updatePasswordtable)
        {
            var dictionary = TableExtensions.ToDictionary(updatePasswordtable);

            LicentaPages.UsersPage.OldPasswordField.SendKeys(dictionary["Old password"]);
            LicentaPages.UsersPage.NewPasswordField.SendKeys(dictionary["New password"]);
            LicentaPages.UsersPage.ChangePasswordButton.Click();
        }

    }
}
