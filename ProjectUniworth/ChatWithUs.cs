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
        By newsletter = By.XPath("(//button[@class='close'])[4]");
        By chatIcon = By.XPath("//a[@class='q8c6tt-0 hlANmy']");
        By chatIconWhatsApp = By.XPath("(//div[@class='q8c6tt-2 eiGYSu'])[2]");
        By continueToChatButton = By.XPath("//span[text()='Continue to Chat']");
        By useWhatsAppWebButton = By.XPath("//span[text()='use WhatsApp Web']");

        public void ChatWithUsFunctionality()
        {
            Click(newsletter);
            Hover(chatIcon);
            Click(chatIconWhatsApp);
            ImplicitWait(5);
            Click(continueToChatButton);
            Click(useWhatsAppWebButton);
        }
        public void WA()
        {
            Click(continueToChatButton);
            Click(useWhatsAppWebButton);
        }
    }
}
