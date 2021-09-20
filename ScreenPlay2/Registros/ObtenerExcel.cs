using System.Collections.Generic;

namespace ScreenPlay2.Registros
{
    public static class ObtenerExcel
    {
        public static List<string> login_excel = LeerExcel.GetDataExcel("1", "Login");
    }
}
