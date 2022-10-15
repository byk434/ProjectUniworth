using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectUniworth
{
    [TestClass]
    public class ProceedToCheckoutTestClass:ExtentReport
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }

        }
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {

            ExtentReport.LogReport("Extent Report");
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            ExtentReport.extentReports.Flush();
        }
        [TestMethod]
        public void ProceedToCheckOutAsAGuest()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Proceed to Checkout as Guest Functionality Test");
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
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
            BaseClass.CloseBrowser();
        }
        [TestMethod]
        public void ProceedToCheckOutAsNewUser()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Proceed to Checkout Register New User Functionality Test");
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
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
            BaseClass.CloseBrowser();
        }
        [TestMethod]
        public void ProceedToCheckOutAsExistingUser()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Proceed to Checkout by Login Functionality Test");
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            SearchClass searching = new SearchClass();
            searching.SearchFunction("shirts");
            AddToCart addToCart = new AddToCart();
            addToCart.AddItemFromItemPage();
            ProceedToCheckout alreadyExistingUser = new ProceedToCheckout();
            alreadyExistingUser.ProceedToCO();
            alreadyExistingUser.ExistingUser("byk.isr@gmail.com", "Babar12345", "Lahore", "jiji town");
            BaseClass.CloseBrowser();
       }
    }
}
