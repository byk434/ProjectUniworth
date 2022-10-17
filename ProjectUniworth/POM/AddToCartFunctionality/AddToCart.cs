using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace ProjectUniworth
{
    public class AddToCart:BaseClass
    {
        
        
        //private static readonly log4net.ILog log =
        //log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        By productTile = By.XPath("(//div[@class='col-6 col-sm-6 col-md-4 col-lg-4 item'])[4]");
        By addToCartButton = By.XPath("(//i[@class='icon anm anm-cart-l'])[4]");
        By sizeOfItem = By.XPath("//label[@class='swatchLbl medium']");
        By addItemToCartButton = By.XPath("//button[@class='btn product-form__cart-submit']");
        By headerItemCartButton = By.XPath("//i[@class='icon anm anm-bag-l']");
        By continueButton = By.XPath("//button[@class='btn-button close-box bordered let-closeminibar-popup']");
        By cartDrawerText = By.XPath("//div[@id='cart-drawer']/h4");
        By itemAddorRemoveAlertText = By.XPath("//div[@class='alert alert-success']");
        By itemNotAvailable = By.XPath("//div[@class='alert alert-warning']");
        public void AddItemThroughButton()
        {
            ScrollBy(0, 500);
            //ScrollToElement(productTile);
            //log.Info("Scrolling to product tile");
            Hover(productTile);
            //log.Info("Hovering over product");
            Click(addToCartButton);
            
            //log.Info("Clicking on add to cart button");
            GetElementState(addToCartButton);
            //log.Info("Getting element text");
            Wait(5000);
            Click(headerItemCartButton);
            //log.Info("Clicking on Header Item Button");
            GetElement(cartDrawerText);
            //log.Info("Getting element text for verfication if product is in cart or not");
            
        }
        public void AddItemFromItemPage()
        {
            ScrollToElement(productTile);
            Click(productTile);
            Click(sizeOfItem);
            Click(addItemToCartButton);
            Click(continueButton);
            try
            {
                GetElement(itemNotAvailable);
            }
            catch
            {
                GetElement(itemAddorRemoveAlertText);
            }
           
            Click(headerItemCartButton);
            GetElement(cartDrawerText);
            
        }
    }
}
