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

        private List<Clase> _listaClases;
        private Clase _objetoClase;
        private IConexionSqlServer _db;
        private string _cadenaConexion;
        private SqlConnection _conexion;
        private SqlCommand _cmd;
        private SqlDataReader _dr;
        private SqlParameter _param;
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
                    _objetoClase.Status = Convert.ToInt32(_dr.GetValue(2));

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

        public Boolean AgregarClase(Clase clase)
        {
            Boolean insercion = false;
            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[AgregarClase]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _dr = _cmd.ExecuteReader();

                _param = new SqlParameter("@Nombre", clase.Nombre);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Descripcion", clase.Descripcion);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Status", clase.Status);
                _cmd.Parameters.Add(_param);

                insercion = true;
                _db.CerrarConexion();

            }
            catch (SqlException error)
            {
                //En caso de que se viole alguna restriccion sobre la BD
                insercion = false;
                throw (new ExcepcionConexion(("Error: " + error.Message), error));

            }
            finally
            {
                _db.CerrarConexion();

            }
            return insercion;

        }

        public Boolean ModificarClase(Clase clase)
        {
            Boolean insercion = false;
            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[ModificarClase]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _dr = _cmd.ExecuteReader();

                _param = new SqlParameter("@Id_clase", clase.IdClase);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Nombre", clase.Nombre);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Descripcion", clase.Descripcion);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Status", clase.Status);
                _cmd.Parameters.Add(_param);

                insercion = true;
                _db.CerrarConexion();

            }
            catch (SqlException error)
            {
                //En caso de que se viole alguna restriccion sobre la BD
                insercion = false;
                throw (new ExcepcionConexion(("Error: " + error.Message), error));

            }
            finally
            {
                _db.CerrarConexion();

            }
            return insercion;

        }

        public Clase DetalleClases(int id)
        {

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[DetalleClases]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _dr = _cmd.ExecuteReader();

                _param = new SqlParameter("@Id_clase", id);
                _cmd.Parameters.Add(_param);


                //Llena el objeto clase detallado

                _objetoClase = new Clase();

                _objetoClase.IdClase = Convert.ToInt32(_dr.GetValue(0));
                _objetoClase.Nombre = _dr.GetValue(1).ToString();
                _objetoClase.Descripcion = _dr.GetValue(2).ToString();
                _objetoClase.Status = Convert.ToInt32(_dr.GetValue(3));

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
            return _objetoClase;
        }

        #endregion
    }
}