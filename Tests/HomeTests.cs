using AngleSharp.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PortalPagosTestAutomation.Sources.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace PortalPagosTestAutomation.Tests
{
    public class HomeTests : BaseTest
    {


        [Test]
        public void TestLogin()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            HomePage homePage = new HomePage(_driver);
            homePage.Login("standard_user", "secret_sauce");

            Assert.That(_driver.Url.Contains("inventory.html"), Is.True);
        }
    }
}
