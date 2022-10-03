using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectUniworth
{
    public class SearchClass:BaseClass
    {
        By newsletter = By.XPath("(//button[@class='close'])[4]");
        By searchButton = By.XPath("(//i[@class='icon anm anm-search-l'])[2]"); //action search
        By searchBar = By.XPath("//input[@class='input-text']");
        By searchButton2 = By.XPath("//button[@class='action search']");

        public void SearchBar(string text)
        {
            Click(newsletter);
            Click(searchButton);
            //Click(searchBar);
            Write(searchBar, text);
            //Click(searchButton2);
        }
        public void SearchFunction(string text)
        {
            Click(newsletter);
            Click(searchButton);
            Write(searchBar, text);
            Click(searchButton2);
        }
    }
}
