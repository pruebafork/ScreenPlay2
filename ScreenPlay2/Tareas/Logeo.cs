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
            HacerClick.Click(Boton.myInfo, report, "My Info");
            HacerClick.Click(Boton.edit, report, "Edit");
            Escribir.Escribiendo(CajaTexto.SNNnRO, "9139EMI", report);
            HacerClick.Click(Radio.Female, report, "Femenino");
            Seleccionar.SeleccionarPorTexto(Seleccion.Nacionalidad, report, "Kittian and Nevisian");
            Escribir.Escribiendo(CajaTexto.fullName, "tania", report);
            Escribir.Escribiendo(CajaTexto.middleName, "emilse", report);
            Escribir.Escribiendo(CajaTexto.lastName, "martinez", report);
            HacerClick.Click(CajaSeleccionada.Smoke, report, "Fumador");
            Escribir.Escribiendo(CajaTexto.otherId, "9139tm", report);
            Escribir.Escribiendo(CajaTexto.NroLicencia, "46464464", report);
            Escribir.Escribiendo(CajaTexto.sinNumber, "fdf554556", report);
            Escribir.Escribiendo(CajaTexto.EmployeeId, "9139", report);
        }
    }
}