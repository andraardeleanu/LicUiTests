using FluentAssertions;
using LicUiTests.Helpers;
using LicUiTests.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using static LicUiTests.Helpers.Utils;

namespace LicUiTests.Steps
{
    [Binding]
    public class CompanySteps

    {
        private ScenarioContext scenarioContext;

        public CompanySteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [When(@"I select '(.*)' button from Companii tab")]
        public void WhenISelectButtonFromCompaniiTab(string button)
        {
            Sync.FindElementWait(By.XPath("//button[contains(@class,'chakra-button css-jut409') and (text()='Adauga companie')]"));

            switch (button)
            {
                case "Adauga companie":
                    LicentaPages.CompanyPage.CreateNewCompanyButton.Click();
                    break;
                case "Modifica companie":
                    LicentaPages.CompanyPage.UpdateFirstCompany.Click();
                    break;
            }
            Sync.ExplicitWait(1);
        }

        [When(@"I fill in (.*)'s new details with a new (.*)")]
        public void WhenIFillInCompanysNewDetails(string newCompanyKey, string cuiKey, Table newCompanyTable)
        {
            var dictionary = TableExtensions.ToDictionary(newCompanyTable);
            var newCompany = dictionary["Name"] + "-" + Transforms.RandomString(3);
            var newCui = Transforms.RandomString(7);

            LicentaPages.CompanyPage.NewCompanyNameField.Click();
            LicentaPages.CompanyPage.NewCompanyNameField.SendKeys(newCompany);
            LicentaPages.CompanyPage.NewCompanyCuiField.SendKeys(newCui);
            scenarioContext.Add(cuiKey, newCui);
            scenarioContext.Add(newCompanyKey, newCompany);
        }

        [Then(@"the company's workpoint (.*) is displayed through table: (.*)")]
        public void ThenTheCompanysWorkpointAreDisplayedThroughTable(string companyWrokpointName, string companyName)
        {
            Sync.ExplicitWait(1);
            LicentaPages.CompanyPage.GetCompanyName(companyName).Displayed.Should().Be(true);
            LicentaPages.CompanyPage.GetCompanyWorkpointName(companyWrokpointName).Displayed.Should().Be(true);
        }

        [Then(@"the new (.*) is displayed through Companies page")]
        public void ThenTheNewCompanyIsDisplayedThroughCompaniesPage(string newCompanyKey)
        {
            Sync.ExplicitWait(1);
            var newCompanyName = scenarioContext.Get<string>(newCompanyKey);
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Helpers.WebDriver.Driver;
            executor.ExecuteScript("window.scrollBy(0,1500)");
            Sync.ExplicitWait(2);
            LicentaPages.CompanyPage.GetNewCompanyName(newCompanyName).Displayed.Should().Be(true);
        }

        [When(@"I fill in the Company Name field: (.*)")]
        public void WhenIFillInTheCompanyNameField(string newCompanyName)
        {
            Sync.ExplicitWait(1);
            LicentaPages.CompanyPage.NewCompanyNameField.SendKeys(newCompanyName);
        }

        [When(@"I fill in the Company CUI field: (.*)")]
        public void WhenIFillInTheCUIField(string newCompanyCUI)
        {
            Sync.ExplicitWait(1);
            LicentaPages.CompanyPage.NewCompanyCuiField.SendKeys(newCompanyCUI);
        }

        [When(@"I set the new Company Name: (.*)")]
        public void WhenISetTheNewCompanyName(string newCompanyName)
        {
            Sync.ExplicitWait(1);
            LicentaPages.CompanyPage.NewCompanyNameField.SendKeys(newCompanyName);
        }

        [When(@"I select the (.*) option button from the (.*)")]
        public void WhenISelectTheOptionsButtonFromTheSearchedCompany(string option, string selectedCompany)
        {
            Sync.ExplicitWait(1);
            LicentaPages.CompanyPage.CompanyNameFilter.SendKeys(selectedCompany);
            Sync.ExplicitWait(1);
            if(option == "workpoint")
            {
                LicentaPages.CommonPage.RemoveWorkpointButton.Click();
            } else
            {
                LicentaPages.CommonPage.UpdateOptionButton.Click();
            }            
        }

        [When(@"I search for (.*) on Companies tab content")]
        public void WhenISearchForOnCompaniesTabContent(string searchedCompany)
        {
            LicentaPages.CompanyPage.CompanyNameFilter.SendKeys(searchedCompany);
            Sync.ExplicitWait(1);
        }
    }
}
