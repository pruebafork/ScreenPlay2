using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using ScreenPlay2.Bases;
using System;
using System.IO;
using System.Net;
using System.Web.Configuration;

namespace ScreenPlay2.Reportes
{
    public class Reporte : IReporte
    {
        public ExtentReports extent;
        public ExtentTest test;
        private string testName;

        public void StartTest()
        {
            DateTime time = DateTime.Now;
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPah = new Uri(actualPath).LocalPath;
            var browser = WebConfigurationManager.AppSettings["browser"].ToString();
            var idUser = WebConfigurationManager.AppSettings["idUser"].ToString();
            this.testName = TestContext.CurrentContext.Test.Name;
            //String fileNameHtml = testName + time.ToString("h_mm_ss") + idUser + ".html";
            String fileNameHtml = testName + "-" + time.Day + "-" + time.Month + "-" + time.Year + "--" + time.Hour + "-" + time.Minute  + "-" +time.Millisecond + idUser + ".html";
            string reportPath = projectPah + "Reports\\" + fileNameHtml;
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            string hostName = Dns.GetHostName();
            OperatingSystem os = Environment.OSVersion;
            extent.AddSystemInfo("Operating System", os.ToString());
            extent.AddSystemInfo("Host Name", hostName);
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("UserName", "TestUser -" + idUser);
            extent.AddSystemInfo("Team", "Automated Testing");
            extent.AddSystemInfo("Browser", browser);
            htmlReporter.Configuration().Theme = Theme.Dark;
            htmlReporter.Configuration().DocumentTitle = "QA Testing Automated";
            htmlReporter.Configuration().ReportName = "Report Testing Automated";
        }

        public void EndTest2()
        {
            extent.Flush();
        }

        public string Capture(IWebDriver driver, String screenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            var pth = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;

            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string reportPath = new Uri(actualPath).LocalPath;
            Directory.CreateDirectory(reportPath + "Reports\\" + "Screenshots");
            var finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "Reports\\Screenshots\\" + screenShotName;
            var localpath = new Uri(finalpth).LocalPath;
            screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);
            return localpath;
        }

        public void addLogScreenCapture(Status status, string text)
        {
            try
            {
                DateTime time = DateTime.Now;
                String fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";
                String screenShotPath = Capture(Driver.GetInstance(), fileName);
                test.Log(status, text, MediaEntityBuilder.CreateScreenCaptureFromPath(screenShotPath).Build());
            }
            catch (Exception)
            {
                test.Log(Status.Info, "Screenshot: No se pudo tomar la captura de pantalla");
            }
        }
    }
}
