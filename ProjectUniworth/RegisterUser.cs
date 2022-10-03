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
        By newsletter = By.XPath("(//button[@class='close'])[4]");
        By userButton = By.XPath("//span[@class='ti-user']");
        By createAnAccountButton = By.XPath("//a[@class = 'register']");
        By customerFullName = By.Id("CustomerName");
        By customerEmailAddress = By.Id("CustomerEmail");
        By mobileNo = By.Id("mobile_no");
        By enterPassword = By.XPath("(//input[@type='password'])[2]");
        By confirmPassword = By.XPath("(//input[@type='password'])[3]");
        By registerButton = By.XPath("//input[@value='Register']");
        public void RegisterData(string fullName, string emailAddress, string mobileN, string password, string passwordConfirm)
        {
            Click(newsletter);
            Click(userButton);
            Click(createAnAccountButton);
            Write(customerFullName, fullName);
            Write(customerEmailAddress, emailAddress);
            Write(mobileNo, mobileN);
            Write(enterPassword, password);
            Write(confirmPassword, passwordConfirm);
            Click(registerButton);
        }


    }

}






