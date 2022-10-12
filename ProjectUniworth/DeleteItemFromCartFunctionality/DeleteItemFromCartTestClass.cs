using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectUniworth
{
    [TestClass]
    public class DeleteItemFromCartTestClass:BaseClass
    {
        [TestMethod]
        public void DeleteItemFromCartTest()
        {
            BrowserImplemented("edge");
            OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            SearchClass searching = new SearchClass();
            searching.SearchFunction("shirts");
            AddToCart addToCart = new AddToCart();
            addToCart.AddItemFromItemPage();
            DeleteItemFromCart deletingItem = new DeleteItemFromCart();
            deletingItem.deleteItem();
        }
    }
}
