using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.DevTools;

namespace ProjectUniworth
{
    [TestClass]
    public class LoginTestClass:ExtentReport
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
        [TestMethod, TestCategory("Login")]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "XMLfile1.xml", "Login", DataAccessMethod.Sequential)]


        public void LogInUserWithValidDataTest()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Log In Functionality Valid Test");
            BaseClass.BrowserImplemented("chrome");
            BaseClass.OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            LoginClass loginValidData = new LoginClass();
            string user = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            loginValidData.LoginData(user, pass);
            BaseClass.CloseBrowser();
        }
        [TestMethod]
        public void LogInUserInvalidDataTest()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Log In Functionality Invalid Test");
            BaseClass.BrowserImplemented("chrome");
            BaseClass.OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            LoginClass loginInvalidData = new LoginClass();
            loginInvalidData.LoginData("byk.isr@gmail.com", "434343434");
            BaseClass.CloseBrowser();
        }
    }
}
