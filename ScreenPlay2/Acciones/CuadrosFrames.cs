using OpenQA.Selenium;
using ScreenPlay2.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay2.Acciones
{
    public static class CuadrosFrames
    {
        public static void Frame(By locator)
        {
            Driver.GetInstance().SwitchTo().Frame(Elemento.On(locator));
        }

        public static void SwitchToFrame()
        {
            Driver.GetInstance().SwitchTo().DefaultContent();
        }
    }
}
