using AventStack.ExtentReports;
using ScreenPlay2.Bases;
using ScreenPlay2.Reportes;
using System;

namespace ScreenPlay2.Acciones
{
    public static class Alerta
    {
        public static bool Alert(Reporte report)
        {
            try
            {
                Driver.GetInstance().SwitchTo().Alert().Accept();
                report.addLogScreenCapture(Status.Pass, $"Se acepto la alerta");
                return true;
            }
            catch (Exception ex)
            {
                report.addLogScreenCapture(Status.Fail, $"No se acepto la alerta");
                throw ex;
            }
        }
    }
}
