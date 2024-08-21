using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using BoDi;
using OpenQA.Selenium;
using System.Xml.Linq;
using TechTalk.SpecFlow;

namespace LicUiTests.Helpers
{
    [Binding]
    public class Hooks
    {
        public readonly ScenarioContext _scenarioContext;
        public readonly IObjectContainer _objectContainer;

        public Hooks(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _objectContainer = objectContainer;
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void MaximizeWindow()
        {
            Browser.MaximizeWindow();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            WebDriver.Quit();
        }

        [AfterScenario("CompanyCleanUp")]
        public void CompanyCleanUp()
        {
            string cui = _scenarioContext.Get<string>("CUI");
            DbAccess.CompanyCleanUp(cui);
        }

        [AfterScenario("ResetCompanyName")]
        public void ResetCompanyName()
        {
            string name = _scenarioContext.Get<string>("Name");
            DbAccess.ResetCompanyName(name);
        }

        [AfterScenario("WorkpointCleanUp")]
        public void WorkpointCleanUp()
        {
            string name = _scenarioContext.Get<string>("workpoint");
            DbAccess.WorkpointCleanUp(name);
        }

        [AfterScenario("ResetWorkpointData")]
        public void ResetWorkpointData()
        {
            string name = _scenarioContext.Get<string>("Name");
            DbAccess.ResetWorkpointData(name);
        }

        [AfterScenario("ProductCleanUp")]
        public void ProductCleanUp()
        {
            string name = _scenarioContext.Get<string>("Name");
            DbAccess.ProductCleanUp(name);
        }

        [AfterScenario("ResetProductName")]
        public void ResetProductName()
        {
            string name = _scenarioContext.Get<string>("Name");
            DbAccess.ResetProductName(name);
        }

        [AfterScenario("OrderCleanUp")]
        public void OrderCleanUp()
        {
            string orderNo = _scenarioContext.Get<string>("OrderNo");
            DbAccess.OrderCleanUp(orderNo);
        }

        [AfterScenario("OrderProductsReset")]
        public void OrderProductsReset()
        {
            string productId = _scenarioContext.Get<string>("productId");
            DbAccess.OrderProductsReset(productId);
        }

        [AfterScenario("BillCleanUp")]
        public void BillCleanUp()
        {
            string OrderNo = _scenarioContext.Get<string>("OrderNo");
            DbAccess.BillCleanUp(OrderNo);
        }

        [AfterScenario("StockReset")]
        public void StockReset()
        {
            string Name = _scenarioContext.Get<string>("product");
            DbAccess.StockReset(Name);
        }

        [AfterScenario("UserCleanUp")]
        public void UserCleanUp()
        {
            string username = _scenarioContext.Get<string>("customer");
            DbAccess.UserCleanUp(username);
        }

        [AfterScenario("ResetFirstname")]
        public void ResetFirstname()
        {
            string firstname = _scenarioContext.Get<string>("firstname");
            DbAccess.ResetFirstname(firstname);
        }
    }
}
