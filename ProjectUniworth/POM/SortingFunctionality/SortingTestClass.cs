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
    public class SortingTestClass:ExtentReport
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

            LogReport("Sorting Functionality Report");
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            extentReports.Flush();
        }
        [TestMethod]
        public void SortingFunctionalityTestCase()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Sorting Functionality Test");
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            NavigationBar navBar = new NavigationBar();
            navBar.NavigationBarFunction();
            SortingItems sortingFunctionality = new SortingItems();
            sortingFunctionality.SortingFunction();
            BaseClass.QuitBrowser();
        }
    }
}
