using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BddProject.PageObjects
{
    public class ProductsListPage : BasePage
    {



        public ProductsListPage(IWebDriver driver) : base(driver)
        {
        }

        private By addToCartButton = By.XPath("//button[text()='Add to cart']");
        private By cartButton = By.XPath("//a[@class='shopping_cart_link']");
        private By productItem (string productName) => By.XPath($"//*[text() = '{productName}']");

        public void AddProductToCart(string productName)
        {
            ClickOnElement(productItem(productName));
            ClickOnElement(addToCartButton);
            GoBack();
        }

        public void GoToCart()
        {
            ClickOnElement(cartButton);
        }
    }
}
