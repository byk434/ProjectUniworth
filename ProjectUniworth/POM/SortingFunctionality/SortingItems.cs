using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectUniworth
{
    public class SortingItems:BaseClass
    {
        By navigationBarShirts = By.XPath("(//a[@class='dropdown-toggle menu-ib-parent main-men-line-ib'])[2]");
        By defaultSorting = By.XPath("//select[@id='price_sort']");
        By sortingText = By.XPath("//option[@value='https://uniworthshop.com/shirts?price_sort=newest-product']");
        public void SortingFunction()
        {
            Click(navigationBarShirts);
            //dropDownItemMenu(defaultSorting, "https://uniworthshop.com/shirts?price_sort=high-to-low");
            DropDownItemMenu(defaultSorting, "Newest products");
            //GetElement(defaultSorting);
            GetElement(sortingText);
        }
    }
}
