using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectUniworth
{
    [TestClass]
    public class SortingTestClass:BaseClass
    {
        [TestMethod]
        public void SortingFunctionalityTestCase()
        {
            BrowserImplemented("edge");
            OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            NavigationBar navBar = new NavigationBar();
            navBar.NavigationBarFunction();
            SortingItems sortingFunctionality = new SortingItems();
            sortingFunctionality.SortingFunction();
        }
    }
}
