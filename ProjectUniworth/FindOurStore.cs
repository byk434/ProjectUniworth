﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectUniworth
{
    internal class FindOurStore:BaseClass
    {
        By newsletter = By.XPath("(//button[@class='close'])[4]");
        By findOurStore = By.XPath("(//span[@class='newsletter__submit-text--large'])[3]"); //span[text()='find our Stores']
        By selectCity = By.XPath("//button[@data-target='#lahore123']");
        By getDirectionBahria = By.XPath("(//a[@href='https://www.google.com/maps/place/Uniworth+Dress+Co./@31.4667734,74.2650942,17z/data=!4m8!1m2!2m1!1sUniworth+Dress+Co.+(Shirt+and+Tie+Shop)+Emporium+Mall!3m4!1s0x0:0xa84c58e057246c0e!8m2!3d31.4669785!4d74.2661552'])[1]");


        public void findStore()
        {
            Click(newsletter);
            ScrollToElement(findOurStore);
            Click(findOurStore);
            Click(selectCity);
            Click(getDirectionBahria);
        }
    }
}
