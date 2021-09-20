using ScreenPlay2.Acciones;
using ScreenPlay2.Registros;
using ScreenPlay2.Reportes;
using ScreenPlay2.Selectores;
using System.Collections.Generic;

namespace ScreenPlay2.Tareas
{
    public static class Logeo
    {
        public static List<string> DataLogeo = ObtenerExcel.login_excel;
        public static string user = DataLogeo[0];
        public static string pass = DataLogeo[1];
        public static void Loge(Reporte report)
        {
            Escribir.SendKeys(CajaTexto.username, user, report);
            Escribir.SendKeys(CajaTexto.password, pass, report);
            HacerClick.ClickOnReport(Boton.login, report, "Logeo");
        }
    }
}
