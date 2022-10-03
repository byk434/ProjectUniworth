using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SikuliModule;

namespace ProjectUniworth
{
    public class BaseClass
    {
        public static IWebDriver driver;
        private static object wait;

        public static object ExpectedConditions { get; private set; }

        public static IWebDriver BrowserImplemented(string browser)

        {
          
            if (browser == "chrome")
            {
                ChromeOptions chromeOption = new ChromeOptions();
                chromeOption.AddArguments("start-maximized");
                chromeOption.AddArguments("incognito");
                chromeOption.AddArguments("disable-popup-blocking");
                //chromeOption.AddArguments("headless");
                driver = new ChromeDriver(chromeOption);


                //driver = new ChromeDriver(chromeOption);
            }
            else if (browser == "edge")
            {
                EdgeOptions edgeOption = new EdgeOptions();
                edgeOption.AddArguments("start-maximized");
                edgeOption.AddArguments("incognito");
                driver = new EdgeDriver();
            }
            else if (browser == "firefox")
            {
                driver = new FirefoxDriver();
            }
            return driver;
        }
        public void Write(By by, string value)
        {
            driver.FindElement(by).SendKeys(value);
        }
        public static void Click(By by)
        {
            driver.FindElement(by).Click();
        }
        public static void OpenUrl(string url)
        {
            driver.Url = url;
        }
        public void Clear(By by)

        {
            driver.FindElement(by).Clear();
        }
        public static void Hover(By by)

        {
            Actions actions = new Actions(driver);
            //actions.MoveToElement(driver.FindElement(by));
            actions.MoveToElement(driver.FindElement(by)).Perform();
        }
        public static void HoverClick(By by)

        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(by)).Perform();
            actions.MoveToElement(driver.FindElement(by)).Click();
        }
        public static void Maximize()
        {
            driver.Manage().Window.Maximize();
        }
        public static void ImplicitWait(int value)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(value);
        }
        //public static void ExplicitWait(By by, int value)
        //{
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(value));
        //    wait.Until(driver => IsElementVisible(By.XPath("//button[@class='close'])[4]")));
        //}

        //private static void IsElementVisible(By by)
        //{
        //    throw new NotImplementedException();
        //}
        public static void Scroll(By by)
        { 
            var scrollToElement = driver.FindElement(by);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollToElement);
            //driver.FindElement(by);
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", by);
        }

    }
}
