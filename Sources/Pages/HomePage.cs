using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalPagosTestAutomation.Sources.Pages
{
    internal class HomePage : BasePage
    {
        IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "user-name")]
        private IWebElement _usernameInput;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement _passwordInput;

        [FindsBy(How = How.Id, Using = "login-button")]
        private IWebElement _loginButton;

        public HomePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


        public void Login(string username, string password)
        {
            TypeTextIntoField(_usernameInput, username);
            TypeTextIntoField(_passwordInput, password);
            ClickOnElement(_loginButton);
        }



    }
}
