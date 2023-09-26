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
        }

        [When(@"I add the two products to the cart with the following details")]
        public void WhenIAddTheTwoProductsToTheCartWithTheFollowingDetails(Table table)
        {
            ProductsListPage productsListPage = new ProductsListPage(_driver);
            productsListPage.AddProductToCart(table.Rows[0]["ProductName"]);
            productsListPage.AddProductToCart(table.Rows[1]["ProductName"]);
            productsListPage.GoToCart();
        }

        [Then(@"I should see the cart page with the two products")]
        public void ThenIShouldSeeTheCartPageWithTheTwoProducts()
        {
            CartPage cartPage = new CartPage(_driver);
            cartPage.GetCartItemsName().Count.Should().Be(2);
        }

    }
}