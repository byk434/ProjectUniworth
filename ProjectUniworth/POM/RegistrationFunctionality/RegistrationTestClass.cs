using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
namespace ProjectUniworth
{
    [TestClass]
    public class RegistrationTestClass:ExtentReport
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

            ExtentReport.LogReport("Registration Functionality Report");
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            ExtentReport.extentReports.Flush();
        }
        [TestMethod]
        public void RegisterUserWithValidDataTest()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Registeration Functionality Valid Test");
            BaseClass.BrowserImplemented("chrome");
            BaseClass.OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            RegisterUser registerValidData = new RegisterUser();
            registerValidData.RegisterData("Babar Khan", "byk.isr@gmail.com", "03021049606", "Babar12345", "Babar12345");
            BaseClass.QuitBrowser();
        }
        //[TestMethod]
        //public void RegisterUserWithInValidDataTest()
        //{
        //exParentTest = extentReports.CreateTest(TestContext.TestName);
            //exChildTest = exParentTest.CreateNode("Registeration Functionality Invalid Test");
        //    ExtentReport.extentReports.CreateTest("Registeration InValid Data Test Case");
        //    BrowserImplemented("chrome");
        //    OpenUrl("https://uniworthshop.com");
        //    Newsletter newsletter = new Newsletter();
        //    newsletter.newsLetter();
        //    RegisterUser registerInvalidData = new RegisterUser();
        //    registerInvalidData.RegisterData("Babar Khan", "byk.isr@gmail.com", "03021049606", "Babar12345", "Babar123456");
        //}

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "data.csv", DataAccessMethod.Sequential)]
        public void RegistrationWithInValidCredentials_CSV()
        {
            exParentTest = extentReports.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Registeration Functionality Invalid Test");
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            string name = TestContext.DataRow["fullname"].ToString();
            string email = TestContext.DataRow["emailaddress"].ToString();
            string mobileno = TestContext.DataRow["mobilenumber"].ToString();
            string pass1 = TestContext.DataRow["password"].ToString();
            string pass2 = TestContext.DataRow["confirmpassword"].ToString();
            RegisterUser regi = new RegisterUser();
            regi.RegisterData(name, email, mobileno, pass1, pass2);
            BaseClass.QuitBrowser();
        }
    }
}
