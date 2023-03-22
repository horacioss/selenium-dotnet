using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDotnet.Sources.Pages
{
    public class BasePage
    {
        private IWebDriver _driver;
        public BasePage(IWebDriver driver) 
        {
            _driver = driver;
        }


        public void TypeTextIntoField(IWebElement inputElement, String textContent)
        {
            inputElement.SendKeys(textContent);
        }

        public void ClickOnElement(IWebElement element) 
        {
            element.Click();
        }

        public bool VerifyIfElementIsDisplayed(IWebElement element)
        {
            return element.Displayed;
        }


    }
}
