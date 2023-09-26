using BddProject.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BddProject.PageObjects
{
    public class BasePage
    {
        public IWebDriver driver;
        readonly IWait<IWebDriver> wait;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();
        }

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public string GetPageUrl()
        {
            return driver.Url;
        }

        public void RefreshPage()
        {
            driver.Navigate().Refresh();
        }
       
        public void GoBack()
        {
            driver.Navigate().Back();
        }
        public void GoForward()
        {
            driver.Navigate().Forward();
        }

        public void AcceptAlert()
        {
            driver.SwitchTo().Alert().Accept();
        }

        public void DismissAlert()
        {
            driver.SwitchTo().Alert().Dismiss();
        }

        public string GetAlertText()
        {
            return driver.SwitchTo().Alert().Text;
        }

        public void ClickOnElement(By locator)
        {
            try
            {
                IWebElement element = wait.Until(driver => driver.FindElement(locator));
                element.Click();
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine($"Element with locator '{locator}' is not clickable.");
            }
        }


        public void SendKeysToElement(By locator, string text)
        {
            try
            {
                IWebElement element = wait.Until(driver => driver.FindElement(locator));
                element.SendKeys(text);
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine($"Element with locator '{locator}' is not clickable.");
            }
        }


    }
}
