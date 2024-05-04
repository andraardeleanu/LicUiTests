using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicUiTests.Pages
{
    public class StockPage
    {
        [FindsBy(How = How.XPath, Using = "//th[contains(@class,'css-1szkfps') and (text()='Stoc disponibil')]")]
        public IWebElement StockTableHead;
        
        [FindsBy(How = How.XPath, Using = "//th[contains(@class,'flex items-center stockTable justify-between css-1szkfps')]//button")]
        public IWebElement StockTableFilter;        
        
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'chakra-popover__body mt-6 stocksTable flex flex-col gap-4 css-1ews2c8')]//input")]
        public IWebElement StockTableFilterInput;    
        
        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-t9vlzo') and (text()='Actualizeaza')]")]
        public IWebElement UpdateStockButton; 
        
        [FindsBy(How = How.Id, Using = "availableStock")]
        public IWebElement NewAvailableStockInput;        
        
        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-jut409') and (text()='Actualizeaza')]")]
        public IWebElement UpdateNewAvailableStockButton;

        public IWebElement GetAvailableStockForProduct(string availableStock)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//header[contains(@class,'chakra-modal__header css-9fgtzh') and (text()='{availableStock}') and (text()=' buc.')]"));
        }

    }
}
