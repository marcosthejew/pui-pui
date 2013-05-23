using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion.IConexion;
using PuiPui_FrontOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_FrontOffice.LogicaDeNegocios.EvaluacionInstructor;

namespace PuiPui_FrontOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerEvaluacionInstructor
    {

        #region Atributos
        private List<LogicaEvaluacionInstructor> _listaEvaluacion;
        private IConexionSqlServer _db;
        private string _cadenaConexion;
        private SqlConnection _conexion;
        private SqlCommand _cmd;
        private SqlDataReader _dr;
        private SqlParameter _param;
        #endregion

        #region Constructor
        public SQLServerEvaluacionInstructor()
        {
            _listaEvaluacion = new List<LogicaEvaluacionInstructor>();
            _db = new ConexionSqlServer();
            _cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            _conexion = new SqlConnection();
            _cmd = new SqlCommand();
        }
        #endregion

        #region Metodos

        #region Consultar Todas las Evaluaciones
        public SqlDataReader ConsultarEvaluaciones()
        {

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[ConsultarEvaluacionesTodas]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _dr = _cmd.ExecuteReader();

                _db.CerrarConexion();
                //Llena la lista de Evaluacion
                //while (_dr.Read())
                //{

                //    _evaluacion = new LogicaEvaluacionInstructor();

                //    _evaluacion.IdEvaluacion = (int)_dr.GetValue(0);
                //    _evaluacion.Fecha = (DateTime)_dr.GetValue(1);
                //    _evaluacion.Calificacion = (int)_dr.GetValue(2);
                //    //if (_dr.GetValue(3) == null)
                //        _evaluacion.IdClaseSalon = 0;
                //    //else if (_dr.GetValue(3) != null)
                //    //    _evaluacion.IdClaseSalon = (int)_dr.GetValue(3);
                //    //if (_dr.GetValue(4) == null)
                //        _evaluacion.IdClaseSalon = 0;
                //    //else if (_dr.GetValue(4) != null)
                //    //    _evaluacion.IdCliente = (int)_dr.GetValue(4);
                //    //if (_dr.GetValue(5) == null)
                //        _evaluacion.IdInstructor = 0;
                //    //else if (_dr.GetValue(3) != null)
                //    //    _evaluacion.IdInstructor =(int)_dr.GetValue(5);

                //    _listaEvaluacion.Add(_evaluacion);
                //}

//                _db.CerrarConexion();

            }
            catch (SqlException error)
            {
                //En caso de que se viole alguna restriccion sobre la BD
                throw (new ExcepcionConexion(("Error: " + error.Message), error));
            }
            finally
            {
                //_db.CerrarConexion();
            }
            //return _listaEvaluacion ;
            return _dr;
        }
        #endregion

        #region Agregar una Evaluacion
        public bool AgregarEvaluacion(DateTime fechaEvaluacion, int calificacion, int idCliente, int idInstructor)
        {
            bool agrego = false;
            fechaEvaluacion = DateTime.Now;

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[AgregarEvaluacionInstructor]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;


                _param = new SqlParameter("@fechaEvaluacion", fechaEvaluacion);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@calificacion", calificacion);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@idCliente", idCliente);
                _cmd.Parameters.Add(_param);

                 _param = new SqlParameter("@idInstructor", idInstructor);
                _cmd.Parameters.Add(_param);

                _dr = _cmd.ExecuteReader();

                agrego = true;
                _db.CerrarConexion();

            }
            catch (SqlException error)
            {
                //En caso de que se viole alguna restriccion sobre la BD
                agrego = false;
                throw (new ExcepcionConexion(("Error: " + error.Message), error));

            }
            finally
            {
                _db.CerrarConexion();

            }
            return agrego;
        }
        #endregion

        #region Modificar una Evaluacion
        public bool ModificarEvaluacion(int calificacion, int idCliente, int idInstructor, int idEvaluacion)
        {
            bool modifico = false;

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[ModificarEvaluacionInstructor]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;


                _param = new SqlParameter("@calificacion", calificacion);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@idCliente", idCliente);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@idInstructor", idInstructor);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@idEvaluacion", idEvaluacion);
                _cmd.Parameters.Add(_param);

                _dr = _cmd.ExecuteReader();

                modifico = true;
                _db.CerrarConexion();

            }
            catch (SqlException error)
            {
                //En caso de que se viole alguna restriccion sobre la BD
                modifico = false;
                throw (new ExcepcionConexion(("Error: " + error.Message), error));

            }
            finally
            {
                _db.CerrarConexion();

            }
            return modifico;
        }
        #endregion

        #endregion

    }
}