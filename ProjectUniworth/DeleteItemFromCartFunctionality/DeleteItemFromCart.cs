using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectUniworth
{
    public class DeleteItemFromCart:BaseClass
    {
        By deleteButton = By.XPath("//a[@class='remove']");
        By itemAddorRemoveAlertText = By.XPath("//div[@class='alert alert-success']");

        public void deleteItem()
        {
            ExplicitWait(deleteButton, 10);
            Click(deleteButton);
            GetElement(itemAddorRemoveAlertText);
        }
    }
}
