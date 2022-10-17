using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectUniworth
{
    [TestClass]

    public class NewsletterSubscriptionTestClass:ExtentReport
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

            LogReport("Newsletter Functionality Report");
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            extentReports.Flush();
        }
        [TestMethod]
        public void SubscribeToNewsletterValidDataTest()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Subscribe to Newsletter Functionality Valid Test");
            BaseClass.BrowserImplemented("chrome");
            BaseClass.OpenUrl("https://uniworthshop.com");
            Newsletter subValidData = new Newsletter();
            subValidData.SubscribeNewsletter("03004545424", "aqsa.aqua@gmail.com");
            BaseClass.QuitBrowser();
        }
        [TestMethod]

        public void ScubscribeToNewsletterWithInvalidDataTest()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Subscribe to Newsletter Functionality InValid Test");
            BaseClass.BrowserImplemented("chrome");
            BaseClass.OpenUrl("https://uniworthshop.com");
            Newsletter subInvalidData = new Newsletter();
            subInvalidData.SubscribeNewsletter("030021049606", "bykisrgmail.com");
            BaseClass.QuitBrowser();
        }
    }
}
