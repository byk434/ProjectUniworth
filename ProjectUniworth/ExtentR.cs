using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using log4net.Appender;
using OpenQA.Selenium;
using RazorEngine.Compilation.ImpromptuInterface;

namespace ProjectUniworth
{
    public class ExtentReport
    {

        public static ExtentReports extentReports;
        public static ExtentTest exParentTest;
        public static ExtentTest exChildTest;
        public static string dirpath;

        public static void LogReport(string testcase)
        {
            extentReports = new ExtentReports();
            
            dirpath = @"C:\Users\Hp\Source\Repos\ProjectUniworth\\ProjectUniworth\ExtentReports\" + testcase + ".html";
            
            ExtentV3HtmlReporter htmlReporter = new ExtentV3HtmlReporter(dirpath);
            //ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);
            
            //htmlReporter.ReporterName = "Babar Yaseen Khan";

            htmlReporter.Config.Theme = Theme.Standard;
            extentReports.AttachReporter(htmlReporter); 
        }
    }
}
