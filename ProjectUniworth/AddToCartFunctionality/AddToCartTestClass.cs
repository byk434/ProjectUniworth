using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectUniworth
{
    [TestClass]
    public class AddToCartTestClass:BaseClass
    {
        [TestMethod]
        public void AddToCartFromButtonTest()
        {
            
            BrowserImplemented("edge");
            OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            SearchClass searching = new SearchClass();
            searching.SearchFunction("shirts");
            AddToCart addToCart = new AddToCart();
            addToCart.AddItemThroughButton();
        }
        [TestMethod]
        public void AddToCartFromItemPageTest()
        {
            BrowserImplemented("edge");
            OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            SearchClass searching = new SearchClass();
            searching.SearchFunction("shirts");
            AddToCart addToCart = new AddToCart();
            addToCart.AddItemFromItemPage();
        }
    }
}
