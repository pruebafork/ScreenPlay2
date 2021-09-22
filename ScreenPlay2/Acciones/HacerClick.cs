using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using ScreenPlay2.Bases;
using ScreenPlay2.Reportes;
using System;

namespace ScreenPlay2.Acciones
{
    public static class HacerClick
    {
        public static void Click(By locator, Reporte report, string buttonName)
        {
            try
            {
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                var element = Driver.driver.FindElement(locator);
                var action = new Actions(Driver.driver);
                action.MoveToElement(element).Build().Perform();
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                PintarDespintar.HighLighterMethod(Driver.GetInstance(), locator);
                report.addLogScreenCapture(Status.Pass, $"Se hizo click en el boton'{buttonName}'");
                element.Click();
                PintarDespintar.HighLighterMethodOff(Driver.GetInstance(), locator);
            }
            catch (Exception ex)
            {
                report.addLogScreenCapture(Status.Fail, $"No fue posible hacer click en '{buttonName}'");
                throw ex;
            }
        }

       

        public static void DobleClick(By locator, Reporte report, string buttonName)
        {
            try
            {
                EsperarHasta.ElementIsClickeable(locator);
                var element = Elemento.On(locator);
                var action = new Actions(Driver.driver);
                action.MoveToElement(element).Build().Perform();
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                var perform = action.DoubleClick(element).Build();
                Esperar.Time1();
                report.addLogScreenCapture(Status.Pass, $"Se hizo click en '{buttonName}'");
            }
            catch (Exception ex)
            {
                report.addLogScreenCapture(Status.Fail, $"No fue posible hacer click en '{buttonName}'");
                throw ex;
            }
        }

        public static void ClickJS(By locator, Reporte report, string buttonName)
        {
            try
            {
                EsperarHasta.ElementIsClickeable(locator);
                var element = Driver.driver.FindElement(locator);
                var action = new Actions(Driver.driver);
                action.MoveToElement(element).Build().Perform();
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                PintarDespintar.HighLighterMethod(Driver.GetInstance(), locator);
                report.addLogScreenCapture(Status.Pass, $"Se hizo click en el boton'{buttonName}'");
                IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver.GetInstance();
                executor.ExecuteScript("arguments[0].click();", element);
                PintarDespintar.HighLighterMethodOff(Driver.GetInstance(), locator);
            }
            catch (Exception ex)
            {
                report.addLogScreenCapture(Status.Fail, $"No fue posible hacer click en '{buttonName}'");
                throw ex;
            }
        }
    }
}