using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectUniworth
{
    internal class SortingFunctionality:BaseClass
    {
        By newsletter = By.XPath("(//button[@class='close'])[4]");
        By navigationBarShirts = By.XPath("(//a[@class='dropdown-toggle menu-ib-parent main-men-line-ib'])[2]");
        By defaultSorting = By.XPath("//select[@id='price_sort']");
        By priceHighToLow = By.XPath("//option[contains(text(),'Price High to Low')]");
        public void SortingFunction()
        {
            Click(newsletter);
            HoverClick(navigationBarShirts);
            Click(defaultSorting);
            Click(priceHighToLow);
        }
    }
}
