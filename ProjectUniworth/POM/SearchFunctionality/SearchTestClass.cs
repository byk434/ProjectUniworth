using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace ProjectUniworth
{
    
    [TestClass]
    public class SearchTestClass:ExtentReport
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

            LogReport("Search Functionality Report");
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            extentReports.Flush();
        }
        [TestMethod]
        public void SearchWithEmptySearchBarTest()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Search Functionality Search Bar Test");
            BaseClass.BrowserImplemented("chrome");
            BaseClass.OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            SearchClass emptySearch = new SearchClass();
            emptySearch.SearchFunction("");
            BaseClass.QuitBrowser();
        }
        [TestMethod]
        public void SearchWithValidDataTest()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Search Functionality Valid Test");
            BaseClass.BrowserImplemented("chrome");
            BaseClass.OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            SearchClass validSearch = new SearchClass();
            validSearch.SearchFunction("shirts");
            validSearch.messages();
            BaseClass.QuitBrowser();
        }
        [TestMethod]
        public void SearchWithInvalidDataTest()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Search Functionality Invalid Test");
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            SearchClass invalidSearch = new SearchClass();
            invalidSearch.SearchFunction("mobile");
            invalidSearch.messages();
            BaseClass.QuitBrowser();
        }
    }
}
