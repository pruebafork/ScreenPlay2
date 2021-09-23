using ScreenPlay2.Acciones;
using ScreenPlay2.CodigosUtiles.Selectores;
using ScreenPlay2.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay2.CodigosUtiles.LlamadaSelectores
{
    public static class Llamada
    {
        public static void prueba(Reporte report)
        {
            //GET AND SET
            Botones.setValor("alexis");
            HacerClick.Click(Botones.getValue(), report, "nombre boton");

            //format
            HacerClick.Click(Botones.getPosicionLista(2),report,"nombre");
        }
    }
}
