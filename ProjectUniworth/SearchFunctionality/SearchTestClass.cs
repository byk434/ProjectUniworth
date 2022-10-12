using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace ProjectUniworth
{
    [TestClass]
    public class SearchTestClass: BaseClass
    {
        [TestMethod]
        public void SearchWithEmptySearchBarTest()
        {
            BrowserImplemented("chrome");
            OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            SearchClass emptySearch = new SearchClass();
            emptySearch.SearchFunction("");
            
        }
        [TestMethod]
        public void SearchWithValidDataTest()
        {
            BrowserImplemented("chrome");
            OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            SearchClass validSearch = new SearchClass();
            validSearch.SearchFunction("shirts");
            validSearch.messages();
            
        }
        [TestMethod]
        public void SearchWithInvalidDataTest()
        {
            BrowserImplemented("edge");
            OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            SearchClass invalidSearch = new SearchClass();
            invalidSearch.SearchFunction("mobile");
            invalidSearch.messages();
        }
    }
}
