using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectUniworth
{
    internal class FilterBar : BaseClass
    {
        By navigationBarShirts = By.XPath("(//a[@class='dropdown-toggle menu-ib-parent main-men-line-ib'])[2]");
        By colorFilter = By.XPath("(//h2[@class='filter-name-ib'])[6]");
        //By colorFilter = By.XPath("//h2[text()='Color']");
        By selectedColor = By.XPath("//input[@value='Pista Green']");
        By selectedItemColor = By.XPath("//a[text()='Self pista green tailored smart fit shirt']");
        public void FilterBarFunction()
        {
            Click(navigationBarShirts);            
            Click(colorFilter);
            HoverClick(selectedColor);
            ExplicitWait(selectedItemColor, 10);
            GetElement(selectedItemColor);
        }
    }
}
