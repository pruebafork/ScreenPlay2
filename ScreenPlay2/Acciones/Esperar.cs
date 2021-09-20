using System.Threading;

namespace ScreenPlay2.Acciones
{
    public static class Esperar
    {
        public static void Time5()
        {
            Thread.Sleep(5000);
        }

        public static void Time4()
        {
            Thread.Sleep(4000);
        }

        public static void Time3()
        {
            Thread.Sleep(3000);
        }

        public static void Time2()
        {
            Thread.Sleep(2000);
        }

        public static void Time1()
        {
            Thread.Sleep(1000);
        }

        public static void IniciarTiempo(int milisegundos)
        {
            Thread.Sleep(milisegundos);
        }
    }
}