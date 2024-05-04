using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace LicUiTests.Helpers
{
    public static class Utils
    {
        private static readonly Random Random = new Random();
        public static void SwitchToIframe(IWebElement iframe)
        {
            WebDriver.Driver.SwitchTo().DefaultContent();

            IWrapsElement wrapper = iframe as IWrapsElement;
            WebDriver.Driver.SwitchTo().Frame(wrapper.WrappedElement);
        }

        public static void UploadFile(string fileName)
        {
            Sync.ExplicitWait(2);
            var folderPath = new[] { Directory.GetCurrentDirectory(), "Resources", fileName };
            string filePath = Path.Combine(folderPath);
            //string newFilePath = filePath.Replace(@"\\", @"\");
            var element = WebDriver.Driver.FindElement(By.Id("uploadedFile"));
            element.SendKeys(filePath);
        }

        public static bool Exists(this IWebElement element)
        {
            try
            {
                return element.Enabled;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void MouseHover(IWebElement element)
        {
            var actions = new OpenQA.Selenium.Interactions.Actions(WebDriver.Driver);
            actions.MoveToElement(element);
            actions.Perform();
        }
        public static void ScrollBottomOfPage()
        {
            IJavaScriptExecutor script = (IJavaScriptExecutor)WebDriver.Driver;
            script.ExecuteScript("window.scroll(0,0);");
        }
        public static void ScrollToTopOfPage()
        {
            IJavaScriptExecutor script = (IJavaScriptExecutor)WebDriver.Driver;
            script.ExecuteScript("window.scroll({top: 0});");
        }
        public static void ScrollToElement(IWebElement webElement)
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)WebDriver.Driver;
            je.ExecuteScript("arguments[0].scrollIntoView(true);", webElement);
        }
        public static void ScrollToElementAndClick(this IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)WebDriver.Driver;
            executor.ExecuteScript("arguments[0].scrollIntoView();", element);
            executor.ExecuteScript("arguments[0].click();", element);
        }
        public static void ClickUsingJS(IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)WebDriver.Driver;
            executor.ExecuteScript("arguments[0].click();", element);
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
        public static class TableExtensions
        {
            public static Dictionary<string, string> ToDictionary(Table table)
            {
                var dictionary = new Dictionary<string, string>();
                foreach (var row in table.Rows)
                {
                    dictionary.Add(row[0], row[1]);
                }
                return dictionary;
            }
        }

        public static bool TryFindElement(string element)
        {
            bool presence;
            try
            {
                WebDriver.Driver.FindElement(By.Id(element));
                presence = true;
            }
            catch (NoSuchElementException)
            {
                presence = false;
            }
            return presence;
        }

        public static void ZoomOutPage()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebDriver.Driver;
            js.ExecuteScript("document.body.style.zoom='70%'");
        }

        public static bool CheckFileDownloaded(string filename)
        {
            bool exist = false;
            string path = AppSettings.DownloadPath == null ? Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads" : AppSettings.DownloadPath;
            string[] filePaths = Directory.GetFiles(path);
            foreach (string p in filePaths)
            {
                if (p.Contains(filename))
                {
                    FileInfo thisFile = new FileInfo(p);
                    if (thisFile.LastWriteTime.ToShortTimeString() == DateTime.Now.ToShortTimeString() ||
                    thisFile.LastWriteTime.AddMinutes(1).ToShortTimeString() == DateTime.Now.ToShortTimeString())
                        exist = true;
                    File.Delete(p);
                    break;
                }
            }
            return exist;
        }
    }
}
