using System;
using System.Data.SqlClient;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_BackOffice.AccesoDeDatos.Conexion.IConexion;

namespace PuiPui_BackOffice.AccesoDeDatos.Conexion
{
    public class ConexionSqlServer : IConexionSqlServer
    {
        private static String _cadenaConexion;
        SqlConnection _objetoConexion;

        public ConexionSqlServer()
        {
            try
            {
                _objetoConexion = null;
                _cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
                AccederAconexion = new SqlConnection(_cadenaConexion);
            }
            catch (NullReferenceException)
            {
                throw new ExcepcionConexion("El string de conexion del WebConfig no puede ser localizado");
            }
        }

        public static SqlConnection AccederAconexion { get; set; }

        //Metodo para abrir la conexion
        public void AbrirConexion()
        {
            if (String.IsNullOrEmpty(_cadenaConexion)) 
                return;
            _objetoConexion = new SqlConnection(_cadenaConexion);
            _objetoConexion.Open();

            if (_objetoConexion.State.ToString() == "Open") return;

            while (_objetoConexion.State.ToString() != "Open")
            {

            }
        }

        //Metodo para cerrar la conexion
        public void CerrarConexion()
        {
            if (_objetoConexion == null) return;
            if (_objetoConexion.State.ToString() != "Open") return;
            _objetoConexion.Close();
            _objetoConexion.Dispose();
        }


        public SqlConnection ObjetoConexion()
        {
            return (_objetoConexion);
        }
    }
}
    