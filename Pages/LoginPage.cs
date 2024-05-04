using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace LicUiTests.Pages
{
    public class LoginPage
    {
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Intra in cont')]")]
        public IWebElement ConnectButton;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-menu__menu-button')]")]
        public IWebElement UserInitialButton;

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement UsernameField;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordField;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Conecteaza-te')]")]
        public IWebElement LoginButton;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Deconectare')]")]
        public IWebElement SingOutButton;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-18zw69y') and (text()='Deconecteaza-te')]")]
        public IWebElement ConfirmSignOutButton;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'chakra-alert__title')]")]
        public IWebElement WarningMessage;

        public IWebElement GetUserInitial(string userInitial)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//span/div[text()='{userInitial}']"));
        }
    }
}
