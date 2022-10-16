using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using log4net.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SikuliModule;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Serialization;

namespace ProjectUniworth
{
    public class BaseClass
    {
        public static IWebDriver driver;


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
                edgeOption.AddArguments("-inprivate");
                edgeOption.AddArguments("disable-popup-blocking");
                //edgeOption.AddArguments("headless");
                driver = new EdgeDriver(edgeOption);
            }
            else if (browser == "firefox")
            {
                FirefoxOptions firefoxOption = new FirefoxOptions();
                firefoxOption.AddArguments("start-maximized");
                firefoxOption.AddArguments("newprivate");
                firefoxOption.AddArguments("disable-popup-blocking");
                driver = new FirefoxDriver(firefoxOption);
            }
            return driver;
        }
        
        public void Write(By by, string value)
        {
            try
            {
                driver.FindElement(by).SendKeys(value);
                TakeScreenshot(Status.Pass, "Enter Text");
            }
            catch 
            {

                TakeScreenshot(Status.Fail, "Entering Text Failed ");
            }
        }
        public void WriteEnter(By by, string value)
        { try
            {
                driver.FindElement(by).SendKeys(value + Keys.Enter);
                TakeScreenshot(Status.Pass, "Enter Text");
            }
            catch 
            {
                TakeScreenshot(Status.Fail, "Entering Text Failed ");
            }

        }
        public void WriteTab(By by, string value)
        {
            driver.FindElement(by).SendKeys(value + Keys.Tab);
        }
        public void Click(By by)
        {
            try
            {
                driver.FindElement(by).Click();
                TakeScreenshot("Click Element");
            }
            catch (Exception)
            {
                TakeScreenshot(Status.Fail, "Element not Clicked");
            }
        }
        public static void TakeScreenshot(string stepDetail)
        {
            string path = @"C:\Users\Hp\Source\Repos\ProjectUniworth\ProjectUniworth\ExtentReports\ExtentReports" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            ExtentReport.exChildTest.Log(Status.Pass, stepDetail, MediaEntityBuilder.CreateScreenCaptureFromPath(path + ".png").Build());
        }
        public static void TakeScreenshot(Status status, string stepDetail)
        {
            string path = @"C:\Users\Hp\Source\Repos\ProjectUniworth\ProjectUniworth\ExtentReports\ExtentReports" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            ExtentReport.exChildTest.Log(status, stepDetail, MediaEntityBuilder.CreateScreenCaptureFromPath(path + ".png").Build());
        }
        public IWebElement WaitforElement(By by, int timeToReadyElement = 0)
        {
            IWebElement element = null;
            try
            {
                if (timeToReadyElement != 0 && timeToReadyElement.ToString() != null)
                {
                    Wait(timeToReadyElement * 1000);
                }
                element = driver.FindElement(by);
            }
            catch
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                wait.Until(driver => IsPageReady(driver) == true && IsElementVisible(by) == true && IsClickable(by) == true);
                element = driver.FindElement(by);
            }
            return element;
        }
        private bool IsElementVisible(By by)
        {
            if (driver.FindElement(by).Displayed || driver.FindElement(by).Enabled)
            {
                return true;
            }
            else
            { return false; }
        }
        public bool IsClickable(By by)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void OpenUrl(string url)
        {
            driver.Url = url;
        }
        public bool IsPageReady(IWebDriver driver)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete");
        }
        public void Clear(By by)

        {
            driver.FindElement(by).Clear();
        }
        public static void Hover(By by)

        {
            Actions actions = new Actions(driver);

            actions.MoveToElement(driver.FindElement(by)).Perform();

        }
        public static void HoverClick(By by)

        {
            try
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(driver.FindElement(by)).Click().Perform();
                TakeScreenshot("Hover Click Element");
            }
            catch
            {
                TakeScreenshot(Status.Fail, "Failed to Hover Click");
            }

        }
        public static void Maximize()
        {
            driver.Manage().Window.Maximize();
        }
        public static void CloseBrowser()
        {
            driver.Close();
        }
        public static void QuitBrowser()
        {
            driver.Quit();
        }
        public static void DisposeBrowser()
        {
            driver.Dispose();
        }
        public void ReFreshPage()
        {
            driver.Navigate().Refresh();
        }
        public static void ImplicitWait(int value)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(value);
        }
        public IWebElement ExplicitWait(By by, int value)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(value));
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
        
        //public IWebElement FluentWait(By by, int value)
        //{
        //    FluentWait wait = new FluentWait(driver);
        //    WebDriverWait wait = new Web DriverWait(driver, TimeSpan.FromSeconds(value));
        //    return wait.Until(Driver IsPageReady(Driver) == true && ExpectedConditions.ElementIsVisible(by) == true && ExpectedConditions.IsClickable(by) == true);
        //}
        public void Wait(int milliSecs)
        {
            Thread.Sleep(milliSecs);
        }
        public static void ScrollToElement(By by)
        {
            var scrollToElement = driver.FindElement(by);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollToElement);
        }
        public static void Scroll()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy(0,200);");
        }
        public static void ScrollBy(int value, int value1)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy({0},{1};", value, value1);
        }
        public void ScrollPageDown()
        {
            IJavaScriptExecutor scroller = (IJavaScriptExecutor)driver;
            for (int i = 0; i < 1000; i++)
            {
                scroller.ExecuteScript("window.scrollBy(0," + i + ")", "");
            }
        }
        public void ScrollPageUp()
        {
            IJavaScriptExecutor scroller = (IJavaScriptExecutor)driver;
            scroller.ExecuteScript("window.scrollTo(0, document." + "head" + ".scrollHeight);");
        }
        public void ZoomFunction(int value)
        {
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            executor.ExecuteScript(string.Format("document.body.style.zoom='{0}%'", value));
        }
        public void WindowHandle(int value)
        {
            driver.SwitchTo().Window(driver.WindowHandles[value]);
        }
        public void SwitchFrame(By by)
        {
            driver.SwitchTo().Frame(driver.FindElement(by));
        }
        public void SwitchDefault()
        {
            driver.SwitchTo().DefaultContent();
        }
        public string GetText(By by)
        {

            IWebElement element = driver.FindElement(by);
            string str = element.GetAttribute("value");
            return str;
        }
        public static void AssertAreEqualMethod(By by, string expect)
        {
            string actualText = driver.FindElement(by).Text;
            Assert.AreEqual(expect, actualText);
        }
        public void DropDownItemMenu(By by, string value)
        {
            IWebElement drpDown = driver.FindElement(by);
            SelectElement dropDownMenu = new SelectElement(drpDown);
            try
            {
                dropDownMenu.SelectByValue(value);
            }
            catch
            {
                dropDownMenu.SelectByText(value);
            }
        }
        public void dropDownItemSelectByText(By by, string text)
        {
            IWebElement drpDown = driver.FindElement(by);
            SelectElement dropDownMenu = new SelectElement(drpDown);
            dropDownMenu.SelectByText(text);
        }

        public void GetElement(By by)
        {
            string text;
            try
            {
                text = driver.FindElement(by).Text;
                Console.WriteLine(text);
            }
            catch
            {
                try
                {
                    text = driver.FindElement(by).GetAttribute("value");
                    Console.WriteLine(text);
                }
                catch
                {
                    text = driver.FindElement(by).GetAttribute("innerHTML");
                    Console.WriteLine(text);
                }
            }
        }
        public string GetElementState(By by)
        {
            string elementState = driver.FindElement(by).GetAttribute("Disabled");
            if (elementState == null)
            {
                elementState = "enabled";
                Console.WriteLine("Enabled");
            }
            else if (elementState == "true")
            {
                elementState = "disabled";
                Console.WriteLine("Disabled");
            }
            return elementState;
        }
        public void AlertHandling()
        {
            driver.SwitchTo().Alert().Dismiss();
        }
    }
}











