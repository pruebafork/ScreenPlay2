using NUnit.Framework;
using ScreenPlay2.Bases;
using ScreenPlay2.Tareas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay2.Tests
{
    public class PruebaMenu : Base
    {
        [Test]
        public void clickBoton()
        {
            Logeo.Logear(report);
            Menu.hacerClickEnUno("Admin",report);
        }

        [Test]
        public void hacerClickEnTodos()
        {
            Logeo.Logear(report);
            Menu.hacerClickEnTodoMenu(report);
        }
    }
}
