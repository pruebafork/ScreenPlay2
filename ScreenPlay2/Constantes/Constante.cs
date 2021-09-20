using System;

namespace ScreenPlay2.Constantes
{
    public static class Constante
    {
        public static string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
        public static string actualPath = path.Substring(0, path.LastIndexOf("bin"));
        public static string projectPath = new Uri(actualPath).LocalPath;
        public static string DATALOCATION = projectPath + "Excels";
    }
}
