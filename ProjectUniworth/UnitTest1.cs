using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SikuliModule;
using OpenQA.Selenium.Edge;


namespace ProjectUniworth
{
   


    [TestClass]
    public class UnitTest1:BaseClass
    {
        private static readonly log4net.ILog log =
   log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        //public TestContext instance;
        //public TestContext TestContext
        //{
        //    set { instance = value; }
        //    get { return instance; }

        //}
        //[TestMethod, TestCategory("Login")]

        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "XMLfile1.xml", "Login", DataAccessMethod.Sequential)]


        //public void LogInUserWithValidDataTest()
        //{
        //    BaseClass.SeleniumInit("chrome");
        //    BaseClass.OpenUrl("https://uniworthshop.com");



        //    LoginClass loginValidData=new LoginClass();

        //    string user = TestContext.DataRow["email"].ToString();

        //    string pass = TestContext.DataRow["password"].ToString();

        //    loginValidData.LoginData(user,pass);



        //}
        //[TestMethod]
        //public void LogInUserInvalidDataTest()
        //{
        //    BaseClass.SeleniumInit("chrome");
        //    BaseClass.OpenUrl("https://uniworthshop.com");
        //    LoginClass loginInvalidData = new LoginClass();
        //    loginInvalidData.LoginData("byk.isr@gmail.com", "434343434");
        //}
        [TestMethod]
        public void LogInInUserWithInvalidDataTest()
        {
            log.Info("Test Method is working");

            BaseClass.BrowserImplemented("chrome");
            BaseClass.OpenUrl("https://uniworthshop.com");
            InvalidLogin loginInvalidData = new InvalidLogin();
            loginInvalidData.InvalidLoginData("byk.isr@gmail.com", "434343434");
        }
        [TestMethod]
        public void RegisterUserWithValidDataTest()
        {
            BaseClass.BrowserImplemented("chrome");
            BaseClass.OpenUrl("https://uniworthshop.com");
            RegisterUser registerValidData = new RegisterUser();
            registerValidData.RegisterData("Babar Khan", "byk.isr@gmail.com", "03021049606", "Babar12345", "Babar12345");
        }
        [TestMethod]
        public void RegisterUserWithInValidDataTest()
        {
            BaseClass.BrowserImplemented("chrome");
            BaseClass.OpenUrl("https://uniworthshop.com");
            RegisterUser registerInvalidData = new RegisterUser();
            registerInvalidData.RegisterData("Babar Khan", "byk.isr@gmail.com", "03021049606", "Babar12345", "Babar123456");
        }
        [TestMethod]
        public void SubscribeToNewsletterValidDataTest()
        {
            BaseClass.BrowserImplemented("chrome");
            BaseClass.OpenUrl("https://uniworthshop.com");
            NewsletterSubscription subValidData = new NewsletterSubscription();
            subValidData.SubscribeNewsletter("03004545444", "bizarrejizzus@gmail.com");
        }
        [TestMethod]
        public void ScubscribeToNewsletterWithInvalidDataTest()
        {
            BaseClass.BrowserImplemented("chrome");
            BaseClass.OpenUrl("https://uniworthshop.com");
            NewsletterSubscription subInvalidData = new NewsletterSubscription();
            subInvalidData.SubscribeNewsletter("030021049606", "bykisrgmail.com");
        }
        [TestMethod]
        public void CheckSearchBarEnteringDataText()
        {
            BaseClass.BrowserImplemented("chrome");
            BaseClass.OpenUrl("https://uniworthshop.com");
            SearchClass searchByData = new SearchClass();
            searchByData.SearchBar("shirts");
        }
        [TestMethod]
        public void SearchWithEmptySearchBarTest()
        {
            BaseClass.BrowserImplemented("chrome");
            BaseClass.OpenUrl("https://uniworthshop.com");
            SearchClass emptySearch = new SearchClass();
            emptySearch.SearchFunction("");
        }
        [TestMethod]
        public void SearchWithValidDataTest()
        {
            BaseClass.BrowserImplemented("chrome");
            BaseClass.OpenUrl("https://uniworthshop.com");
            SearchClass validSearch = new SearchClass();
            validSearch.SearchFunction("shirts");
        }
        [TestMethod]
        public void SearchWithInvalidDataTest()
        {
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            SearchClass invalidSearch = new SearchClass();
            invalidSearch.SearchFunction("mobile");
        }
        [TestMethod]
        public void AddToCartFromButtonTest()
        {
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            AddToCart addToCart = new AddToCart();
            addToCart.AddItemThroughButton("shirts");
        }
        [TestMethod]
        public void AddToCartFromItemPageTest()
        {
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            AddToCart addToCart = new AddToCart();
            addToCart.AddItemFromItemPage("shirts");
        }
        [TestMethod]

        public void viewas()
        {
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://www.junaidjamshed.com");

            AddToCart grid1 = new AddToCart();
            grid1.View();


        }
        [TestMethod]
        public void NavigationBarFunctionalityTestCase()
        {
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            NavigationBar navBar = new NavigationBar();
            navBar.NavigationBarFunction();
        }
        [TestMethod]
        public void FilterBarFunctionalityTestCase()
        {
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            FilterBar filterBarSelectColor = new FilterBar();
            filterBarSelectColor.FilterBarFunction();
        }
        [TestMethod]
        public void Extra()
        {
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://api.whatsapp.com/send/?phone=923454037778&text&type=phone_number&app_absent=0");
            ChatWithUs chatWA = new ChatWithUs();
            chatWA.WA();
        }
        [TestMethod]
        public void ChatWithUsFunctionalityTestCase()
        {
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            ChatWithUs chatWithUs = new ChatWithUs();
            chatWithUs.ChatWithUsFunctionality();
        }
        [TestMethod]
        public void SortingFunctionalityTestCase()
        {
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            SortingFunctionality sortingFunctionality = new SortingFunctionality();
            sortingFunctionality.SortingFunction();
        }
        [TestMethod]
        public void FindOurStoreFunctionalityTestCase()
        {
            BaseClass.BrowserImplemented("edge");
            BaseClass.OpenUrl("https://uniworthshop.com");
            FindOurStore findStore = new FindOurStore();
            findStore.findStore();
        }
    }
}


















