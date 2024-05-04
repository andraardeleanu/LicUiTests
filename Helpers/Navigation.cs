namespace LicUiTests.Helpers
{
    public class Navigation
    {
        public static void NavigateTo(string pageName)
        {
            Browser.NavigateTo(AppSettings.BaseUrl);
        }
    }
}
