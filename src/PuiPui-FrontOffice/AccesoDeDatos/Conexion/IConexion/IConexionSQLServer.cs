using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace PuiPui_FrontOffice.AccesoDeDatos.Conexion.IConexion
{
    public interface IConexionSqlServer
    {

        void AbrirConexion();

        void CerrarConexion();

        SqlConnection ObjetoConexion();


    }
}