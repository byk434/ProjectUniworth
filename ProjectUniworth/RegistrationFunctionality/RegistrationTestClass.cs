using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
namespace ProjectUniworth
{
    [TestClass]
    public class RegistrationTestClass : BaseClass
    {
        [TestMethod]
        public void RegisterUserWithValidDataTest()
        {
            BrowserImplemented("chrome");
            OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            RegisterUser registerValidData = new RegisterUser();
            registerValidData.RegisterData("Babar Khan", "byk.isr@gmail.com", "03021049606", "Babar12345", "Babar12345");
        }
        [TestMethod]
        public void RegisterUserWithInValidDataTest()
        {
            BrowserImplemented("chrome");
            OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            RegisterUser registerInvalidData = new RegisterUser();
            registerInvalidData.RegisterData("Babar Khan", "byk.isr@gmail.com", "03021049606", "Babar12345", "Babar123456");
        }

        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data#csv", "data.csv", DataAccessMethod.Sequential)]
        public void RegistrationWithValidCredentials_CSV()
        {
            BrowserImplemented("edge");
            OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();

            string name = TestContext.DataRow["fullname"].ToString();
            string email = TestContext.DataRow["emailaddress"].ToString();
            string mobileno = TestContext.DataRow["mobilenumber"].ToString();
            string pass1 = TestContext.DataRow["password"].ToString();
            string pass2 = TestContext.DataRow["confirmpassword"].ToString();
            RegisterUser regi = new RegisterUser();
            regi.RegisterData(name, email, mobileno, pass1, pass2);
        }
    }
}
