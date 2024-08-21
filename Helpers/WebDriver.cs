using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Diagnostics;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace LicUiTests.Helpers
{
    public class WebDriver
    {
        private static IWebDriver _webDriver;
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

        public static string HandleEdgeAuth(string url, string username, string password)
        {
            string authData = username + ":" + password + "@";
            return url.Insert(url.IndexOf("//") + 2, authData);

        }

        public static void HandleEdgePopup(string username, string password)
        {

            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(15));
            if (wait.Until(ExpectedConditions.AlertIsPresent()) != null)
            {
                IAlert alert = _webDriver.SwitchTo().Alert();
                alert.SendKeys(username + Keys.Tab + password);
                alert.Accept();
            }
        }

        public static void Quit()
        {
            _webDriver?.Close();
            _webDriver?.Quit();

            switch (AppSettings.BrowserType)
            {
                case "Chrome":
                    Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");

                    foreach (var chromeDriverProcess in chromeDriverProcesses)
                    {
                        chromeDriverProcess.Kill();
                    }

                    _webDriver = null;
                    break;
                case "Edge":
                    Process[] edgeDriverProcesses = Process.GetProcessesByName("msedgedriver");

                    foreach (var edgeDriverProcess in edgeDriverProcesses)
                    {
                        edgeDriverProcess.Kill();
                    }

                    _webDriver = null;
                    break;
                default: throw new NotSupportedException("not supported browser: <null>");
            }
        }

        private static IWebDriver GetWebDriver()
        {
            switch (AppSettings.BrowserType)
            {
                case "Chrome":
                    ChromeOptions chromeOptions = GetChromeOptions();
                    return new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory,
                        chromeOptions, TimeSpan.FromSeconds(180));
                case "Edge":
                    EdgeOptions edgeOptions = GetEdgeOptions();
                    return new EdgeDriver(AppDomain.CurrentDomain.BaseDirectory,
                        edgeOptions, TimeSpan.FromSeconds(180));
                default: throw new NotSupportedException("not supported browser: <null>");
            }
        }
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--window-size=1920,1080");
            chromeOptions.AddArgument("--disable-popup-blocking");
            chromeOptions.AddArgument("--force-device-scale-factor=0.75");
            chromeOptions.AddArgument("--high-dpi-support=0.75");
            chromeOptions.AddArgument("--incognito");
            chromeOptions.AddArgument("--no-sandbox"); //required for container test run
            chromeOptions.AddArgument("--disable-dev-shm-usage");
            chromeOptions.AddArgument("--ignore-certificate-errors");

            return chromeOptions;
        }

        private static EdgeOptions GetEdgeOptions()
        {
            EdgeOptions edgeOptions = new EdgeOptions();

            edgeOptions.AddArgument("--window-size=1920,1080");
            edgeOptions.AddArgument("--disable-popup-blocking");
            edgeOptions.AddArgument("--force-device-scale-factor=0.75");
            edgeOptions.AddArgument("--high-dpi-support=0.75");
            edgeOptions.AddArgument("--no-sandbox");
            edgeOptions.AddArgument("--disable-dev-shm-usage");
            edgeOptions.AddArgument("--ignore-certificate-errors");

            return edgeOptions;
        }

    }

}