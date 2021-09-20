using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ScreenPlay2.Bases;
using System;
using System.Threading;

namespace ScreenPlay2.Acciones
{
    public static class EsperarHasta
    {
        public static void ElementExist(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetInstance(), TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        }

        public static void ElementIsVisible(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetInstance(), TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public static void ElementIsClickeable(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetInstance(), TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }
        public static void AlertIsPresent(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetInstance(), TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
        }

        public static bool ElementsIsPresent(By locator)
        {
            var elements = Driver.GetInstance().FindElements(locator);
            return elements.Count >= 1;
        }

        public static void Time5()
        {
            Thread.Sleep(5000);
        }

        public static void Time4()
        {
            Thread.Sleep(4000);
        }

        public static void Time3()
        {
            Thread.Sleep(3000);
        }

        public static void Time2()
        {
            Thread.Sleep(2000);
        }

        public static void Time1()
        {
            Thread.Sleep(1000);
        }

        public static void SetTime(int milisegundos)
        {
            Thread.Sleep(milisegundos);
        }
    }
}
