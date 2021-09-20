using ScreenPlay2.Constantes;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.IO;

namespace ScreenPlay2.Registros
{
    public static class LeerExcel
    {
        public static List<string> GetDataExcel(string id, string sheet)
        {
            string path = Constante.DATALOCATION + "\\Excel.xlsx";

            if (!File.Exists(path))
            {
                throw new InvalidOperationException("El path del excel no existe");
            }
            SLDocument SLD = new SLDocument(path);
            SLD.SelectWorksheet(sheet);
            int row = 2;
            while (!string.IsNullOrEmpty(SLD.GetCellValueAsString(row, 1)))
            {
                if (SLD.GetCellValueAsString(row, 1) == id)
                {
                    if (sheet.Equals("Login"))
                    {
                        string user = SLD.GetCellValueAsString(row, 2);
                        string pass = SLD.GetCellValueAsString(row, 3);

                        var listRetorno = new List<string>
                        {
                            user,pass
                        };
                        return listRetorno;
                    }
                    else if (sheet.Equals("Hoja2"))
                    {
                        string user = SLD.GetCellValueAsString(row, 2);
                        string pass = SLD.GetCellValueAsString(row, 3);

                        var listRetorno = new List<string>
                        {
                            user,pass
                        };
                        return listRetorno;
                    }
                }
                row++;
            }
            return null;
        }
    }
}
