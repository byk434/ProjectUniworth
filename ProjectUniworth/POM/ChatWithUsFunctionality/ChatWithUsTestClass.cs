using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.DevTools.V104.IndexedDB;

namespace ProjectUniworth
{
    [TestClass]
    public class ChatWithUsTestClass:ExtentReport
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

            ExtentReport.LogReport("Chat With Us Functionality Report");
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            ExtentReport.extentReports.Flush();
        }
        [TestMethod]
        public void ChatWithUsFunctionalityTestCase()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Chat Functionality Test");
            //ExtentReport.extentReports.CreateTest("Chat With Us Test Case");

            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            ChatWithUs chatWithUs = new ChatWithUs();
            chatWithUs.ChatWithUsFunctionality();
            BaseClass.QuitBrowser();
        }
    }
}
