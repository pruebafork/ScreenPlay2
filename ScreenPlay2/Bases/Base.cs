using NUnit.Framework;
using ScreenPlay2.Reportes;
using System;
using System.Web.Configuration;

namespace ScreenPlay2.Bases
{
    public class Base : Reporte
    {
        public string browser;
        public string URL;
        public string idUser;
        public string passUser;
        public static Reporte report = new Reporte();
        public int count = 0;
        private string testName;
        private string downloadPath;


        [SetUp]
        public void SetUpBase()
        {
            browser = WebConfigurationManager.AppSettings["browser"].ToString();
            URL = WebConfigurationManager.AppSettings["URL"].ToString();
            Driver.Init(browser);
            Driver.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(240);
            Driver.driver.Manage().Window.Maximize();
            if (count == 0)
            {
                report.StartTest();
            }
            Driver.driver.Url = URL;
            this.testName = TestContext.CurrentContext.Test.Name;
            this.downloadPath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads";
            report.test = report.extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void TearDownBase()
        {
            String statusFinal;
            var currentContext = TestContext.CurrentContext;
            var testName = currentContext.Test.Name;
            statusFinal = currentContext.Result.Outcome.Status.ToString().Equals("Passed") ? "CORRECTA." : "ERRONEA.";

            if (statusFinal.Equals("ERRONEA."))
            {
                Driver.TaskPrint();
            }
            Driver.driver.Quit();
            Driver.driver.Dispose();
        }
    }
}
