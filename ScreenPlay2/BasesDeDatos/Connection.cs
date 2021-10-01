using AventStack.ExtentReports;
using Oracle.ManagedDataAccess.Client;
using ScreenPlay2.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace ScreenPlay2.BasesDeDatos
{
    public class Connection
    {
        static OracleConnection conexion = null;
        private static string idUser;
        private static string password;
        private static string protocol;
        private static string host;
        private static string port;
        private static string sid;

        public OracleConnection obtenerConexion(Reporte report)
        {
            if (conexion == null)
            {
                try
                {
                    idUser = WebConfigurationManager.AppSettings["ID"].ToString();
                    password = WebConfigurationManager.AppSettings["password"].ToString();
                    protocol = WebConfigurationManager.AppSettings["PROTOCOL"].ToString();
                    host = WebConfigurationManager.AppSettings["Host"].ToString();
                    port = WebConfigurationManager.AppSettings["Port"].ToString();
                    sid = WebConfigurationManager.AppSettings["SID"].ToString();

                    conexion = new OracleConnection($"user id={idUser}; " +
                        $"(password={password}; data source=(DESCRIPTION) =(ADDRESS = " +
                        $"(PROTOCOL={protocol})" +
                        $"(Host={host})" +
                        $"(Port={port})" +
                        $"(CONNET_DATA = (SID = {sid})))");
                    report.addLogScreenCapture(Status.Pass, $"Se hizo click en el boton");

                }
                catch (Exception)
                {
                    report.addLogScreenCapture(Status.Pass, $"Se hizo click en el boton");
                    throw;
                }
            }
            return conexion;
        }

        public static OracleConnection abrirConexion(Reporte report)
        {
            if (conexion == null)
            {
                try
                {
                    Connection cone = new Connection();
                    conexion = cone.obtenerConexion(report);
                    conexion.Open();
                    report.addLogScreenCapture(Status.Pass, $"Se hizo click en el boton");
                }
                catch (Exception)
                {
                    report.addLogScreenCapture(Status.Pass, $"Se hizo click en el boton");

                    throw;
                }
            }
            return conexion;
        }


        public static OracleConnection cerrarConexion(Reporte report, OracleConnection cone)
        {
            if (cone.State == System.Data.ConnectionState.Open || cone != null)
            {
                try
                {
                    cone.Close();
                    OracleConnection.ClearAllPools();
                    conexion = null;
                    report.addLogScreenCapture(Status.Pass, $"Se hizo click en el boton");
                }
                catch (Exception)
                {
                    report.addLogScreenCapture(Status.Pass, $"Se hizo click en el boton");

                    throw;
                }
            }
            return conexion;
        }
    }
}
