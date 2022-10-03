using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectUniworth
{
    public class AddToCart:BaseClass
    {
        By newsletter = By.XPath("(//button[@class='close'])[4]");
        By searchButton = By.XPath("(//i[@class='icon anm anm-search-l'])[2]"); //action search
        By searchBar = By.XPath("//input[@class='input-text']");
        By searchButton2 = By.XPath("//button[@class='action search']");
        By productTile = By.XPath("(//div[@class='col-6 col-sm-6 col-md-4 col-lg-4 item'])[3]");
        By addToCartButton = By.XPath("(//i[@class='icon anm anm-cart-l'])[3]");
        By sizeOfItem = By.XPath("//label[@class='swatchLbl medium']");
        By addItemToCartButton = By.XPath("//button[@class='btn product-form__cart-submit']");
        By headerItemCartButton = By.XPath("//i[@class='icon anm anm-bag-l']");
        By continueButton = By.XPath("//button[@class='btn-button close-box bordered let-closeminibar-popup']");
       
        
        By men = By.XPath("//span[text()='Men']");
        By kameez = By.XPath("//span[text()='Caps']");

        By viewas = By.ClassName("modes");

        By list = By.XPath("(//a[@id='mode-list'])[1]");

        By grid = By.XPath("(//a[@id='mode-grid'])[1]");
        By country = By.Id("landing-currency");

        By country1 = By.XPath("//option[@value='PKR']");

        By enter = By.XPath("//button[@class='form-control jj-enter-btn']");


        public void AddItemThroughButton(string text)
        {
            Click(newsletter);
            Click(searchButton);
            Write(searchBar, text);
            Click(searchButton2);
            Scroll(productTile);
            Hover(productTile);
            Click(addToCartButton);
            Click(headerItemCartButton);



            

        }
        public void AddItemFromItemPage(string text)
        {
            Click(newsletter);
            Click(searchButton);
            Write(searchBar, text);
            Click(searchButton2);
            Scroll(productTile);
            Click(productTile);
            Click(sizeOfItem);
            Click(addItemToCartButton);
            Click(continueButton);
            Click(headerItemCartButton);
        }

        public void View()
        {
            Click(country);
            Click(country1);
            Click(enter);
            Hover(men);
            Click(kameez);
            //Click(viewas);

            Click(list);

            //Thread.Sleep(3000);
            //Click(viewas);
            Click(grid);

        }
    }
}
