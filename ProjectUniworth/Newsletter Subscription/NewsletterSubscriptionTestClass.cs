using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectUniworth
{
    [TestClass]

    public class NewsletterSubscriptionTestClass:BaseClass
    {
        [TestMethod]
        public void SubscribeToNewsletterValidDataTest()
        {
            BrowserImplemented("chrome");
            OpenUrl("https://uniworthshop.com");
            Newsletter subValidData = new Newsletter();
            subValidData.SubscribeNewsletter("03004545424", "aqsa.aqua@gmail.com");
        }
        [TestMethod]

        public void ScubscribeToNewsletterWithInvalidDataTest()
        {
            BrowserImplemented("chrome");
            OpenUrl("https://uniworthshop.com");
            Newsletter subInvalidData = new Newsletter();
            subInvalidData.SubscribeNewsletter("030021049606", "bykisrgmail.com");
            
        }
    }
}
