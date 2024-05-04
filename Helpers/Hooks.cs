using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using BoDi;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace LicUiTests.Helpers
{
    [Binding]
    public class Hooks
    {
        public readonly ScenarioContext _scenarioContext;
        public readonly IObjectContainer _objectContainer;
        private static ExtentTest _featureName;
        private static ExtentTest _scenario;
        private static ExtentReports _extent;

        private static string _reportingPath = Path.Combine(Environment.CurrentDirectory + "/TestReports");
        private static string _screenshotsPath = Path.Combine(_reportingPath + "/Screenshots");

        public Hooks(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _objectContainer = objectContainer;
            _scenarioContext = scenarioContext;
        }
        /*
        [BeforeScenario]
        public void BeforeScenario()
        {
            _scenario = _featureName.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);
            _objectContainer.RegisterInstanceAs(WebDriver.Driver);
        }*/

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
        /*
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            _featureName = _extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }*/

        [AfterFeature]
        public static void SaveReport()
        {
            _extent.Flush();
        }

        [AfterScenario("CompanyCleanUp")]
        public void CompanyCleanUp()
        {
            string cui = _scenarioContext.Get<string>("CUI");            
            DbAccess.CompanyCleanUp(cui);
        }


        [AfterScenario("WorkpointCleanUp")]
        public void WorkpointCleanUp()
        {
            string workpointName = _scenarioContext.Get<string>("workpoint");
            DbAccess.WorkpointCleanUp(workpointName);
        }

        [AfterScenario("ProductCleanUp")]
        public void ProductCleanUp()
        {
            string productName = _scenarioContext.Get<string>("product");
            DbAccess.ProductCleanUp(productName);
        }

        [AfterScenario("StockReset")]
        public void StockReset()
        {
            string productName = _scenarioContext.Get<string>("product");
            DbAccess.StockReset(productName);
        }

        [AfterScenario("UpdatedWorkpointCleanUp")]
        public void UpdatedWorkpointCleanUp()
        {
            string workpointName = _scenarioContext.Get<string>("updatedWorkpoint");
            DbAccess.WorkpointCleanUp(workpointName);
        }
        /*
        [AfterStep]
        public void InsertReportingSteps()
        {
            var stepType = _scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();

            if (_scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                    _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "When")
                    _scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "Then")
                    _scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "And")
                    _scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text);
            }
            else if (_scenarioContext.TestError != null)
            {
                if (stepType == "Given")
                {
                    _scenario
                        .CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text)
                        .Fail(_scenarioContext.TestError.Message)
                        .AddScreenCaptureFromPath(TakeScreenshot());
                }
                else if (stepType == "When")
                    _scenario
                        .CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text)
                        .Fail(_scenarioContext.TestError.Message)
                        .AddScreenCaptureFromPath(TakeScreenshot());
                else if (stepType == "Then")
                {
                    _scenario
                        .CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text)
                        .Fail(_scenarioContext.TestError.Message)
                        .AddScreenCaptureFromPath(TakeScreenshot());
                }
            }
        }
        public string TakeScreenshot()
        {
            var title = _scenarioContext.ScenarioInfo.Title;
            var fileName = $@"{_screenshotsPath}\{title + " - " + DateTime.Now.ToString("dd-MMM-yyyy hh.mm.ss")}.png";
            Screenshot file = ((ITakesScreenshot)WebDriver.Driver).GetScreenshot();
            file.SaveAsFile(fileName, ScreenshotImageFormat.Png);
            return fileName;
        }*/
    }
}
