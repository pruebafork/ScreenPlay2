using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using ScreenPlay2.Bases;

namespace ScreenPlay2.Acciones
{
    public static class MoverHacia
    {
        public static void On(By locator)
        {
            IWebElement button = Driver.GetInstance().FindElement(locator);
            Actions action = new Actions(Driver.GetInstance());
            action.MoveToElement(button).Perform();
        }
    }
}
