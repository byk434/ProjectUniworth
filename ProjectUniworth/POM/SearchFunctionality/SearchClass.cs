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
        By searchButton = By.XPath("(//i[@class='icon anm anm-search-l'])[2]"); //action search
        By searchBar = By.XPath("//input[@class='input-text']");
        By searchButton2 = By.XPath("//button[@class='action search']");
        By searchResultMsg = By.XPath("//h3[@class='search-result-heading']");
        By failedsearchResult = By.XPath("//h3[@style='text-align:center; padding:20px; color:#666 ']");
        By errorMessage = By.XPath("//h3[@style='text-align:center; padding:20px; ']");
        
        public void SearchFunction(string text)
        {

            Click(searchButton);
            ExplicitWait(searchBar, 10);
            Write(searchBar, text);
            HoverClick(searchButton2);
           

            //try
            //{
            //    GetElement(searchResultMsg);
            //}
            //catch
            //{
                
            //    GetElement(failedsearchResult);
            //    GetElement(errorMessage);
            //}
        }
        public void messages()
        {
            try
            {
                GetElement(searchResultMsg);
            }
            catch
            {

                GetElement(failedsearchResult);
                GetElement(errorMessage);
            }
        }
    }
}
