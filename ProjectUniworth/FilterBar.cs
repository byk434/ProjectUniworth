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
        By newsletter = By.XPath("(//button[@class='close'])[4]");
        By navigationBarShirts = By.XPath("(//a[@class='dropdown-toggle menu-ib-parent main-men-line-ib'])[2]");
        By colorFilter = By.XPath("(//h2[@class='filter-name-ib'])[6]");
        By selectedColor = By.XPath("//input[@value='Pista Green']");
        public void FilterBarFunction()
        {
            Click(newsletter);
            HoverClick(navigationBarShirts);
            Click(colorFilter);
            Click(selectedColor);
            
        }
    }
}
