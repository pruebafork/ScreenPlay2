using OpenQA.Selenium;
using ScreenPlay2.Bases;

namespace ScreenPlay2.Acciones
{
    public static class Elemento
    {
        public static IWebElement On(By locator)
        {
            EsperarHasta.ElementExist(locator);
            return Driver.GetInstance().FindElement(locator);
        }

        public static IWebElement On(IWebElement element, By locator)
        {
            return element.FindElement(locator);
        }

        public static void Frame(By locator)
        {
            Driver.GetInstance().SwitchTo().Frame(Elemento.On(locator));
        }

        public static void SwitchToFrame()
        {
            Driver.GetInstance().SwitchTo().DefaultContent();
        }
    }
}
