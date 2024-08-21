using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicUiTests.Pages
{
    public class UsersPage
    {
        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-jut409') and (text()='Adauga client nou')]")]
        public IWebElement AddNewUserButton;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-jut409') and (text()='Adauga client')]")]
        public IWebElement AddUserButton;

        [FindsBy(How = How.Id, Using = "firstname")]
        public IWebElement FirstnameField;

        [FindsBy(How = How.Id, Using = "firstName")]
        public IWebElement FirstnameUpdateField;

        [FindsBy(How = How.Id, Using = "lastname")]
        public IWebElement LastnameField;

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement UsernameField;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordField;

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailField;

        [FindsBy(How = How.Id, Using = "companyId")]
        public IWebElement CompanyDropdown;

        [FindsBy(How = How.XPath, Using = "//input[contains(@class,'chakra-input css-c51tnq')]")]
        public IWebElement CustomerSearchBar;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-27qn8x') and (text()='Modifica')]")]
        public IWebElement UpdateCustomerButton;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-menu__menuitem css-18esm8n') and (text()='Profil')]")]
        public IWebElement UserProfileButton;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-menu__menu-button css-kjvu41')]")]
        public IWebElement UserSettingsButton;

        [FindsBy(How = How.Id, Using = "oldPassword")]
        public IWebElement OldPasswordField;

        [FindsBy(How = How.Id, Using = "newPassword")]
        public IWebElement NewPasswordField;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'chakra-button css-jut409') and (text()='Schimba parola')]")]
        public IWebElement ChangePasswordButton;

        public IWebElement GetNewUsername(string username)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//td[contains(@class,'css-zgoslk') and (text()='{username}')]"));
        }

        public IWebElement GetCompanyFromDropdown(string companyName)
        {
            return Helpers.WebDriver.Driver.FindElement(By.XPath($"//select[contains(@class,'chakra-select css-161pkch')]//option[(text()='{companyName}')]"));
        }

    }
}
