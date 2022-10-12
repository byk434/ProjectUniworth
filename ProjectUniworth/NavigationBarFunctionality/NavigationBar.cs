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


        public void NavigationBarFunction()
        {
            Hover(navigationBar);
        }
    }
}
