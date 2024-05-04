using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace LicUiTests.Pages
{
    public class OrdersPage
    {
        [FindsBy(How = How.XPath, Using = "//th//span[text()='Numar comanda']")]
        public IWebElement TableHead;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-t9vlzo') and (text()='Detalii')]")]
        public IWebElement OrderDetailsButton;

        [FindsBy(How = How.XPath, Using = "//tr/th[text()='Nume produs']")]
        public IWebElement OrderDetailsTableHead;

        [FindsBy(How = How.CssSelector, Using = ".chakra-button.css-1xei7nb")]
        public IWebElement OrderNoFilter;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'chakra-popover__body mt-6 flex flex-col gap-4 css-1ews2c8')]//input[contains(@placeholder,'Numar comanda')]")]
        public IWebElement OrderNoFilterInput;
        
        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button manualOrderButton css-jut409')]")]
        public IWebElement CreateManualOrderButton;
        
        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-jut409') and (text()='Creeaza comanda automat')]")]
        public IWebElement CreateFileOrderButton;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-jut409') and (text()='Creeaza')]")]
        public IWebElement CreateOrderButton;

        [FindsBy(How = How.XPath, Using = "(//input[contains(@class,'chakra-input max-w-[100px] css-1673cor')])[1]")]
        public IWebElement FirstProductManualOrderInput;

        [FindsBy(How = How.XPath, Using = "(//input[contains(@class,'chakra-input max-w-[100px] css-1673cor')])[2]")]
        public IWebElement SecondProductManualOrderInput;

        [FindsBy(How = How.XPath, Using = "(//input[contains(@class,'chakra-input max-w-[100px] css-1673cor')])[3]")]
        public IWebElement ThirdProductManualOrderInput;

        [FindsBy(How = How.XPath, Using = "(//tr[1]/td[contains(@class,'css-1eyncsv')])[2]")]
        public IWebElement FirstProductPrice;

        [FindsBy(How = How.XPath, Using = "(//tr[2]/td[contains(@class,'css-1eyncsv')])[2]")]
        public IWebElement SecondProductPrice;

        [FindsBy(How = How.XPath, Using = "(//tr[3]/td[contains(@class,'css-1eyncsv')])[2]")]
        public IWebElement ThirdProductPrice;

        [FindsBy(How = How.XPath, Using = "//table[contains(@class,'chakra-table ordersTable css-5605sr')]//tr[1]/td[3]")]
        public IWebElement FirstOrderDateFromTable;         

        [FindsBy(How = How.XPath, Using = "//select[contains(@class,'chakra-select orderModal css-161pkch')]")]
        public IWebElement WorkpointsDropdownManualOrder;      

        [FindsBy(How = How.XPath, Using = "//select[contains(@class,'chakra-select css-161pkch')]")]
        public IWebElement WorkpointsDropdownFileOrder;    

        [FindsBy(How = How.XPath, Using = "//select[contains(@class,'chakra-select statusFilter css-1gmqjwm')]")]
        public IWebElement OrderStatusFilter;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'flex justify-center') and (text()='Nu s-au gasit rezultate.')]")]
        public IWebElement NoResultsOnOrdersTable;

        [FindsBy(How = How.Id, Using = "uploadedFile")]
        public IWebElement FileUploadInput;


        public IWebElement GetOrderByNumber(string companyName)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//header[contains(@class,'chakra-modal__header css-9fgtzh') and (text()='{companyName}')]"));
        }
        public IWebElement GetWorkpointForManualOrder(string workpointName)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//div[contains(@class,'chakra-modal__body css-1cyjcql')]//option[text()='{workpointName}']"));
        }

        public IWebElement GetWorkpointForFileOrder(string workpointName)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//div[contains(@class,'chakra-card css-276vn5')]//option[text()='{workpointName}']"));
        }
        public IWebElement GetDisplayedOrderNumber(string orderNumber)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//tr//td[text()='{orderNumber}']"));
        }
        public IWebElement GetStatusFromFilter(string status)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//select[contains(@class,'chakra-select statusFilter css-1gmqjwm')]//option[text()='{status}']"));
        }
    }
}
