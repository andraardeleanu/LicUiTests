using System.Configuration;

namespace LicUiTests.Helpers
{
    public class AppSettings
    {
        private static Configuration _configuration => ConfigurationManager.OpenExeConfiguration(@"LicUITests.dll");
        public static string LicUiTestsConnectionString => AesEncryptionService.Decrypt(_configuration.AppSettings.Settings["ConnectionString"].Value);
        public static string DownloadPath => _configuration.AppSettings.Settings["DownloadPath"] != null ? _configuration.AppSettings.Settings["DownloadPath"].Value : null;
        public static string BaseUrl => _configuration.AppSettings.Settings["BaseUrl"].Value;
        public static string BrowserType => _configuration.AppSettings.Settings["BrowserType"].Value;
        public static string Username => AesEncryptionService.Decrypt(_configuration.AppSettings.Settings["Username"].Value);
        public static string Password => AesEncryptionService.Decrypt(_configuration.AppSettings.Settings["Password"].Value);
        public static double WaitMultiplier => double.Parse(_configuration.AppSettings.Settings["WaitMultiplier"].Value);
    }
}
