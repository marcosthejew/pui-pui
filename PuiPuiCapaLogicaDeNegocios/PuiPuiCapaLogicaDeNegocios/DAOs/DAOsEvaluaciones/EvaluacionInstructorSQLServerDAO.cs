using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using PuiPuiCapaLogicaDeNegocios.Excepciones;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEvaluaciones
{
    /// <summary>
    /// Esta clase tiene como finalidad realizar operaciones referentes a la 
    /// entidad EvaluacionInstructor en la base de datos de SQL Server de la 
    /// capa de datos.
    /// </summary>
    public class EvaluacionInstructorSQLServerDAO : ASQLServerDAO, 
                                                    IEvaluacionInstructorDAO
    {


        #region Atributos
        private List<Entidades.AEntidad> _listaEvaluacionInstructor;
        #endregion
        /// <summary>
        /// Devuelve una lista con todas las entidades activas de 
        /// EvaluacionInstructor que se encuentran en la base de datos de SQL 
        /// Server de la capa de datos.
        /// </summary>
        /// <returns></returns>
        public List<Entidades.AEntidad> ConsultarTodos()
        {


            _listaEvaluacionInstructor = new List<Entidades.AEntidad>();
            _listaEvaluacionInstructor.RemoveRange(0, _listaEvaluacionInstructor.Count);
            SqlConnection conexion = obtenerConexion();
            try
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[ListarEvaluacionesInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Entidades.EEvaluaciones.EvaluacionInstructor evalua = (Entidades.EEvaluaciones.EvaluacionInstructor)Fabricas.FabricaEntidad.CrearEvaluacionInstructor();
                    
                    evalua.Id = Convert.ToInt32(dr.GetValue(0));
                    evalua.Fecha = Convert.ToDateTime(dr.GetValue(1));
                    evalua.Calificacion = Convert.ToInt32(dr.GetValue(2));
                    evalua.Inactivo = Convert.ToInt32(dr.GetValue(3));
                    evalua.Observaciones = dr.GetString(4);
                    evalua.idCliente = dr.GetString(5);
                    evalua.idInstructor = dr.GetString(6);

                    _listaEvaluacionInstructor.Add(evalua);

                }
                conexion.Close();
            }
            catch (ArgumentException e)
            {
                throw new ExecpcionEvaluacionInstructor("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExecpcionEvaluacionInstructor("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExecpcionEvaluacionInstructor("Objetos Vacios", e);
            }
            catch (SqlException e)
            {
                throw new ExecpcionEvaluacionInstructor("Error con la base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExecpcionEvaluacionInstructor("Falla", e);
            }
            finally
            {
                conexion.Close();
            }

            return _listaEvaluacionInstructor;             


        }

        /// <summary>
        /// Devuelve la entidad de EvaluacionInstructor activa que se encuentra 
        /// en la base de datos de SQL Server de la capa de datos 
        /// correspondiente al id especificado.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad EvaluacionInstructor que desea consultarse.
        /// </param>
        /// <returns></returns>
        public Entidades.AEntidad ConsultarPorId(int id)
        {            
            Entidades.EEvaluaciones.EvaluacionInstructor evalua = (Entidades.EEvaluaciones.EvaluacionInstructor)Fabricas.FabricaEntidad.CrearEvaluacionInstructor();
            SqlConnection conexion = obtenerConexion();
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[DetalleEvaluacionInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@IdEvaluacionInstructor", id);
                cmd.Parameters.Add(param);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();                
                while (dr.Read())
                {                    
                    evalua.Id = Convert.ToInt32(dr.GetValue(0));
                    evalua.Fecha = Convert.ToDateTime(dr.GetValue(1));
                    evalua.Calificacion = Convert.ToInt32(dr.GetValue(2));
                    evalua.Inactivo = Convert.ToInt32(dr.GetValue(3));
                    evalua.Observaciones = dr.GetString(4);
                    evalua.idCliente = dr.GetString(5);
                    evalua.idInstructor = dr.GetString(6);
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
                conexion.Close();
            }
            return evalua;
        }

        /// <summary>
        /// Agrega una entidad de EvaluacionInstructor a la base de datos de SQL
        /// Server de la capa de datos, retornando el id de dicho registro.
        /// </summary>
        /// <param name="entidad">
        /// la entidad que se desea agregar.
        /// </param>
        /// <returns></returns>
        public int Agregar(Entidades.AEntidad entidad)
        {

            int insercion = 1;
            Entidades.EEvaluaciones.EvaluacionInstructor evaluacion = (Entidades.EEvaluaciones.EvaluacionInstructor)entidad;
            SqlConnection conexion = obtenerConexion();
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[AgregarEvaluacionInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@fecha", evaluacion.Fecha);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@calificacion", evaluacion.Calificacion);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@observaciones", evaluacion.Observaciones);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@inactivo", evaluacion.Inactivo);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@id_cliente", evaluacion.idCliente.Substring(0, evaluacion.idCliente.IndexOf(" ")));
                cmd.Parameters.Add(param);

                param = new SqlParameter("@id_instructor", evaluacion.idInstructor.Substring(0, evaluacion.idInstructor.IndexOf(" ")));
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
                conexion.Close();

            }
            return insercion;
        }

        /// <summary>
        /// Inactiva el registro de la entidad EvaluacionInstructor 
        /// correspondiente al id espeficidado de la base de datos de SQL Server
        /// de la capa de datos. En caso de exito, retorna true. De lo 
        /// contrario , false.
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
        /// Modifica la entidad de EvaluacionInstructor correspondiente al id 
        /// especificado con la informacion suministrada en la entidad 
        /// especificada. En caso de exito, retorna true. De lo contrario, 
        /// false.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad de EvaluacionInstructor que se desea modificar.
        /// </param>
        /// <param name="entidad">
        /// la entidad que contiene los nuevos datos de la modificacion.
        /// </param>
        /// <returns></returns>
        public bool Modificar(int id, Entidades.AEntidad entidad)
        {
            Boolean insercion = false;
            Entidades.EEvaluaciones.EvaluacionInstructor evaluacion = (Entidades.EEvaluaciones.EvaluacionInstructor)entidad;
            SqlConnection conexion = obtenerConexion();
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[ModificarEvaluacionInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@idEvaluacion", evaluacion.Id);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@fecha", evaluacion.Fecha);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@calificacion", evaluacion.Calificacion);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@observaciones", evaluacion.Observaciones);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@inactivo", evaluacion.Inactivo);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@id_cliente", evaluacion.idCliente.Substring(0, evaluacion.idCliente.IndexOf(" ")));
                cmd.Parameters.Add(param);

                param = new SqlParameter("@id_instructor", evaluacion.idInstructor.Substring(0, evaluacion.idInstructor.IndexOf(" ")));
                cmd.Parameters.Add(param);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();

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

                conexion.Close();


            }
            return insercion;

        }
    }
}