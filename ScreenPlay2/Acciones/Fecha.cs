using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay2.Acciones
{
    public static class Fecha
    {
        public static string FechaAgregarDias(int dias)
        {
            string fecha = DateTime.Now.AddDays(dias).ToString("dd/MM/yyyy");
            return fecha;
        }

        public static string ObtenerDia()
        {
            var fecha = DateTime.Now.Day;
            return fecha.ToString();
        }

        public static string ObtenerMes()
        {
            var fecha = DateTime.Now.Month;
            return fecha.ToString();
        }

        public static string ObtenerAño()
        {
            var fecha = DateTime.Now.Year;
            return fecha.ToString();
        }
    }
}
