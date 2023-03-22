using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium;

namespace SeleniumDotnet.Tests
{
    public class BaseTest
    {
        public IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }

        [TearDown] public void TearDown()
        {
            _driver.Quit();
        }
    }
}
