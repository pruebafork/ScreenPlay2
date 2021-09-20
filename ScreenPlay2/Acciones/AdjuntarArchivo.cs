using AventStack.ExtentReports;
using OpenQA.Selenium;
using ScreenPlay2.Bases;
using ScreenPlay2.Reportes;
using System;

namespace ScreenPlay2.Acciones
{
    public static class AdjuntarArchivo
    {
        public static void Adjuntar(By locator, Reporte report, string adjunto)
        {
            try
            {
                var element = Driver.driver.FindElement(locator);
                element.SendKeys(adjunto);
                report.addLogScreenCapture(Status.Pass, $"Fue posible ingresar el archivo '{adjunto}'");
            }
            catch (Exception ex)
            {
                report.addLogScreenCapture(Status.Fail, $"No fue posible ingresar el texto '{adjunto}'");
                throw ex;
            }
        }
    }
}
