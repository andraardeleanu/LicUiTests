using FluentAssertions;
using LicUiTests.Helpers;
using LicUiTests.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using static LicUiTests.Helpers.Utils;

namespace LicUiTests.Steps
{
    [Binding]
    public class WorkPointSteps
    {
        private ScenarioContext scenarioContext;

        public WorkPointSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [When(@"I select '(.*)' button from Puncte de lucru tab")]
        public void WhenISelectButtonFromPuncteDeLucruTab(string button)
        {
            Sync.ExplicitWait(1);
            LicentaPages.WorkPointPage.CreateNewWorkPointButton.Click();
        }

        [When(@"I fill in (.*)'s new details")]
        public void WhenIFillInWorkpointsNewDetails(string newWorkpointKey, Table newWorkPointTable)
        {
            var dictionary = TableExtensions.ToDictionary(newWorkPointTable);
            var newWorkpoint = dictionary["Name"] + Transforms.RandomString(3);
           
            LicentaPages.WorkPointPage.NewWorkPointNameField.SendKeys(newWorkpoint);
            LicentaPages.WorkPointPage.NewWorkPointAddressField.SendKeys(dictionary["Address"]);
            scenarioContext.Add(newWorkpointKey, newWorkpoint);
        }

        [Then(@"the new (.*) is displayed through Workpoints page")]
        public void ThenTheNewIsDisplayedThroughWorkpointsPage(string newWorkpointKey)
        {
            Sync.ExplicitWait(1);
            var newWorkpointName = scenarioContext.Get<string>(newWorkpointKey);
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Helpers.WebDriver.Driver;
            executor.ExecuteScript("window.scrollBy(0,1500)");
            Sync.ExplicitWait(2);
            LicentaPages.WorkPointPage.GetNewWorkpointName(newWorkpointName).Displayed.Should().Be(true);
        }

        [When(@"I search for (.*) on Workpoints tab content")]
        public void WhenISearchFOnWorkpointsTabContent(string searchedWorkpoint)
        {
            LicentaPages.WorkPointPage.WorkpointNameFilter.SendKeys(searchedWorkpoint);
            Sync.ExplicitWait(1);
        }

        [When(@"I search for (.*) on Wokrpoint tab content")]
        public void WhenISearchForOnWokrpointTabContent(string searchedWorkpoint)
        {
            Sync.ExplicitWait(1);
            LicentaPages.WorkPointPage.WorkpointNameFilter.SendKeys(searchedWorkpoint);
            Sync.ExplicitWait(1);
        }

        [When(@"I select (.*) button for the newly added (.*)")]
        public void WhenISelectButtonFor(string button, string newWorkpointKey)
        {
            Sync.ExplicitWait(1);
            string workpointName = scenarioContext.Get<string>(newWorkpointKey);
            LicentaPages.WorkPointPage.WorkpointNameFilter.SendKeys(workpointName);
            
            Sync.ExplicitWait(1);
            if (button == "Modifica punct de lucru")
            {
                LicentaPages.CommonPage.UpdateOptionButton.Click();
            } else
            {
                LicentaPages.CommonPage.RemoveWorkpointButton.Click();
            }
            Sync.ExplicitWait(1);
        }

        [When(@"I set the new values of the (.*)")]
        public void WhenISetTheNewValuesOfTheWorkpoint(string updatedWorkpointKey, Table newWorkpointDetails)
        {
            var dictionary = TableExtensions.ToDictionary(newWorkpointDetails);
            var newWorkpoint = dictionary["Name"] + Transforms.RandomString(3);

            LicentaPages.WorkPointPage.NewWorkPointNameField.Clear();
            LicentaPages.WorkPointPage.NewWorkPointNameField.SendKeys(newWorkpoint);
            LicentaPages.WorkPointPage.NewWorkPointAddressField.Clear();
            LicentaPages.WorkPointPage.NewWorkPointAddressField.SendKeys(dictionary["Address"]);

            scenarioContext.Add(updatedWorkpointKey, newWorkpoint);
        }

        [Then(@"the updated details are displayed in the (.*) box")]
        public void ThenTheUpdatedDetailsAreDisplayedInTheBox(string updatedWorkpointKey)
        {
            Sync.ExplicitWait(1);
            string workpointName = scenarioContext.Get<string>(updatedWorkpointKey);
            LicentaPages.WorkPointPage.WorkpointNameFilter.Clear();
            LicentaPages.WorkPointPage.WorkpointNameFilter.SendKeys(workpointName);
            Sync.ExplicitWait(1);
            LicentaPages.CommonPage.CompanyWorkpointBoxName.Text.Should().Be(workpointName);
        }

        [When(@"I fill in the Workpoint Name field: (.*)")]
        public void WhenIFillInTheWorkpointNameField(string existingWorkpointName)
        {
            LicentaPages.WorkPointPage.NewWorkPointNameField.SendKeys(existingWorkpointName);
        }

        [When(@"I fill in the Workpoint Address field: (.*)")]
        public void WhenIFillInTheWorkpointAddressField(string workpointAddress)
        {
            LicentaPages.WorkPointPage.NewWorkPointAddressField.SendKeys(workpointAddress);
        }

        [When(@"I confirm the workpoint removal pop-up message")]
        public void WhenIConfirmThePopUpMessage()
        {
            Sync.ExplicitWait(1);
            LicentaPages.WorkPointPage.ConfirmWorkpointDeleteButton.Click();
        }

        [Then(@"it's confirmed the (.*) has been deleted: (.*)")]
        public void ThenItsConfirmedTheWorkpointHasBeenDeleted(string workpointKey, string infoMessage)
        {
            Sync.ExplicitWait(1);
            string workpointName = scenarioContext.Get<string>(workpointKey);
            LicentaPages.WorkPointPage.WorkpointNameFilter.Clear();
            LicentaPages.WorkPointPage.WorkpointNameFilter.SendKeys(workpointName);
            Sync.ExplicitWait(1);
            LicentaPages.CommonPage.TabInfoMeesage.Text.Should().Be(infoMessage);
        }

        [When(@"I cancel the workpoint removal pop-up message")]
        public void WhenICancelTheWorkpointRemovalPop_UpMessage()
        {
            Sync.ExplicitWait(1);
            LicentaPages.WorkPointPage.CancelWorkpointDeleteButton.Click();
        }

        [Then(@"it's confirmed the (.*) has not been deleted")]
        public void ThenItsConfirmedTheWorkpointHasNotBeenDeleted(string workpointKey)
        {
            Sync.ExplicitWait(1);
            string workpointName = scenarioContext.Get<string>(workpointKey);
            LicentaPages.WorkPointPage.WorkpointNameFilter.Clear();
            LicentaPages.WorkPointPage.WorkpointNameFilter.SendKeys(workpointName);
            Sync.ExplicitWait(1);
            LicentaPages.CommonPage.CompanyWorkpointBoxName.Text.Should().Be(workpointName);
        }

    }
}
