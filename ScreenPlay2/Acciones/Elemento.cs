using OpenQA.Selenium;
using ScreenPlay2.Bases;

namespace ScreenPlay2.Acciones
{
    public static class Elemento
    {
        public static IWebElement On(By locator)
        {
            //EsperarHasta.ElementExist(locator);
            return Driver.GetInstance().FindElement(locator);
        }

        public static IWebElement On(IWebElement element, By locator)
        {
            return element.FindElement(locator);
        }
    }
}