using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectUniworth
{
    internal class ChatWithUs:BaseClass
    {
        By chatIcon = By.XPath("//a[@class='q8c6tt-0 hlANmy']");
        By chatIconWhatsApp = By.XPath("(//div[@class='q8c6tt-2 eiGYSu'])[2]");
        By continueToChatButton = By.XPath("//span[text()='Continue to Chat']");
        By useWhatsAppWebButton = By.XPath("//span[text()='use WhatsApp Web']");
        By textWA = By.XPath("//div[text()='To use WhatsApp on your computer:']");
        By waText = By.XPath("//div[@class='_2jR6Q']");
        By waWeb = By.XPath("//h5[text()='WHATSAPP WEB']");
        public void ChatWithUsFunctionality()
        {

            Hover(chatIcon);
            
            Click(chatIconWhatsApp);
            WindowHandle(1);
            GetElement(waWeb);
            Click(continueToChatButton);
            ExplicitWait(useWhatsAppWebButton, 5);
            Click(useWhatsAppWebButton);
            ExplicitWait(waText, 5);
            GetElement(waText);
            Wait(5000);
            WindowHandle(0);
        }

    }
}
