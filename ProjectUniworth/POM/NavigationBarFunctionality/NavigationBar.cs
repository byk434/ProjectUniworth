using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectUniworth
{
    public class NavigationBar:BaseClass
    {
        By navigationBar = By.XPath("//ul[@class='nav navbar-nav navbar-nav-ib menu-main-ib']");
        By navigationBarShirts = By.XPath("(//a[@class='dropdown-toggle menu-ib-parent main-men-line-ib'])[2]");

        public void NavigationBarFunction()
        {
            Hover(navigationBar);
        }
        public void NavBarSelectShirt()
        {
            Click(navigationBarShirts);
        }
    }
}
