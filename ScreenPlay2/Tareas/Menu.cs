using ScreenPlay2.Acciones;
using ScreenPlay2.Bases;
using ScreenPlay2.Reportes;
using ScreenPlay2.Selectores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay2.Tareas
{
    public static class Menu
    {
        public static void hacerClickEnUno(string valor, Reporte report)
        {
            Boton.setMenu(valor);
            HacerClick.Click(Boton.getMenu(), report, valor);
        }

        public static void hacerClickEnTodoMenu(Reporte report)
        {
            var listaMenu = Driver.GetInstance().FindElements(Boton.menu);
            string[] array = new string[] { "Admin", "PIM", "Leave", "Time", "Recruitment", "My Info", "Performance", "Performance", "Directory", "Maintenance"};
            int i = 0;
            foreach (var item in listaMenu)
            {
                Boton.setMenu(array[i]);
                HacerClick.Click(Boton.getMenu(), report, array[i]);
                i++;
            }
        }
    }
}
