using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace LicUiTests.Pages
{
    public class WorkPointPage
    {
        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-jut409') and (text()='Adauga punct de lucru')]")]
        public IWebElement CreateNewWorkPointButton;

        [FindsBy(How = How.CssSelector, Using = ".chakra-button.css-jut409")]
        public IWebElement AddNewWorkPointButton;

        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement NewWorkPointNameField;

        [FindsBy(How = How.Id, Using = "address")]
        public IWebElement NewWorkPointAddressField;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Cauta dupa nume punct de lucru...']")]
        public IWebElement WorkpointNameFilter;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-41aesz') and (text()='Sterge')]")]
        public IWebElement ConfirmWorkpointDeleteButton;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-ez23ye') and (text()='Anuleaza')]")]
        public IWebElement CancelWorkpointDeleteButton;

        public IWebElement GetNewWorkpointName(string workpointName)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//p[contains(@class,'chakra-text css-0') and (text()='{workpointName}')]"));
        }
    }
}
