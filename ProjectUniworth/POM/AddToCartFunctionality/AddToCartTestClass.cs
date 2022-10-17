using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using AventStack.ExtentReports;

namespace ProjectUniworth
{
    [TestClass]
    public class AddToCartTestClass:ExtentReport
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
            LogReport("Add To Cart Functionality Report");
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            extentReports.Flush();
        }
        [TestMethod]
        public void AddToCartFromProductTileButtonTest()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Add To Cart From Prodct Tile Button Test");
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            SearchClass searching = new SearchClass();
            searching.SearchFunction("shirts");
            AddToCart addToCart = new AddToCart();
            addToCart.AddItemThroughButton();
            BaseClass.QuitBrowser();
            
        }
        [TestMethod]
        public void AddToCartFromProductPageTest()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Add To Cart From Product Page Test");
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            SearchClass searching = new SearchClass();
            searching.SearchFunction("shirts");
            AddToCart addToCart = new AddToCart();
            addToCart.AddItemFromItemPage();
            BaseClass.CloseBrowser();
            
        }
    }
}
