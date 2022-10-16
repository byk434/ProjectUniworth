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
    public class DeleteItemFromCartTestClass:ExtentReport
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

            ExtentReport.LogReport("Delete Item From Cart Functionality Report");
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            ExtentReport.extentReports.Flush();
        }
        [TestMethod]
        public void DeleteItemFromCartTest()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Chat Functionality Test");
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            SearchClass searching = new SearchClass();
            searching.SearchFunction("shirts");
            AddToCart addToCart = new AddToCart();
            addToCart.AddItemFromItemPage();
            DeleteItemFromCart deletingItem = new DeleteItemFromCart();
            deletingItem.deleteItem();
            BaseClass.QuitBrowser();
        }
    }
}
