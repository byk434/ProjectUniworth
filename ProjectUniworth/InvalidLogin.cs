using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectUniworth
{
    public class InvalidLogin:BaseClass
    {
        By newsletter = By.XPath("(//button[@class='close'])[4]");
        By userButton = By.XPath("//span[@class='ti-user']");

        By loginButton = By.XPath("//a[@class='btn']");
        By emailAddress = By.XPath("//input[@name='email_address']");
        By enterPassword = By.XPath("(//input[@name='password'])[1]");
        By submitButton = By.XPath("//input[@value='Sign In']");

        public void InvalidLoginData(string email1, string pass1)
        {
            Click(newsletter);
            Click(userButton);
            Click(loginButton);
            Write(emailAddress, email1);
            Write(enterPassword, pass1);
            Click(submitButton);
        }
    }
}
