using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectUniworth
{
    public class ProceedToCheckout:BaseClass
    {
        By proceedToCheckoutButton = By.XPath("//a[@class='btn proceed-to-checkout']");
        By nameOfGuestUser = By.XPath("//input[@id='billing_name']");
        By regAsNewUserButtton = By.XPath("//input[@id='reg']");
        By emailoOfGuestUser = By.XPath("//input[@id='billing_email']");
        By phoneOfGuestUser = By.XPath("//input[@id='billing_phone']");
        By text = By.XPath("//input[@class='select2-search__field']");
        By selectCountry = By.XPath("//span[@aria-labelledby='select2-billing_country-container']");
        By selectState = By.XPath("(//span[@title='Select State'])[1]");
        By selectCity = By.XPath("//span[@id='select2-city-container']");
        By zipCode = By.XPath("//input[@id='billing_postal_code']");
        By billingAdress = By.XPath("//input[@id='billing_address1']");
        By billingAdress2 = By.XPath("//input[@id='billing_address2']");
        By selectPaymentMethod = By.XPath("//input[@id='bank']");
        //By submitButton = By.XPath("//button[text()='Place Order']");
        By submitButton = By.XPath("//button[@class='btn btn-large btn--lg w-100 shop_colorchange']");
        By thankYouMsg = By.XPath("//h1[text()='Thank you for your purchase!']");
        By registerAsNewUser = By.XPath("//input[@id='reg']");
        By enterPass1 = By.XPath("(//input[@type='password'])[2]");
        By enterPass2 = By.XPath("(//input[@type='password'])[3]");
        By existingUser = By.XPath("//a[@href='#customer-login']");
        By userEmail = By.XPath("//input[@type='email']");
        By userPassword = By.XPath("(//input[@type='password'])[1]");
        By loginUser = By.XPath("//button[@class='btn btn-primary mt-3']");
        By alertMsg = By.XPath("//div[@class='alert alert-success']");
        By errorMsgAlreadyExisting = By.XPath("//div[@class='alert alert-danger']");
        public void ProceedToCO()
        {
            Click(proceedToCheckoutButton);
        }
        public void ExistingUser(string emailAddress, string password, string city, string add1)
        {
            Click(existingUser);
            Write(userEmail, emailAddress);
            Write(userPassword, password);
            Click(loginUser);
            GetElement(alertMsg);
            ScrollToElement(selectCity);
            Click(selectCity);
            WriteEnter(text, city);
            Write(billingAdress, add1);
            ExplicitWait(selectPaymentMethod, 20);
            ScrollPageUp();
            HoverClick(selectPaymentMethod);
            Click(submitButton);
            ExplicitWait(thankYouMsg, 10);
            GetElement(thankYouMsg);
        }
        public void AsGuest(string name, string email, string phone, string country, string state, string city, string codeZip, string pass1, string pass2, string add1, string add2)
        {
            Write(nameOfGuestUser, name);
            Write(emailoOfGuestUser, email);
            Write(phoneOfGuestUser, phone);
            ScrollToElement(selectCountry);
            Click(selectCountry);
            WriteEnter(text, country);
            Click(selectState);
            WriteEnter(text, state);
            Click(selectCity);
            WriteEnter(text, city);
            Write(zipCode, codeZip);
            try
            {
                Write(enterPass1, pass1);
                Write(enterPass2, pass2);
            }
            catch
            {
                return;
                //Write(billingAdress, add1);
                //Write(billingAdress2, add2);
                //ScrollPageUp();
                //HoverClick(selectPaymentMethod);
                //Click(submitButton);
                //GetElement(thankYouMsg);
            }
            Write(billingAdress, add1);
            Write(billingAdress2, add2);
            ScrollPageUp();
            ExplicitWait(selectPaymentMethod, 20);
            HoverClick(selectPaymentMethod);
            Click(submitButton);
            try
            {
                ExplicitWait(errorMsgAlreadyExisting, 10);
                GetElement(errorMsgAlreadyExisting);
            }
            catch
            {
                ExplicitWait(thankYouMsg, 10);
                GetElement(thankYouMsg);
            }
        }
        public void RegisterNewUser()
        {
            HoverClick(registerAsNewUser);
        }
    }
}
