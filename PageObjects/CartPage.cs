using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BddProject.PageObjects
{
    public class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }

        private By cartListItemSelector = By.XPath("//*[@id='cart_contents_container']/div/div[1]");
        private By cartItemNamesSelector = By.XPath($"//div[@class='cart_item']//div[@class='inventory_item_name']");
        private By checkoutButtonSelector = By.XPath("//button[@id='checkout']");

        public List<string> GetCartItemsName()
        {
            List<string> cartItems = new();
            var cartItemsList = driver.FindElements(cartItemNamesSelector);
            foreach (var item in cartItemsList)
            {
                cartItems.Add(item.Text);
            }
            return cartItems;
        }

        public void Checkout()
        {
            ClickOnElement(checkoutButtonSelector);
        }

    }
}
