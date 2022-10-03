using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectUniworth
{
    public class NewsletterSubscription:BaseClass
    {
        By phoneNumber = By.XPath("//input[@id='phone']");
        By emailAddress = By.XPath("//input[@id='email']");
        By submitButton = By.XPath("//button[text()='Submit']");

        public void SubscribeNewsletter(string phoneN, string emailA)
        {
            Write(phoneNumber, phoneN);
            Write(emailAddress, emailA);
            Click(submitButton);
        }
    }
}
