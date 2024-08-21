using FluentAssertions;
using LicUiTests.Helpers;
using LicUiTests.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using static LicUiTests.Helpers.Utils;

namespace LicUiTests.Steps
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I navigate to Licenta app")]
        public void GivenINavigateToLicentaApp()
        {
            Navigation.NavigateTo(AppSettings.BaseUrl);
        }

        [Given(@"I navigate to Login page")]
        [When(@"I navigate to Login page")]
        public void GivenINavigateToLoginPage()
        {
            Sync.ExplicitWait(2);
            LicentaPages.LoginPage.ConnectButton.Click();
        }

        [When(@"I log in with the following credentials")]
        public void WhenILogInWithTheFollowingCredentials(Table credentialsTable)
        {

            var dictionary = TableExtensions.ToDictionary(credentialsTable);
            Sync.ExplicitWait(1);
            LicentaPages.LoginPage.UsernameField.SendKeys(dictionary["username"]);
            LicentaPages.LoginPage.PasswordField.SendKeys(dictionary["password"]);
            Sync.ExplicitWait(1);
            LicentaPages.LoginPage.LoginButton.Click();
            Sync.ExplicitWait(1);
        }

        [Then(@"I'm successfully logged into Licenta app with user (.*)")]
        public void ThenImSuccessfullyLoggedIntoLicentaAppWithUser(string userInitial)
        {
            Sync.FindElementWait(By.XPath($"//span/div[text()='{userInitial}']"));
            LicentaPages.LoginPage.GetUserInitial(userInitial).Displayed.Should().Be(true);
        }

        [Then(@"the following warning message is displayed: (.*)")]
        public void ThenTheFollowingWarningMessageIsDisplayed(string warningMessage)
        {
            LicentaPages.LoginPage.WarningMessage.Text.Should().Be(warningMessage);
        }

        [When(@"I choose to disconnect from Licenta app")]
        public void WhenIChooseToDisconnectFromLicentaApp()
        {
            LicentaPages.LoginPage.UserInitialButton.Click();
            Sync.ExplicitWait(1);
            LicentaPages.LoginPage.SingOutButton.Click();
            Sync.ExplicitWait(1);
            LicentaPages.LoginPage.ConfirmSignOutButton.Click();
        }

        [Then(@"I'm successfully disconnected: (.*)")]
        public void ThenImSuccessfullyDisconnected(string message)
        {
            Sync.FindElementWait(By.XPath("//button[contains(text(),'Intra in cont')]")).Displayed.Should().Be(true);
            Sync.FindElementWait(By.XPath($"//h2[contains(@class,'chakra-heading css-1shalku') and (text()='{message}')]")).Displayed.Should().Be(true);
        }
    }
}
