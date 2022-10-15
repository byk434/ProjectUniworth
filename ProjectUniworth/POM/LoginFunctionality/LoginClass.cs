using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V104.DOM;
using OpenQA.Selenium.DevTools.V104.Network;

namespace ProjectUniworth
{
    public  class LoginClass:BaseClass
    {

        By userButton = By.XPath("//span[@class='ti-user']");
        By loginButton = By.XPath("//a[@class='btn']");
        By emailAddress = By.XPath("//input[@name='email_address']");
        By enterPassword = By.XPath("(//input[@name='password'])[1]");
        By submitButton = By.XPath("//input[@value='Sign In']");
        //By welcomeText = By.XPath("//*[@id='settingsBox']/div/p[1]/b");
        By welcomeText = By.XPath("(//p[@class='text-center'])[1]");
        By errorText = By.XPath("//div[@class='alert alert-danger']");

        public  void LoginData(string email1, string pass1)
        {
            Click(userButton);
            ExplicitWait(loginButton, 10);
            Click(loginButton);
            Write(emailAddress, email1);
            Write(enterPassword, pass1);
            Click(submitButton);
            
            try 
            {
                GetElement(errorText);
            }
            catch
            {
                Click(userButton);
                GetElement(welcomeText);
            }

            //Clear(emailAddress);
        }
        //public void LoginSuccessful()
        //{
        //    Click(userButton);
        //    ExplicitWait(welcomeText, 10);
        //    GetElement(welcomeText);
        //}
        //public void LoginError()
        //{
        //    GetElement(errorText);
        //}
    }
}