using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicUiTests.Pages
{
    public class CompanyPage
    {
        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-jut409')][text()='Adauga companie']")]
        public IWebElement CreateNewCompanyButton;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-jut409')][text()='Adauga']")]
        public IWebElement AddNewCompanyButton;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-jut409')][text()='Actualizeaza']")]
        public IWebElement UpdateButton;

        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement NewCompanyNameField;

        [FindsBy(How = How.Id, Using = "cui")]
        public IWebElement NewCompanyCuiField;

        [FindsBy(How = How.XPath, Using = "//table[contains(@class,'chakra-table css-5605sr')]")]
        public IWebElement CompanyWorkpointsTable;

        [FindsBy(How = How.XPath, Using = "(//button[contains(@class,'chakra-button css-15bt6gt')])[1]")]
        public IWebElement UpdateFirstCompany;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Cauta dupa nume companie...']")]
        public IWebElement CompanyNameFilter;

        public IWebElement GetCompanyName(string companyName)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//header[contains(@class,'chakra-modal__header css-9fgtzh') and (text()='{companyName}')]"));
        }
        public IWebElement GetCompanyWorkpointName(string companyWorkpointName)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//div[contains(@class,'chakra-modal__content-container css-wl0d9u')]//td[(text()='{companyWorkpointName}')]"));
        }
        public IWebElement GetNewCompanyName(string companyName)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//p[contains(@class,'chakra-text css-0') and (text()='{companyName}')]"));
        }
    }
}
