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
        public static void Logear(Reporte report)
        {
            Escribir.Escribiendo(CajaTexto.username, user, report);
            Escribir.Escribiendo(CajaTexto.password, pass, report);
            HacerClick.Click(Boton.login, report, "Logeo");
        }
    }
}