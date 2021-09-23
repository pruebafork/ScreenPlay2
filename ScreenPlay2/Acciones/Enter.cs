using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using ScreenPlay2.Bases;
using ScreenPlay2.Reportes;
using System;

namespace ScreenPlay2.Acciones
{
    public static class Enter
    {
        public static void EscrbirTextoMasEnter(By locator, Reporte report, string texto)
        {
            try
            {
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                var element = Driver.driver.FindElement(locator);
                var action = new Actions(Driver.driver);
                action.MoveToElement(element).Build().Perform();
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                PintarDespintar.HighLighterMethod(Driver.GetInstance(), locator);
                element.SendKeys(texto + Keys.Enter);
                report.addLogScreenCapture(Status.Pass, $"Se ingreso el texto '{texto}' y se presiono la tecla Enter");
                PintarDespintar.HighLighterMethodOff(Driver.GetInstance(), locator);
            }
            catch (Exception ex)
            {
                report.addLogScreenCapture(Status.Fail, $"No fue posible ingresar el '{texto}'");
                throw ex;
            }
        }

        public static void EScribirTextoAbajoEnter(By locator, Reporte report, string texto)
        {
            try
            {
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                var element = Driver.driver.FindElement(locator);
                var action = new Actions(Driver.driver);
                action.MoveToElement(element).Build().Perform();
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                PintarDespintar.HighLighterMethod(Driver.GetInstance(), locator);
                element.SendKeys(texto);
                element.SendKeys(Keys.ArrowDown + Keys.Enter);
                report.addLogScreenCapture(Status.Pass, $"Se ingreso el texto '{texto}' y se presiono la tecla Enter");
                PintarDespintar.HighLighterMethodOff(Driver.GetInstance(), locator);
            }
            catch (Exception ex)
            {
                report.addLogScreenCapture(Status.Fail, $"No fue posible ingresar el '{texto}'");
                throw ex;
            }
        }

        public static void EScribirTextoMasTab(By locator, Reporte report, string texto)
        {
            try
            {
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                var element = Driver.driver.FindElement(locator);
                var action = new Actions(Driver.driver);
                action.MoveToElement(element).Build().Perform();
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                PintarDespintar.HighLighterMethod(Driver.GetInstance(), locator);
                element.SendKeys(texto);
                element.SendKeys(Keys.Tab);
                report.addLogScreenCapture(Status.Pass, $"Se ingreso el texto '{texto}' y se presiono la tecla Enter");
                PintarDespintar.HighLighterMethodOff(Driver.GetInstance(), locator);
            }
            catch (Exception ex)
            {
                report.addLogScreenCapture(Status.Fail, $"No fue posible ingresar el '{texto}'");
                throw ex;
            }
        }
    }
}
