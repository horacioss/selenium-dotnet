using BddProject.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BddProject.Hooks
{
    [Binding]
    public class Hooks
    {
        readonly ScenarioContext _scenarioContext;
        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            IWebDriver _driver = WebDriverFactory.CreateWebDriver();
            _scenarioContext.ScenarioContainer.RegisterInstanceAs(_driver);
        }


        [AfterScenario]
        public void AfterScenario()
        {
            IWebDriver _driver = _scenarioContext.ScenarioContainer.Resolve<IWebDriver>();
            if (_scenarioContext.TestError != null)
            {
                // Create the folder Screenshots if not exists
                if (!Directory.Exists($"{Environment.CurrentDirectory}\\Screenshots"))
                {
                    Directory.CreateDirectory($"{Environment.CurrentDirectory}\\Screenshots");
                }
                WebDriverExtensions.TakeScreenshot(_driver).SaveAsFile($"{Environment.CurrentDirectory}\\Screenshots\\{_scenarioContext.ScenarioInfo.Title} - {DateTime.Now.ToString("ddMMyyyy_hhmmss")}.png");
            }
            _driver.Quit();
        }
    }
}
