using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleados.Datos
{
    public class Conexion
    {
        private string Servidor;
        private string Base;
        private string usuario;
        private string Clave;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "bd_gestion_empleados";
            this.Servidor = "DESKTOP-MJ3JFQP\\SQLEXPRESS";
            this.usuario = "Carlos";
            this.Clave = "Carlos040630";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();

            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor +
                                          ";  Database=" + this.Base +
                                          ";  User Id=" + this.usuario +
                                          "; Password=" + this.Clave;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion CrearInstancia()
        {
            if(Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }

    }
}
