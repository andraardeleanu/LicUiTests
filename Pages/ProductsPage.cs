using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace LicUiTests.Pages
{
    public class ProductsPage
    {
        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-jut409')][text()='Adauga produs']")]
        public IWebElement AddProductButton;

        [FindsBy(How = How.XPath, Using = "//tr/th[text()='Produs']")]
        public IWebElement TableHead;

        [FindsBy(How = How.XPath, Using = "//th[contains(@class,'flex items-center justify-between css-1szkfps')]/span[text()='Nume produs']")]
        public IWebElement ProductNameTableHead;

        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement ProductNameField;

        [FindsBy(How = How.Id, Using = "price")]
        public IWebElement ProductPriceField;

        [FindsBy(How = How.Id, Using = "availableStock")]
        public IWebElement AvailableStockField;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-1j1ql7x')]")]
        public IWebElement ProductNameFilter;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'chakra-alert__desc css-161kwbg')]")]
        public IWebElement ToastMessage;

        [FindsBy(How = How.CssSelector, Using = ".chakra-modal--body-:r5l:")]
        public IWebElement InfoMessage;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'chakra-popover__body mt-6 productsTable flex flex-col gap-4 css-1ews2c8')]//input")]
        public IWebElement ProductNameFilterField;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-popover__close-btn css-1o8qips')]")]
        public IWebElement CloseFilterButton;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'chakra-select__wrapper css-1lgfiln')]//select[contains(@class,'chakra-select css-1gmqjwm')]")]
        public IWebElement PriceFilterButton;

        [FindsBy(How = How.XPath, Using = "//select[contains(@class,'chakra-select css-1gmqjwm')]//option[(text()='Crescator')]")]
        public IWebElement PriceAscendingFilterButton;

        [FindsBy(How = How.XPath, Using = "//select[contains(@class,'chakra-select css-1gmqjwm')]//option[(text()='Descrescator')]")]
        public IWebElement PriceDescendingFilterButton;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'productsTable')]//tr[1]/td[3]")]
        public IWebElement FirstProductPriceFromTable;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-t9vlzo') and (text()='Vezi stoc')]")]
        public IWebElement ViewStockButton;

        [FindsBy(How = How.XPath, Using = "//th[contains(@class,'css-1zts0j') and (text()='Cantitate disponibila')]")]
        public IWebElement ViewStockDetails;

        public IWebElement GetProductFromTable(string productName)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//td[contains(@class,'css-zgoslk') and (text()='{productName}')]"));
        }
    }
}
