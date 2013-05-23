using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_BackOffice.AccesoDeDatos.Conexion.IConexion;

 
namespace PuiPui_BackOffice.AccesoDeDatos.Conexion
{
    public class ConexionSqlServer : IConexionSqlServer
    {
        private static String cadenaConexion;
        SqlConnection objetoConexion;
        private static SqlConnection conexion;

        public ConexionSqlServer()
        {
            try
            {
                objetoConexion = null;
                cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
                //cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
                conexion = new SqlConnection(cadenaConexion);
            }
            catch (NullReferenceException)
            {
                throw new ExcepcionConexion("El string de conexion del WebConfig no puede ser localizado");
            }
        }

        public static SqlConnection AccederAconexion
        {

            get { return conexion; }

            set { conexion = value; }

        }

        //Metodo para abrir la conexion
        public void AbrirConexion()
        {

            if (!String.IsNullOrEmpty(cadenaConexion))
            {
                objetoConexion = new SqlConnection(cadenaConexion);
                objetoConexion.Open();

                if (objetoConexion.State.ToString() != "Open")
                {
                    while (objetoConexion.State.ToString() != "Open")
                    {

                    }
                }
            }
        }

        //Metodo para cerrar la conexion
        public void CerrarConexion()
        {
            if (objetoConexion != null)
            {
                if (objetoConexion.State.ToString() == "Open")
                {
                    objetoConexion.Close();
                    objetoConexion.Dispose();
                }
            }
        }


        public SqlConnection ObjetoConexion()
        {
            return (objetoConexion);

        }

    }
}
    