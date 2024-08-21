namespace LicUiTests.Helpers
{
    public class Browser
    {
        public static void NavigateTo(string url)
        {
            WebDriver.Driver.Navigate().GoToUrl(url);
        }
        public static void MaximizeWindow()
        {
            WebDriver.Driver.Manage().Window.Maximize();
        }
    }
}
