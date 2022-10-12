﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectUniworth
{

    public class Newsletter : BaseClass
    {

        By newsletter = By.XPath("(//button[@class='close'])[4]");
        By phoneNumber = By.XPath("//input[@id='phone']");
        By emailAddress = By.XPath("//input[@id='email']");
        By submitButton = By.XPath("//button[text()='Submit']");
        By alreadyExists = By.XPath("(//span[@class='error'])[2]");
        By thankYouText = By.XPath("//div[@class='swal-title']");

        //IRFAN
        By button = By.XPath("//button[@class='form-control jj-enter-btn']");
        By iFrame = By.XPath("//iframe[@title='webpush-onsite']");
        By allow = By.XPath("//button[@id='allow']");
        public void newsLetter()

        {
            Click(newsletter);
        }
        public void SubscribeNewsletter(string phoneN, string emailA)
        {

            Write(phoneNumber, phoneN);
            ExplicitWait(phoneNumber, 20);
            GetElement(phoneNumber);
            Write(emailAddress, emailA);

            Click(submitButton);

            try
            { GetElement(thankYouText); }
            catch
            { GetElement(alreadyExists); }
        }
        public void junJ()
        {
            SwitchFrame(iFrame);
            Click(allow);
            Click(button);
        }
    }
}
