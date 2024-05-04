using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LicUiTests.Helpers
{
    public class Sync
    {
        public static T WaitFor<T>(int timeInSeconds, Func<IWebDriver, T> condition)
        {
            IWait<IWebDriver> wait = new WebDriverWait(WebDriver.Driver, TimeSpan.FromSeconds(timeInSeconds));
            return wait.Until(condition);
        }
        public static void WaitUntilPageIsCompletelyLoaded()
        {
            WaitFor(60, _ => ((IJavaScriptExecutor)WebDriver.Driver).ExecuteScript("return document.readyState").Equals("complete"));
        }
        public static void ExplicitWait(int timeInSeconds)
        {
            try
            {
                new WebDriverWait(WebDriver.Driver, TimeSpan.FromSeconds(timeInSeconds * AppSettings.WaitMultiplier)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("dummyElement")));
            }
            catch (WebDriverTimeoutException) { }
        }

        public static IWebElement FindElementWait(By by)
        {
            var wait = new WebDriverWait(WebDriver.Driver, TimeSpan.FromSeconds(35));
            wait.IgnoreExceptionTypes(typeof(WebDriverException), typeof(ElementClickInterceptedException));
            wait.Until(drv => drv.FindElement(by).Displayed ? drv.FindElement(by) : null);

            return WebDriver.Driver.FindElement(by);
        }
    }
}
