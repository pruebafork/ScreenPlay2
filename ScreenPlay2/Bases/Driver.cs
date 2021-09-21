using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using ScreenPlay2.Registros;
using System;

namespace ScreenPlay2.Bases
{
    public static class Driver
    {
        public static IWebDriver driver { get; set; }
        private static int indice = 1;
        public static int Indice { get => indice; set => indice = value; }
        public static IWebDriver GetInstance()
        {
            return driver;
        }

        public static void SetInstance(IWebDriver value)
        {
            driver = value;
        }
        public static void SetTimeoutSeconds(int value)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(value);
        }

        public static void ChangeNewTab()
        {
            var listtabs = driver.WindowHandles;
            if (listtabs.Count > 1)
            {
                driver.SwitchTo().Window(listtabs[1]);
            }
        }

        public static void Init(string navegador)
        {
            switch (navegador)
            {
                case "Chrome":
                    ChromeOptions google = new ChromeOptions();
                    google.AddArgument("--no-sandbox");
                    google.AddArgument("--disable-infobars");
                    google.AddArgument("--start-maximized");
                    Driver.SetInstance(new ChromeDriver(google));
                    break;
                case "Firefox":
                    FirefoxDriver fire = new FirefoxDriver();
                    //fire.AddArgument("--no-sandbox");
                    //fire.AddArgument("--disable-infobars");
                    //fire.AddArgument("--start-maximized");
                    Driver.SetInstance(new FirefoxDriver());
                    break;
            }
        }

        public static void TaskPrint()
        {
            try
            {
                TestContext.AddTestAttachment(TakeFullScreenshot(), TestContext.CurrentContext.Test.Name);
            }
            catch (Exception)
            {
                Console.WriteLine("Hubo un problema en la captura");
            }
        }

        public static string TakeFullScreenshot()
        {
            string fileName = System.IO.Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                $@"{XLog.FolderLog}\" +
                string.Format(Indice + "-" +
                            TestContext.CurrentContext.Test.Name +
                            "-" +
                            "{0}.jpg", Guid.NewGuid().ToString()));
            Screenshot screenshot = ((ITakesScreenshot)Driver.GetInstance()).GetScreenshot();
            screenshot.SaveAsFile(fileName, ScreenshotImageFormat.Jpeg);
            indice++;
            return fileName;
        }

        public static string TestName()
        {
            return TestContext.CurrentContext.Test.Name;
        }

        public static void TestImg(string dir)
        {
            try
            {
                TestContext.AddTestAttachment(dir, TestName());
            }
            catch (Exception)
            {
                Console.WriteLine("Hubo un inconveniente en la captura");
            }
        }
    }
}