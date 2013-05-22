﻿using System;
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
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.Entidades.Instructor;



namespace PuiPui_BackOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerClaseSalon
    {

        #region Atributos
         
        private List<Salon> _listaSalones ;
        private Salon _objetoSalon;
        private Instructor _objetoInstructor;
        private List<Clase> _listaClases;
        private Clase _objetoClase;
        private ClaseSalon _objetoClaseSalon;
        private IConexionSqlServer _db;
        private string _cadenaConexion;
        private SqlConnection _conexion;
        private SqlCommand _cmd;
        private SqlDataReader _dr;
        private SqlParameter _param;
        private List<ClaseSalon> _listaClaseSalon;
        #endregion  

        #region Constructor
        public SQLServerClaseSalon()
        {
            _listaClaseSalon= new List<ClaseSalon>();
            _listaSalones = new List<Salon>();
            _listaClases = new List<Clase>();
            _db = new ConexionSqlServer();
            _cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            _conexion = new SqlConnection();
            _cmd = new SqlCommand();
        }
        #endregion

        #region Metodos

        public List<ClaseSalon> ListarSalonesClase()
        {

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[ListarSalonesClase]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _dr = _cmd.ExecuteReader();

                //Llena la lista de salones
                while (_dr.Read())
                {

                    _objetoSalon = new Salon();
                    _objetoClase = new Clase();
                    _objetoInstructor = new Instructor();
                    
                    _objetoClaseSalon.Id = Convert.ToInt32(_dr.GetValue(0));
                    _objetoClase.Nombre = _dr.GetValue(1).ToString();
                    _objetoSalon.Ubicacion = _dr.GetValue(2).ToString();
                    _objetoInstructor.NombrePersona1 = _dr.GetValue(3).ToString();

                    _objetoClaseSalon = new ClaseSalon(_objetoSalon, _objetoClase, _objetoInstructor);

                    _listaClaseSalon.Add(_objetoClaseSalon);
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
            return _listaClaseSalon;
        }

        public Boolean AgregarClaseSalon(ClaseSalon claseSalon)
        {
            Boolean insercion = false;
            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[AgregarSalonClase]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;

                _param = new SqlParameter("@Id_salon", claseSalon.Salon.IdSalon);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Id_clase", claseSalon.Clase.IdClase);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Id_instructor", claseSalon.Instructor.IdPersona);
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

        public Boolean ModificarSalonClase(ClaseSalon claseSalon)
        {
            Boolean insercion = false;
            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[ModificarSalonClase]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;

                _param = new SqlParameter("@Id_salon", claseSalon.Salon.IdSalon);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Id_clase", claseSalon.Clase.IdClase);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Id_instructor", claseSalon.Instructor.IdPersona);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Id_clase_salon", claseSalon.Id);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@disponibilidad", claseSalon.Disponibilidad);
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

        public List<ClaseSalon> ListarSalonesClaseTclase(String nombreClase)
        {

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[ListarSalonesClaseTclase]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _param = new SqlParameter("@nombre", nombreClase);
                _cmd.Parameters.Add(_param);

                _dr = _cmd.ExecuteReader();

                while (_dr.Read())
                {
                    _objetoSalon = new Salon();
                    _objetoClase = new Clase();
                    _objetoInstructor = new Instructor();

                    _objetoClaseSalon.Id = Convert.ToInt32(_dr.GetValue(0));
                    _objetoClase.Nombre = _dr.GetValue(1).ToString();
                    _objetoSalon.Ubicacion = _dr.GetValue(2).ToString();
                    _objetoInstructor.NombrePersona1 = _dr.GetValue(3).ToString();
                    _objetoClaseSalon.Disponibilidad = Convert.ToInt32(_dr.GetValue(4));

                    _objetoClaseSalon = new ClaseSalon(_objetoSalon, _objetoClase, _objetoInstructor);

                    _listaClaseSalon.Add(_objetoClaseSalon);
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
            return _listaClaseSalon;
        }

        public List<ClaseSalon> ListarSalonesClaseTsalon(String ubicacion)
        {

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[ListarSalonesClaseTsalon]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _param = new SqlParameter("@Ubicacion", ubicacion);
                _cmd.Parameters.Add(_param);

                _dr = _cmd.ExecuteReader();

                while (_dr.Read())
                {
                    _objetoSalon = new Salon();
                    _objetoClase = new Clase();
                    _objetoInstructor = new Instructor();

                    _objetoClaseSalon.Id = Convert.ToInt32(_dr.GetValue(0));
                    _objetoClase.Nombre = _dr.GetValue(1).ToString();
                    _objetoSalon.Ubicacion = _dr.GetValue(2).ToString();
                    _objetoInstructor.NombrePersona1 = _dr.GetValue(3).ToString();
                    _objetoClaseSalon.Disponibilidad = Convert.ToInt32(_dr.GetValue(4));

                    _objetoClaseSalon = new ClaseSalon(_objetoSalon, _objetoClase, _objetoInstructor);

                    _listaClaseSalon.Add(_objetoClaseSalon);
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
            return _listaClaseSalon;
        }

        public List<ClaseSalon> ListarSalonesClaseTinstructor(String instruc)
        {

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[ListarSalonesClaseTinstructor]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _param = new SqlParameter("@Nombre", instruc);
                _cmd.Parameters.Add(_param);

                _dr = _cmd.ExecuteReader();

                while (_dr.Read())
                {
                    _objetoSalon = new Salon();
                    _objetoClase = new Clase();
                    _objetoInstructor = new Instructor();

                    _objetoClaseSalon.Id = Convert.ToInt32(_dr.GetValue(0));
                    _objetoClase.Nombre = _dr.GetValue(1).ToString();
                    _objetoSalon.Ubicacion = _dr.GetValue(2).ToString();
                    _objetoInstructor.NombrePersona1 = _dr.GetValue(3).ToString();
                    _objetoClaseSalon.Disponibilidad = Convert.ToInt32(_dr.GetValue(4));

                    _objetoClaseSalon = new ClaseSalon(_objetoSalon, _objetoClase, _objetoInstructor);

                    _listaClaseSalon.Add(_objetoClaseSalon);
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
            return _listaClaseSalon;
        }

        public List<ClaseSalon> ListarSalonesClaseTdisponible(int stst)
        {

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[ListarSalonesClaseTdisponible]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _param = new SqlParameter("@reservacion", stst);
                _cmd.Parameters.Add(_param);

                _dr = _cmd.ExecuteReader();

                while (_dr.Read())
                {
                    _objetoSalon = new Salon();
                    _objetoClase = new Clase();
                    _objetoInstructor = new Instructor();

                    _objetoClaseSalon.Id = Convert.ToInt32(_dr.GetValue(0));
                    _objetoClase.Nombre = _dr.GetValue(1).ToString();
                    _objetoSalon.Ubicacion = _dr.GetValue(2).ToString();
                    _objetoInstructor.NombrePersona1 = _dr.GetValue(3).ToString();
                    _objetoClaseSalon.Disponibilidad = Convert.ToInt32(_dr.GetValue(4));

                    _objetoClaseSalon = new ClaseSalon(_objetoSalon, _objetoClase, _objetoInstructor);

                    _listaClaseSalon.Add(_objetoClaseSalon);
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
            return _listaClaseSalon;
        }

        #endregion

    }
}