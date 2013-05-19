using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PuiPui_BackOffice.AccesoDeDatos.Conexion;
using PuiPui_BackOffice.AccesoDeDatos.Conexion.IConexion;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;

namespace PuiPui_BackOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerClase
    {
        #region Atributos
         
        private List<Clase> _listaClases ;
        private Clase _objetoClase;
        private IConexionSqlServer _db ;
        private string _cadenaConexion;
        private SqlConnection _conexion;
        private SqlCommand _cmd;
        private SqlDataReader _dr;
        #endregion

        #region Constructor
        public SQLServerClase()
        {
            _listaClases = new List<Clase>();
            _db = new ConexionSqlServer();
            _cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            _conexion = new SqlConnection();
            _cmd = new SqlCommand();
        }
        #endregion

        #region Metodos 

        public List<Clase> ConsultarClases()
        {

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[ListarClases]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _dr = _cmd.ExecuteReader();

                //Llena la lista de Clases
                while (_dr.Read())
                {

                    _objetoClase = new Clase();

                    _objetoClase.IdClase = Convert.ToInt32(_dr.GetValue(0));
                    _objetoClase.Nombre = _dr.GetValue(1).ToString();
                    _objetoClase.Descripcion = _dr.GetValue(2).ToString();
                    _objetoClase.Status = Convert.ToInt32(_dr.GetValue(3));

                    _listaClases.Add(_objetoClase);
                }

                _db.CerrarConexion();

            }
            catch (SqlException error)
            {
                //En caso de que se viole alguna restriccion sobre la BD
                throw (new ExcepcionConexion(("Error: " + error.Message), error));
            }
            finally
            {
                _db.CerrarConexion();
            }
            return _listaClases;
        }

        #endregion
    }
}