using AventStack.ExtentReports;
using OpenQA.Selenium;
using ScreenPlay2.Bases;
using ScreenPlay2.Reportes;
using System;

namespace ScreenPlay2.Acciones
{
    public static class Escribir
    {
        public static void Escribiendo(By locator, string text, Reporte report)
        {
            try
            {
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                var element = Driver.driver.FindElement(locator);
                PintarDespintar.HighLighterMethod(Driver.GetInstance(), locator);
                element.Clear();
                element.SendKeys(text);
                report.addLogScreenCapture(Status.Pass, $"Fue posible ingresar el texto '{text}'");
                PintarDespintar.HighLighterMethodOff(Driver.GetInstance(), locator);
                Esperar.Time1();
            }
            catch (Exception ex)
            {
                report.addLogScreenCapture(Status.Fail, $"No fue posible ingresar el texto '{text}'");
                throw ex;
            }
        }

        public static void EscribirTeclaAbajoEnter(By locator, string text, Reporte report)
        {
            try
            {
                var element = Driver.driver.FindElement(locator);
                PintarDespintar.HighLighterMethod(Driver.GetInstance(), locator);
                element.Clear();
                element.SendKeys(text);
                element.SendKeys(Keys.ArrowDown + Keys.Enter);
                report.addLogScreenCapture(Status.Pass, $"Fue posible ingresar el texto '{text}'");
                PintarDespintar.HighLighterMethodOff(Driver.GetInstance(), locator);
                Esperar.Time1();
            }
            catch (Exception ex)
            {
                report.addLogScreenCapture(Status.Fail, $"No fue posible ingresar el texto '{text}'");
                throw ex;
            }
        }
    }
}
