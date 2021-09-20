using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ScreenPlay2.Bases;
using System;

namespace ScreenPlay2.Acciones
{
    public static class EsperarHasta
    {
        public static void ElementExist(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetInstance(), TimeSpan.FromMilliseconds(10000));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        }

        public static void ElementIsVisible(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetInstance(), TimeSpan.FromMilliseconds(10000));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public static void ElementIsClickeable(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetInstance(), TimeSpan.FromMilliseconds(10000));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }
        public static void AlertIsPresent(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetInstance(), TimeSpan.FromMilliseconds(10000));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
        }

        public static bool ElementsIsPresent(By locator)
        {
            var elements = Driver.GetInstance().FindElements(locator);
            return elements.Count >= 1;
        }
    }
}