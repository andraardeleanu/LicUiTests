using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Diagnostics;

namespace LicUiTests.Helpers
{
    public class WebDriver
    {
        public static IWebDriver _webDriver;
        public static IWebDriver Driver
        {
            get
            {
                if (_webDriver == null)
                {
                    _webDriver = GetWebDriver();
                }

                return _webDriver;
            }
        }

        public static void Quit()
        {
            _webDriver?.Close();
            _webDriver?.Quit();

            Process[] edgeDriverProcesses = Process.GetProcessesByName("edgedriver");

            foreach (var edgeDriverProcess in edgeDriverProcesses)
            {
                edgeDriverProcess.Kill();
            }

            _webDriver = null;
        }

        public static IWebDriver GetWebDriver()
        {
            Environment.SetEnvironmentVariable("webdriver.edgedriver", "/edgedriver/edgedriver");

            EdgeOptions edgeOptions = new EdgeOptions();
            edgeOptions.AddArgument("--window-size=2048,1536");
            edgeOptions.AddArgument("--disable-popup-blocking");
            edgeOptions.AddArgument("--force-device-scale-factor=0.75");
            edgeOptions.AddArgument("--disable-dev-shm-usage");
            edgeOptions.AddArgument("--no-sandbox");
            //edgeOptions.AddArgument("--headless=new");
            edgeOptions.AddArgument("--safebrowsing-disable-download-protection");
            edgeOptions.AddArgument("safebrowsing-disable-extension-blacklist");
            //edgeOptions.AddAdditionalCapability(CapabilityType.AcceptSslCertificates, true);
            //edgeOptions.AddAdditionalCapability(CapabilityType.AcceptInsecureCertificates, true);
            return new EdgeDriver(AppDomain.CurrentDomain.BaseDirectory, edgeOptions, TimeSpan.FromSeconds(180));
        }
    }
}
