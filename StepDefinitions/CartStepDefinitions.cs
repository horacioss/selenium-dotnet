using BddProject.PageObjects;
using OpenQA.Selenium;

namespace BddProject.StepDefinitions
{
    [Binding]
    public sealed class CartStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _driver;

        public CartStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.ScenarioContainer.Resolve<IWebDriver>();
        }

        [Given(@"open the products list page")]
        public void GivenOpenTheProductsListPage()
        {
            LoginPage loginPage = new(_driver);
            loginPage.LoginWithCredentials("standard_user", "secret_sauce");
            loginPage.GetPageUrl().Should().Contain("inventory.html");
            ProductsListPage productsListPage = new ProductsListPage(_driver);
        }

        [When(@"I add the two products to the cart with the following details")]
        public void WhenIAddTheTwoProductsToTheCartWithTheFollowingDetails(Table table)
        {
            throw new PendingStepException(); 
        }

        [Then(@"I should see the cart page with the two products")]
        public void ThenIShouldSeeTheCartPageWithTheTwoProducts()
        {
            throw new PendingStepException();
        }

    }
}