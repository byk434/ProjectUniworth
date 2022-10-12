using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectUniworth
{
    [TestClass]
    public class NavigationBarTestClass:BaseClass
    {
        public TestContext instance;
        public TestContext testContext
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
        public void NavigationBarFunctionalityTestCase()
        {
            ExtentReport.extentReports.CreateTest("Navigation Bar Test Case");
            BrowserImplemented("edge");
            OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            NavigationBar navBar = new NavigationBar();
            navBar.NavigationBarFunction();
        }
    }
}
