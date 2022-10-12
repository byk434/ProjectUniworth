using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectUniworth
{ 
    public class RegisterUser:BaseClass
    {
        By userButton = By.XPath("//span[@class='ti-user']");
        By createAnAccountButton = By.XPath("//a[@class = 'register']");
        By customerFullName = By.Id("CustomerName");
        By customerEmailAddress = By.Id("CustomerEmail");
        By mobileNo = By.Id("mobile_no");
        By enterPassword = By.XPath("(//input[@type='password'])[2]");
        By confirmPassword = By.XPath("(//input[@type='password'])[3]");
        By registerButton = By.XPath("//input[@value='Register']");
        By errorMsg = By.XPath("//span[text()='  The confirm password and password must match.']");
        By successRegi = By.XPath("//b[text()='Success!  ']");
        //b[text()="Success!  "]//parent::div
        ////div[@class="alert alert-success"]//child::b
        public void RegisterData(string fullName, string emailAddress, string mobileN, string password, string passwordConfirm)
        {
            Click(userButton);
            ExplicitWait(createAnAccountButton, 5);
            Click(createAnAccountButton);
            Write(customerFullName, fullName);
            Write(customerEmailAddress, emailAddress);
            Write(mobileNo, mobileN);
            Write(enterPassword, password);
            Write(confirmPassword, passwordConfirm);
            Click(registerButton);
            try
            {
                GetElement(errorMsg);
            }
            catch
            {
                GetElement(successRegi);
            }
        }


    }

}






