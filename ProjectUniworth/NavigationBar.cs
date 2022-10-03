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
        By newsletter = By.XPath("(//button[@class='close'])[4]");
        By navigationBarShirts = By.XPath("(//a[@class='dropdown-toggle menu-ib-parent main-men-line-ib'])[2]");

        public void NavigationBarFunction()
        {
            Click(newsletter);
            HoverClick(navigationBarShirts);
            //Click(navigationBarShirts);
        }
    }
}
