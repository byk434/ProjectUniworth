using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectUniworth
{
    [TestClass]
    public class ChatWithUsTestClass:BaseClass
    {
        [TestMethod]
        public void ChatWithUsFunctionalityTestCase()
        {
            BrowserImplemented("edge");
            OpenUrl("https://uniworthshop.com");
            Newsletter newsletter = new Newsletter();
            newsletter.newsLetter();
            ChatWithUs chatWithUs = new ChatWithUs();
            chatWithUs.ChatWithUsFunctionality();
        }
    }
}
