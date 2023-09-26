using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace BddProject.Helpers
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver()
        {

            string browser = Environment.GetEnvironmentVariable("BROWSER_TYPE") ?? "Chrome";

            if (!Enum.TryParse(browser, out BrowserType browserType))
            {
                throw new Exception($"Browser '{browser}' is not supported. Only support 'Chrome', 'Firefox' and 'Edge'.");
            }

            IWebDriver driver;
            switch (browserType)
            {
                case BrowserType.Chrome:
                    string chromeDriverPath = @" C:\Users\horac\chromedriver\win64-117.0.5938.92\chromedriver-win64";
                    ChromeOptions chromeOptions = new()
                    {
                        BinaryLocation = @"C:\Users\\horac\chrome\win64-117.0.5938.92\chrome-win64\chrome.exe",
                    };
                    driver = new ChromeDriver(chromeDriverPath, chromeOptions);
                    return driver;

                case BrowserType.Edge:
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    return driver;

                case BrowserType.Firefox:
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    return driver;

                default:
                    throw new Exception($"Browser '{browser}' is not supported.");
            }

        }
    }

    public enum BrowserType
    {
        Chrome,
        Firefox,
        Edge
    }

}
