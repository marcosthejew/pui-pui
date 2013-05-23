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
using PuiPui_BackOffice.Entidades.Salon;

namespace PuiPui_BackOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerSalon
    {
              #region Atributos
         
        private List<Salon> _listaSalones ;
        private Salon _objetoSalon;
        private IConexionSqlServer _db ;
        private string _cadenaConexion;
        private SqlConnection _conexion;
        private SqlCommand _cmd;
        private SqlDataReader _dr;
        private SqlParameter _param;
        #endregion  

        #region Constructor
        public SQLServerSalon()
        {
            _listaSalones = new List<Salon>();
            _db = new ConexionSqlServer();
            _cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            _conexion = new SqlConnection();
            _cmd = new SqlCommand();
        }
        #endregion

        #region Metodos 

        public List<Salon> ConsultarSalones()
        {

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[ListarSalones]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _dr = _cmd.ExecuteReader();

                //Llena la lista de salones
                while (_dr.Read())
                {

                    _objetoSalon = new Salon();

                    _objetoSalon.IdSalon = Convert.ToInt32(_dr.GetValue(0));
                    _objetoSalon.Ubicacion = _dr.GetValue(1).ToString();
                    _objetoSalon.Capacidad = Convert.ToInt32(_dr.GetValue(2));
                    _objetoSalon.Status = Convert.ToInt32(_dr.GetValue(3));

                    _listaSalones.Add(_objetoSalon);
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
            return _listaSalones;
        }

        public Boolean AgregarSalon(Salon salon)
        {
            Boolean insercion = false;
            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[AgregarSalon]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                
                _param = new SqlParameter("@Ubicacion", salon.Ubicacion);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Capacidad", salon.Capacidad);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Status", salon.Status);
                _cmd.Parameters.Add(_param);

                _dr = _cmd.ExecuteReader();

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

        public Boolean ModificarSalon(Salon salon)
        {
            Boolean insercion = false;
            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[ModificarSalon]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
               
                _param = new SqlParameter("@Id_salon", salon.IdSalon);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Ubicacion", salon.Ubicacion);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Capacidad", salon.Capacidad);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Status", salon.Status);
                _cmd.Parameters.Add(_param);

                _dr = _cmd.ExecuteReader();

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

        public List<Salon> BusquedaUbicacion(String ubicacion)
        {

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[BusquedaNombreClase]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _param = new SqlParameter("@Ubicacion", ubicacion);
                _cmd.Parameters.Add(_param);

                _dr = _cmd.ExecuteReader();
                
                while (_dr.Read())
                {
                    _objetoSalon = new Salon();
                    _objetoSalon.IdSalon = Convert.ToInt32(_dr.GetValue(0));
                    _objetoSalon.Ubicacion = _dr.GetValue(1).ToString();
                    _objetoSalon.Capacidad = Convert.ToInt32(_dr.GetValue(2).ToString());
                    _objetoSalon.Status = Convert.ToInt32(_dr.GetValue(3));
                    _listaSalones.Add(_objetoSalon);
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
            return _listaSalones;
        }

        public List<Salon> BusquedaCapacidadMayorSalon(int capacidad)
        {

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[BusquedaCapacidadMayorSalon]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _param = new SqlParameter("@Capacidad", capacidad);
                _cmd.Parameters.Add(_param);

                _dr = _cmd.ExecuteReader();

                while (_dr.Read())
                {
                    _objetoSalon = new Salon();
                    _objetoSalon.IdSalon = Convert.ToInt32(_dr.GetValue(0));
                    _objetoSalon.Ubicacion = _dr.GetValue(1).ToString();
                    _objetoSalon.Capacidad = Convert.ToInt32(_dr.GetValue(2).ToString());
                    _objetoSalon.Status = Convert.ToInt32(_dr.GetValue(3));
                    _listaSalones.Add(_objetoSalon);
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
            return _listaSalones;
        }

        public List<Salon> BusquedaCapacidadMenorSalon(int stat)
        {

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[BusquedaCapacidadMenorSalon]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _param = new SqlParameter("@Capacidad", stat);
                _cmd.Parameters.Add(_param);

                _dr = _cmd.ExecuteReader();

                while (_dr.Read())
                {
                    _objetoSalon = new Salon();
                    _objetoSalon.IdSalon = Convert.ToInt32(_dr.GetValue(0));
                    _objetoSalon.Ubicacion = _dr.GetValue(1).ToString();
                    _objetoSalon.Capacidad = Convert.ToInt32(_dr.GetValue(2).ToString());
                    _objetoSalon.Status = Convert.ToInt32(_dr.GetValue(3));
                    _listaSalones.Add(_objetoSalon);
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
            return _listaSalones;
        }

        public List<Salon> BusquedaStatusSalon(int stat)
        {

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[BusquedaStatusSalon]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _param = new SqlParameter("@Status", stat);
                _cmd.Parameters.Add(_param);

                _dr = _cmd.ExecuteReader();

                while (_dr.Read())
                {
                    _objetoSalon = new Salon();
                    _objetoSalon.IdSalon = Convert.ToInt32(_dr.GetValue(0));
                    _objetoSalon.Ubicacion = _dr.GetValue(1).ToString();
                    _objetoSalon.Capacidad = Convert.ToInt32(_dr.GetValue(2).ToString());
                    _objetoSalon.Status = Convert.ToInt32(_dr.GetValue(3));
                    _listaSalones.Add(_objetoSalon);
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
            return _listaSalones;
        }


        #endregion

    }
}