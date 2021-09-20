using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ScreenPlay2.Reportes;
using System;

namespace ScreenPlay2.Acciones
{
    public static class Seleccionar
    {
        public static void SeleccionarPorText(By locator, Reporte report, string text)
        {
            try
            {
                EsperarHasta.ElementIsClickeable(locator);
                var element = Elemento.On(locator);
                var dropdownElement = new SelectElement(element);
                dropdownElement.SelectByText(text);
                Esperar.Time1();
                report.addLogScreenCapture(Status.Pass, $"Se hizo click en la opcion: '{text}'");
            }
            catch (Exception)
            {
                report.addLogScreenCapture(Status.Fail, $"No fue posible hacer click en la opcion: '{text}'");
            }
        }

        public static void SeleccionarPorValue(By locator, Reporte report, string value)
        {
            try
            {
                EsperarHasta.ElementIsClickeable(locator);
                var element = Elemento.On(locator);
                var dropdownElement = new SelectElement(element);
                dropdownElement.SelectByValue(value);
                Esperar.Time1();
                report.addLogScreenCapture(Status.Pass, $"Se hizo click en la opcion: '{value}'");
            }
            catch (Exception)
            {
                report.addLogScreenCapture(Status.Fail, $"No fue posible hacer click en la opcion: '{value}'");
            }
        }

        public static void SeleccionarPorIndex(By locator, Reporte report, int index)
        {
            try
            {
                EsperarHasta.ElementIsClickeable(locator);
                var element = Elemento.On(locator);
                var dropdownElement = new SelectElement(element);
                dropdownElement.SelectByIndex(index);
                Esperar.Time1();
                report.addLogScreenCapture(Status.Pass, $"Se hizo click en la opcion: '{index}'");
            }
            catch (Exception)
            {
                report.addLogScreenCapture(Status.Fail, $"No fue posible hacer click en la opcion: '{index}'");
            }
        }

    }
}