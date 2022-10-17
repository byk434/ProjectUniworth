using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectUniworth
{
    [TestClass]
    public class FindOurStoreTestClass:ExtentReport
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

            LogReport("Find Our Store Functionality Report");
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            extentReports.Flush();
        }
        [TestMethod]
        public void FindOurStoreFunctionalityTestCase()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Find Our Store Functionality Test");
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            FindOurStore findStore = new FindOurStore();
            findStore.findStore();
            BaseClass.QuitBrowser();
        }
    }
}
