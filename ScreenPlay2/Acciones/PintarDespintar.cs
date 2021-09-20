using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace ScreenPlay2.Acciones
{
    public static class PintarDespintar
    {
        public static void HighLighterMethod(IWebDriver driver, By by)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                _ = js.ExecuteScript("arguments[0].setAttribute('style', 'border: 2px solid blue;');", driver.FindElement(by));
            }
            catch (Exception ex)
            {
                TestContext.Out.WriteLine("Existieron inconvenientes en el metodo: highLighterMethod de la clase: Helper, Ex:" + ex.Message);
            }
        }

        public static void HighLighterMethodOff(IWebDriver driver, By by)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                _ = js.ExecuteScript("arguments[0].setAttribute('style', 'border: 2px solid white;');", driver.FindElement(by));
            }
            catch (Exception ex)
            {
                TestContext.Out.WriteLine("Existieron inconvenientes en el metodo: highLighterMethod de la clase: Helper, Ex:" + ex.Message);
            }
        }
    }
}
