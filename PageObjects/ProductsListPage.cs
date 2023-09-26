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
        public ProductsListPage() : base(driver)
        {
        }

        private By addToCartButton = By.XPath("//button[text()='ADD TO CART']");
        private By cartButton = By.XPath("//a[@class='shopping_cart_link']");

        public void AddProductToCart(string productName)
        {
            ClickOnElement(addToCartButton);
        }

        public void GoToCart()
        {
            ClickOnElement(cartButton);
        }
    }
}
