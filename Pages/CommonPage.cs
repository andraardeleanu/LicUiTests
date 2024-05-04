using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicUiTests.Pages
{
    public class CommonPage
    {
        [FindsBy(How = How.CssSelector, Using = ".chakra-alert__title.css-tidvy5")]
        public IWebElement ToastMessage;

        [FindsBy(How = How.CssSelector, Using = ".chakra-stack.css-tx0vij")]
        public IWebElement CompanyWorkpointBox;

        [FindsBy(How = How.CssSelector, Using = ".chakra-text.css-0")]
        public IWebElement CompanyWorkpointBoxName;

        [FindsBy(How = How.XPath, Using = "//ul[contains(@class,'chakra-wrap__list css-m6pq25')]")]
        public IWebElement TabInfoMeesage;

        [FindsBy(How = How.XPath, Using = "(//button[contains(@class,'chakra-button css-15bt6gt')])[1]")]
        public IWebElement UpdateOptionButton;

        [FindsBy(How = How.XPath, Using = "(//button[contains(@class,'chakra-button css-15bt6gt')])[2]")]
        public IWebElement RemoveWorkpointButton;

        public IWebElement GetTab(string tabName)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//button[contains(@class,'chakra-tabs__tab css-52dxnr') and (text()='{tabName}')]"));
        }
        public IWebElement GetInfoMessage(string infoMessage)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//div[contains(@class,'chakra-modal__body css-alr2n5') and (text()='{infoMessage}')]"));
        }     
        public IWebElement GetErrorMessage(string errorMessage)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//div[contains(@class,'chakra-alert__title css-tidvy5') and (text()='{errorMessage}')]"));
        }    
    }
}
