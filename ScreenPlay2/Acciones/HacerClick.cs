using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using ScreenPlay2.Bases;
using ScreenPlay2.Reportes;
using System;

namespace ScreenPlay2.Acciones
{
    public static class HacerClick
    {
        public static void ClickOnReport(By locator, Reporte report, string buttonName)
        {
            try
            {
                EsperarHasta.ElementIsClickeable(locator);

                var element = Elemento.On(locator);
                var action = new Actions(Driver.driver);
                action.MoveToElement(element).Build().Perform();
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                PintarDespintar.HighLighterMethod(Driver.GetInstance(), locator);
                report.addLogScreenCapture(Status.Pass, $"Se hizo click en '{buttonName}'");

                element.Click();
                PintarDespintar.HighLighterMethodOff(Driver.GetInstance(), locator);
            }
            catch (Exception)
            {
                report.addLogScreenCapture(Status.Fail, $"No fue posible hacer click en '{buttonName}'");
            }
        }
    }
}
