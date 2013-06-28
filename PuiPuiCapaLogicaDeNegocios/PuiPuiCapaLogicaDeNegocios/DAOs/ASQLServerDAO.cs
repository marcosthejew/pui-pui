using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.DAOs
{
    /// <summary>
    /// Clase abstracta que engloba el funcionamiento general de todas las 
    /// clases SQLServerDAO.
    /// </summary>
    public abstract class ASQLServerDAO
    {
        protected static string _cadenaConexion = 
                ConfigurationManager.ConnectionStrings["SqlServer"]
                        .ConnectionString;
        
        /// <summary>
        /// Devuelve una nueva conexion a la base de datos de SQL Server de la
        /// capa de datos.
        /// </summary>
        /// <returns></returns>
        protected SqlConnection obtenerConexion()
        {
            return new SqlConnection(_cadenaConexion);
        }

        protected void CerrarConexion(SqlConnection conexion)
        {
            if (conexion == null) return;
            if (conexion.State.ToString() != "Open") return;
            conexion.Close();
            conexion.Dispose();
        }
    }
}