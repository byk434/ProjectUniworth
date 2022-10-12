using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectUniworth
{
    [TestClass]
    public class ProceedToCheckoutTestClass:BaseClass
    {
        [TestMethod]
        [Timeout (500000)]
        public void ProceedToCheckOutAsAGuest()
        {

            BrowserImplemented("edge");
            OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            SearchClass searching = new SearchClass();
            searching.SearchFunction("shirts");
            AddToCart addToCart = new AddToCart();
            addToCart.AddItemFromItemPage();
            ProceedToCheckout PTC = new ProceedToCheckout();
            PTC.ProceedToCO();
            ProceedToCheckout UserIsGuest = new ProceedToCheckout();
            UserIsGuest.AsGuest("booo", "imran1@gmail.com", "03021048606", "Pakistan", "Punjab", "LAHORE", "54000", "bobo1", "bobo1", "juju road", "jiji town");
        }
        [TestMethod]
        public void ProceedToCheckOutAsNewUser()
        {

            BrowserImplemented("edge");
            OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            SearchClass searching = new SearchClass();
            searching.SearchFunction("shirts");
            AddToCart addToCart = new AddToCart();
            addToCart.AddItemFromItemPage();
            ProceedToCheckout UserIsRegistering = new ProceedToCheckout();
            UserIsRegistering.ProceedToCO();
            UserIsRegistering.RegisterNewUser();
            UserIsRegistering.AsGuest("booo", "imran12@gmail.com", "03021058606", "Pakistan", "Punjab", "LAHORE", "54000", "bobobob1", "bobobob1", "juju road", "jiji town");
        }
        [TestMethod]
        public void ProceedToCheckOutAsExistingUser()
        {

            BrowserImplemented("edge");
            OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            SearchClass searching = new SearchClass();
            searching.SearchFunction("shirts");
            AddToCart addToCart = new AddToCart();
            addToCart.AddItemFromItemPage();
            ProceedToCheckout alreadyExistingUser = new ProceedToCheckout();
            alreadyExistingUser.ProceedToCO();
            alreadyExistingUser.ExistingUser("byk.isr@gmail.com", "Babar12345", "Lahore", "jiji town");


       }
    }
}
