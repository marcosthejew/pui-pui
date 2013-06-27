﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.MobileControls;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Excepciones;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Entidades.EPersonas;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases
{
    /// <summary>
    /// Esta clase tiene como finalidad realizar operaciones referentes a la 
    /// entidad ClaseSalon en la base de datos de SQL Server de la capa de 
    /// datos.
    /// </summary>
    public class ClaseSalonSQLServerDAO : ASQLServerDAO, IClaseSalonDAO
    {

        #region Atributos

        private List<Entidades.AEntidad> _listaClaseSalon;
        private Salon _objetoSalon;
        private Instructor _objetoInstructor;


        #endregion

        /// <summary>
        /// Devuelve una lista con todas las entidades activas de ClaseSalon 
        /// que se encuentran en la base de datos de SQL Server de la capa de 
        /// datos.
        /// </summary>
        /// <returns></returns>
        /// 

        public List<Entidades.AEntidad> ConsultarTodos()
        {
            //throw new NotImplementedException();

            _listaClaseSalon = new List<Entidades.AEntidad>();
            _listaClaseSalon.RemoveRange(0, _listaClaseSalon.Count);

            try
            {
                obtenerConexion().Open();

                SqlCommand cmd = new SqlCommand("[dbo].[ListarSalonesClase]", obtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                int idaux = 0, dispaux = 0;

                while (dr.Read())
                {


                    Entidades.EClases.Salon _salon = (Entidades.EClases.Salon)Fabricas.FabricaEntidad.CrearSalon();
                    Entidades.EClases.Clase _clase = (Entidades.EClases.Clase)Fabricas.FabricaEntidad.CrearClase();
                    Entidades.EPersonas.Instructor _instructor = (Entidades.EPersonas.Instructor)Fabricas.FabricaEntidad.CrearClaseSalon();


                    idaux = Convert.ToInt32(dr.GetValue(0));


                    _clase.Nombre = dr.GetValue(1).ToString();
                    _salon.Ubicacion = dr.GetValue(2).ToString();
                    _instructor.NombrePersona1 = dr.GetValue(3).ToString();

                    Entidades.EClases.ClaseSalon _claseSalon = (Entidades.EClases.ClaseSalon)Fabricas.FabricaEntidad.CrearClaseSalon(idaux, _salon, _clase, _instructor, dispaux);

                    _listaClaseSalon.Add(_claseSalon);
                }
                obtenerConexion().Close();
            }
            catch (ArgumentException e)
            {
                throw new ExecpcionClaseSalon("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExecpcionClaseSalon("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExecpcionClaseSalon("Objetos Vacios", e);
            }
            catch (SqlException e)
            {
                throw new ExecpcionClaseSalon("Error con la base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExecpcionClaseSalon("Falla", e);
            }
            finally
            {
                obtenerConexion().Close();
            }




            return _listaClaseSalon;

        }

        /// <summary>
        /// Devuelve la entidad de ClaseSalon activa que se encuentra en la 
        /// base de datos de SQL Server de la capa de datos correspondiente 
        /// al id especificado.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad ClaseSalon que desea consultarse.
        /// </param>
        /// <returns></returns>
        public Entidades.AEntidad ConsultarPorId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Agrega una entidad de ClaseSalon a la base de datos de SQL Server 
        /// de la capa de datos, retornando el id de dicho registro.
        /// </summary>
        /// <param name="entidad">
        /// la entidad que se desea agregar.
        /// </param>
        /// <returns></returns>

        public int Agregar(Entidades.AEntidad entidad)
        {
            //throw new NotImplementedException();

            int insercion = 1;



            Entidades.EClases.ClaseSalon claseSalon = (Entidades.EClases.ClaseSalon)Fabricas.FabricaEntidad.CrearClaseSalon();

            try
            {

                obtenerConexion().Open();
                SqlCommand cmd = new SqlCommand("[dbo].[AgregarSalonClase]", obtenerConexion());

                cmd.CommandType = CommandType.StoredProcedure;

                //"@Id_salon", claseSalon.Salon.IdSalon

                SqlParameter param = new SqlParameter("@Id_salon", claseSalon.Salon.Id);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@Id_clase", claseSalon.Clase.Id);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@Id_Horario", claseSalon.Horario.Id);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@Id_instructor", claseSalon.Instructor.Id);
                cmd.Parameters.Add(param);





                SqlDataReader dr;

                dr = cmd.ExecuteReader();
                insercion = 0;
                obtenerConexion().Close();

            }
            catch (ArgumentException e)
            {
                insercion = 1;
                throw new ExecpcionClaseSalon("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                insercion = 1;
                throw new ExecpcionClaseSalon("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                insercion = 1;
                throw new ExecpcionClaseSalon("Objetos Vacios", e);
            }
            catch (SqlException e)
            {
                insercion = 1;
                throw new ExecpcionClaseSalon("Error con la base de datos", e);
            }
            catch (Exception e)
            {
                insercion = 1;
                throw new ExecpcionClaseSalon("Falla", e);
            }
            finally
            {
                obtenerConexion().Close(); ;

            }
            return insercion;


        }

        /// <summary>
        /// Inactiva el registro de la entidad ClaseSalon correspondiente al 
        /// id espeficidado de la base de datos de SQL Server de la capa de 
        /// datos. En caso de exito, retorna true. De lo contrario, false.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad que se desea inactivar.
        /// </param>
        /// <returns></returns>
        public bool Inactivar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifica la entidad de ClaseSalon correspondiente al id 
        /// especificado con la informacion suministrada en la entidad 
        /// especificada. En caso de exito, retorna true. De lo contrario, 
        /// false.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad de ClaseSalon que se desea modificar.
        /// </param>
        /// <param name="entidad">
        /// la entidad que contiene los nuevos datos de la modificacion.
        /// </param>
        /// <returns></returns>
        public bool Modificar(int id, Entidades.AEntidad entidad)
        {
            //throw new NotImplementedException();

            Boolean insercion = false;

            Entidades.EClases.ClaseSalon _claseSalon = (Entidades.EClases.ClaseSalon)entidad;
            try
            {
                obtenerConexion().Open();
                SqlCommand _cmd = new SqlCommand("[dbo].[ModificarSalonClase]", obtenerConexion());
                _cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter _param = new SqlParameter("@Id_salon", _claseSalon.Salon.Id);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Id_clase", _claseSalon.Clase.Id);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Id_instructor", _claseSalon.Instructor.Id);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@Id_clase_salon", _claseSalon.Id);
                _cmd.Parameters.Add(_param);

                _param = new SqlParameter("@disponibilidad", _claseSalon.Disponibilidad);
                _cmd.Parameters.Add(_param);



                SqlDataReader dr;
                dr = _cmd.ExecuteReader();

                insercion = true;
                obtenerConexion().Close();

            }
            catch (ArgumentException e)
            {
                insercion = false;
                throw new ExecpcionClaseSalon("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                insercion = false;
                throw new ExecpcionClaseSalon("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                insercion = false;
                throw new ExecpcionClaseSalon("Objetos Vacios", e);
            }
            catch (SqlException e)
            {
                insercion = false;
                throw new ExecpcionClaseSalon("Error con la base de datos", e);
            }
            catch (Exception e)
            {
                insercion = false;
                throw new ExecpcionClaseSalon("Falla", e);
            }
            finally
            {
                obtenerConexion().Close();

            }
            return insercion;





        }


        public List<Entidades.AEntidad> ListarSalonesClaseTclase(String nombreClase)
        {
            _listaClaseSalon = new List<Entidades.AEntidad>();
            _listaClaseSalon.RemoveRange(0, _listaClaseSalon.Count);

            try
            {
                obtenerConexion().Open();

                SqlCommand cmd = new SqlCommand("[dbo].[ListarSalonesClaseTclase]", obtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr;
                SqlParameter _param = new SqlParameter("@nombre", nombreClase);

                cmd.Parameters.Add(_param);
                dr = cmd.ExecuteReader();




                int idaux = 0, dispaux = 0;


                while (dr.Read())
                {
                    Entidades.EClases.Salon _salon = (Entidades.EClases.Salon)Fabricas.FabricaEntidad.CrearSalon();
                    Entidades.EClases.Clase _clase = (Entidades.EClases.Clase)Fabricas.FabricaEntidad.CrearClase();
                    Entidades.EPersonas.Instructor _instructor = (Entidades.EPersonas.Instructor)Fabricas.FabricaEntidad.CrearClaseSalon();


                    idaux = Convert.ToInt32(dr.GetValue(0));
                    _clase.Nombre = dr.GetValue(1).ToString();
                    _salon.Ubicacion = dr.GetValue(2).ToString();
                    _instructor.NombrePersona1 = dr.GetValue(3).ToString();
                    dispaux = Convert.ToInt32(dr.GetValue(4));

                    Entidades.EClases.ClaseSalon _claseSalon = (Entidades.EClases.ClaseSalon)Fabricas.FabricaEntidad.CrearClaseSalon(idaux, _salon, _clase, _instructor, dispaux);



                    _listaClaseSalon.Add(_claseSalon);
                }

                obtenerConexion().Close();
            }
            catch (ArgumentException e)
            {
                throw new ExecpcionClaseSalon("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExecpcionClaseSalon("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExecpcionClaseSalon("Objetos Vacios", e);
            }
            catch (SqlException e)
            {
                throw new ExecpcionClaseSalon("Error con la base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExecpcionClaseSalon("Falla", e);
            }
            finally
            {
                obtenerConexion().Close();
            }


            return _listaClaseSalon;


        }

        public List<Entidades.AEntidad> ListarSalonesClaseTsalon(String ubicacion)
        {
            _listaClaseSalon = new List<Entidades.AEntidad>();
            _listaClaseSalon.RemoveRange(0, _listaClaseSalon.Count);

            try
            {

                obtenerConexion().Open();

                SqlCommand cmd = new SqlCommand("[dbo].[ListarSalonesClaseTsalon]", obtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader _dr;
                SqlParameter _param = new SqlParameter("@Ubicacion", ubicacion);

                cmd.Parameters.Add(_param);
                _dr = cmd.ExecuteReader();




                int idaux = 0, dispaux;
                while (_dr.Read())
                {
                    Entidades.EClases.Salon _salon = (Entidades.EClases.Salon)Fabricas.FabricaEntidad.CrearSalon();
                    Entidades.EClases.Clase _clase = (Entidades.EClases.Clase)Fabricas.FabricaEntidad.CrearClase();
                    Entidades.EPersonas.Instructor _instructor = (Entidades.EPersonas.Instructor)Fabricas.FabricaEntidad.CrearClaseSalon();


                    idaux = Convert.ToInt32(_dr.GetValue(0));

                    _clase.Nombre = _dr.GetValue(1).ToString();
                    _salon.Ubicacion = _dr.GetValue(2).ToString();
                    _instructor.NombrePersona1 = _dr.GetValue(3).ToString();
                    dispaux = Convert.ToInt32(_dr.GetValue(4));

                    Entidades.EClases.ClaseSalon _claseSalon = (Entidades.EClases.ClaseSalon)Fabricas.FabricaEntidad.CrearClaseSalon(idaux, _salon, _clase, _instructor, dispaux);




                    _listaClaseSalon.Add(_claseSalon);
                }
                obtenerConexion().Close();


            }
            catch (ArgumentException e)
            {
                throw new ExecpcionClaseSalon("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExecpcionClaseSalon("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExecpcionClaseSalon("Objetos Vacios", e);
            }
            catch (SqlException e)
            {
                throw new ExecpcionClaseSalon("Error con la base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExecpcionClaseSalon("Falla", e);
            }
            finally
            {
                obtenerConexion().Close();
            }
            return _listaClaseSalon;

        }

        public List<Entidades.AEntidad> ListarSalonesClaseTinstructor(String instruc)
        {
            _listaClaseSalon = new List<Entidades.AEntidad>();
            _listaClaseSalon.RemoveRange(0, _listaClaseSalon.Count);

            try
            {

                obtenerConexion().Open();

                SqlCommand cmd = new SqlCommand("[dbo].[ListarSalonesClaseTinstructor]", obtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader _dr;

                SqlParameter _param = new SqlParameter("@Nombre", instruc);

                cmd.Parameters.Add(_param);
                _dr = cmd.ExecuteReader();




                int idaux = 0, dispaux;
                while (_dr.Read())
                {
                    Entidades.EClases.Salon _salon = (Entidades.EClases.Salon)Fabricas.FabricaEntidad.CrearClase();
                    Entidades.EClases.Clase _clase = (Entidades.EClases.Clase)Fabricas.FabricaEntidad.CrearClase();
                    Entidades.EPersonas.Instructor _instructor = (Entidades.EPersonas.Instructor)Fabricas.FabricaEntidad.CrearClaseSalon();


                    idaux = Convert.ToInt32(_dr.GetValue(0));

                    _clase.Nombre = _dr.GetValue(1).ToString();
                    _salon.Ubicacion = _dr.GetValue(2).ToString();
                    _instructor.NombrePersona1 = _dr.GetValue(3).ToString();
                    dispaux = Convert.ToInt32(_dr.GetValue(4));

                    Entidades.EClases.ClaseSalon _claseSalon = (Entidades.EClases.ClaseSalon)Fabricas.FabricaEntidad.CrearClaseSalon(idaux, _salon, _clase, _instructor, dispaux);




                    _listaClaseSalon.Add(_claseSalon);
                }
                obtenerConexion().Close();


            }
            catch (ArgumentException e)
            {
                throw new ExecpcionClaseSalon("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExecpcionClaseSalon("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExecpcionClaseSalon("Objetos Vacios", e);
            }
            catch (SqlException e)
            {
                throw new ExecpcionClaseSalon("Error con la base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExecpcionClaseSalon("Falla", e);
            }
            finally
            {
                obtenerConexion().Close();
            }
            return _listaClaseSalon;

        }

        public List<Entidades.AEntidad> ListarSalonesClaseTdisponible(int stst)
        {
            _listaClaseSalon = new List<Entidades.AEntidad>();
            _listaClaseSalon.RemoveRange(0, _listaClaseSalon.Count);

            try
            {

                obtenerConexion().Open();

                SqlCommand cmd = new SqlCommand("[dbo].[ListarSalonesClaseTdisponible]", obtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader _dr;

                SqlParameter _param = new SqlParameter("@reservacion", stst);

                cmd.Parameters.Add(_param);
                _dr = cmd.ExecuteReader();




                int idaux = 0, dispaux;
                while (_dr.Read())
                {
                    Entidades.EClases.Salon _salon = (Entidades.EClases.Salon)Fabricas.FabricaEntidad.CrearSalon();
                    Entidades.EClases.Clase _clase = (Entidades.EClases.Clase)Fabricas.FabricaEntidad.CrearClase();
                    Entidades.EPersonas.Instructor _instructor = (Entidades.EPersonas.Instructor)Fabricas.FabricaEntidad.CrearClaseSalon();


                    idaux = Convert.ToInt32(_dr.GetValue(0));

                    _clase.Nombre = _dr.GetValue(1).ToString();
                    _salon.Ubicacion = _dr.GetValue(2).ToString();
                    _instructor.NombrePersona1 = _dr.GetValue(3).ToString();
                    dispaux = Convert.ToInt32(_dr.GetValue(4));

                    Entidades.EClases.ClaseSalon _claseSalon = (Entidades.EClases.ClaseSalon)Fabricas.FabricaEntidad.CrearClaseSalon(idaux, _salon, _clase, _instructor, dispaux);




                    _listaClaseSalon.Add(_claseSalon);
                }
                obtenerConexion().Close();


            }
            catch (ArgumentException e)
            {
                throw new ExecpcionClaseSalon("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExecpcionClaseSalon("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExecpcionClaseSalon("Objetos Vacios", e);
            }
            catch (SqlException e)
            {
                throw new ExecpcionClaseSalon("Error con la base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExecpcionClaseSalon("Falla", e);
            }
            finally
            {
                obtenerConexion().Close();
            }
            return _listaClaseSalon;

        }




    }
}