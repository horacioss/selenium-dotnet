using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BddProject.PageObjects
{
    public class LoginPage : BasePage
    {
        private By usernameField = By.Id("user-name");
        private By passwordField = By.Id("password");
        private By loginButton = By.Id("login-button");

        public LoginPage(IWebDriver driver) : base(driver)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        public void LoginWithCredentials(string username, string password)
        {
            SendKeysToElement(usernameField, username);
            SendKeysToElement(passwordField, password);
            ClickOnElement(loginButton);
        }
    }
}
