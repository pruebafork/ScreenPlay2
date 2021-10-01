using AventStack.ExtentReports;
using Oracle.ManagedDataAccess.Client;
using ScreenPlay2.BasesDeDatos;
using ScreenPlay2.Reportes;
using ScreenPlay2.VariablesTablas;
using System;
using System.Collections.Generic;

namespace ScreenPlay2.TareasConexion
{
    class ObtenerTabla
    {
        public static List<PruebaVariables> tabla(Reporte report, string nroProceso)
        {
            List<PruebaVariables> result = new List<PruebaVariables>();
            try
            {
                OracleConnection oracleConexion = Connection.abrirConexion(report);
                OracleCommand oracleComandos = oracleConexion.CreateCommand();
                oracleComandos.CommandText = $"SELECT * FROM TABLA WHERE ID = '{nroProceso}'";
                OracleDataReader lectorDatosOracle = oracleComandos.ExecuteReader();
                while (lectorDatosOracle.Read())
                {
                    result.Add(
                        new PruebaVariables()
                        {
                            id = lectorDatosOracle.IsDBNull(lectorDatosOracle.GetOrdinal("id")) ? 0 : Convert.ToInt64(lectorDatosOracle["id"]),
                            nombre = lectorDatosOracle.IsDBNull(lectorDatosOracle.GetOrdinal("nombre")) ? null : Convert.ToString(lectorDatosOracle["nombre"]),
                            fecha = lectorDatosOracle.IsDBNull(lectorDatosOracle.GetOrdinal("fecha")) ? DateTime.MinValue : Convert.ToDateTime(lectorDatosOracle["fecha"]),
                        });
                }
                lectorDatosOracle.Dispose();
                oracleComandos.Dispose();
                oracleConexion = Connection.cerrarConexion(report, oracleConexion);
                report.addLogScreenCapture(Status.Pass, $"Se hizo click en el boton");
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
