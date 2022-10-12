using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.DevTools;

namespace ProjectUniworth
{
    [TestClass]
    public class LoginTestClass:BaseClass
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }

        }
        [TestMethod, TestCategory("Login")]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "XMLfile1.xml", "Login", DataAccessMethod.Sequential)]


        public void LogInUserWithValidDataTest()
        {
            BrowserImplemented("chrome");
            OpenUrl("https://uniworthshop.com");

            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();


            LoginClass loginValidData = new LoginClass();

            string user = TestContext.DataRow["email"].ToString();

            string pass = TestContext.DataRow["password"].ToString();

            loginValidData.LoginData(user, pass);
            //loginValidData.LoginSuccessful();

        }
        [TestMethod]
        public void LogInUserInvalidDataTest()
        {
            BrowserImplemented("chrome");
            OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            LoginClass loginInvalidData = new LoginClass();
            loginInvalidData.LoginData("byk.isr@gmail.com", "434343434");
        }
            //log.Info("Test Method is working");
    }
}
