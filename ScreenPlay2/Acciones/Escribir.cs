using AventStack.ExtentReports;
using OpenQA.Selenium;
using ScreenPlay2.Bases;
using ScreenPlay2.Reportes;
using System;

namespace ScreenPlay2.Acciones
{
    public static class Escribir
    {
        public static void SendKeys(By locator, string text, Reporte report)
        {
            try
            {
                var element = Driver.driver.FindElement(locator);
                PintarDespintar.HighLighterMethod(Driver.GetInstance(), locator);
                element.Clear();
                element.SendKeys(text);
                report.addLogScreenCapture(Status.Pass, $"Fue posible ingresar el texto '{text}'");
                PintarDespintar.HighLighterMethodOff(Driver.GetInstance(), locator);
                EsperarHasta.Time1();
            }
            catch (Exception)
            {
                report.addLogScreenCapture(Status.Fail, $"No fue posible ingresar el texto '{text}'");
            }
        }
    }
}
