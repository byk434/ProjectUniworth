using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

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
            dirpath = @"C:\Users\Hp\Source\Repos\ProjectUniworth\ProjectUniworth\ExtentReports" + testcase + ".html";
            ExtentV3HtmlReporter htmlReporter = new ExtentV3HtmlReporter(dirpath);
            //ExtentHtmlReporter html = ExtentHtmlReporter(dirpath);
            htmlReporter.Config.Theme = Theme.Dark;
            extentReports.AttachReporter(htmlReporter);
        }
    }
}
