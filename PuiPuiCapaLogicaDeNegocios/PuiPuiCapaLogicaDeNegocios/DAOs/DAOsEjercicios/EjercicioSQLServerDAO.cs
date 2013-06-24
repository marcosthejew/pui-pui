using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios;
using PuiPuiCapaLogicaDeNegocios.Excepciones;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios
{
    

    /// <summary>
    /// Esta clase tiene como finalidad realizar operaciones referentes a la
    /// entidad Ejercicio en la base de datos de SQL Server de la capa de 
    /// datos.
    /// </summary>
    public class EjercicioSQLServerDAO : ASQLServerDAO, IEjercicioDAO
    {

        #region Atributos
        private SqlConnection conexion;
        private SqlCommand cmd;
        private SqlDataReader dr;
        #endregion 

        #region Metodos
        /// <summary>
        /// Devuelve una lista con todas las entidades activas de Ejercicio que
        /// se encuentran en la base de datos de SQL Server de la capa de datos.
        /// </summary>
        /// <returns></returns>
        /// 

        public List<AEntidad> ConsultarTodos()
        {
            List<AEntidad> ejercicios = new List<AEntidad>();
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarTodosEjercicios]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                
                

                while (dr.Read())
                {

                    AEntidad ejercicio = FabricaEntidad.CrearEjercicio();
                    (ejercicio as Ejercicio).Id = Convert.ToInt32(dr.GetValue(0));
                    (ejercicio as Ejercicio).Nombre = dr.GetValue(1).ToString();
                    ejercicios.Add(ejercicio);
                }
              
               
            }
            catch (ArgumentException e)
            {
                throw new ExcepcionEjercicioConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionEjercicioConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionEjercicioConexionBD("Ejercicio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionEjercicioConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionEjercicioConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(conexion);
            }
            return ejercicios;
            
        }

        /// <summary>
        /// Devuelve la entidad de Ejercicio activa que se encuentra en la base
        /// de datos de SQL Server de la capa de datos correspondiente al id
        /// especificado.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad Ejercicio que desea consultarse.
        /// </param>
        /// <returns></returns>
        public Entidades.AEntidad ConsultarPorId(int id)
        {
            AEntidad ejercicio = FabricaEntidad.CrearEjercicio();
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarEjercicio]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEjercicio", id);
                dr = cmd.ExecuteReader();
                 if (dr.Read())
                {
                    (ejercicio as Ejercicio).Id = Convert.ToInt32(dr.GetValue(0));
                    (ejercicio as Ejercicio).Nombre = dr.GetValue(1).ToString();
                    (ejercicio as Ejercicio).Descripcion = dr.GetValue(2).ToString();
                    
                    AEntidad musculo = FabricaEntidad.CrearMusculo();
                    (musculo as Musculo).IdMusculo = Convert.ToInt32(dr.GetValue(3));
                    (musculo as Musculo).NombreMusculo = dr.GetValue(4).ToString();
                    (ejercicio as Ejercicio).Musculo = (musculo as Musculo);
                }

               
            }
            catch (ArgumentException e)
            {
                throw new ExcepcionEjercicioConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionEjercicioConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionEjercicioConexionBD("Ejercicio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionEjercicioConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionEjercicioConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(conexion);
            }
            return ejercicio;
            
        }

        /// <summary>
        /// Agrega una entidad de Ejercicio a la base de datos de SQL Server de
        /// la capa de datos, retornando el id de dicho registro.
        /// </summary>
        /// <param name="entidad">
        /// la entidad que se desea agregar.
        /// </param>
        /// <returns></returns>
        public int Agregar(AEntidad entidad)
        {
            
            int exito = 0;

            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[insertarEjercicio]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreEjercicio", (entidad as Ejercicio).Nombre);
                cmd.Parameters.AddWithValue("@descripcionEjercicio", (entidad as Ejercicio).Descripcion);
                cmd.Parameters.AddWithValue("@idMusculo", (entidad as Ejercicio).Musculo);
                dr = cmd.ExecuteReader();
                exito = 1;
            }
            catch (ArgumentException e)
            {
                throw new ExcepcionEjercicioConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionEjercicioConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionEjercicioConexionBD("Ejerciocio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionEjercicioConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionEjercicioConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(conexion);
            }
            return exito;
            
        }

        /// <summary>
        /// Inactiva el registro de la entidad Ejercicio correspondiente al id
        /// espeficidado de la base de datos de SQL Server de la capa de datos.
        /// En caso de exito, retorna true. De lo contrario, false.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad que se desea inactivar.
        /// </param>
        /// <returns></returns>
        public bool Inactivar(int id)
        {
            bool flag = false;
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[eliminarEjercicio]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEjercicio", id);
                dr = cmd.ExecuteReader();
                flag = true;
               
            }
            catch (ArgumentException e)
            {
                throw new ExcepcionEjercicioConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionEjercicioConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionEjercicioConexionBD("Ejerciocio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionEjercicioConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionEjercicioConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(conexion);
            }

            return flag;
        }

        /// <summary>
        /// Modifica la entidad de Ejercicio correspondiente al id especificado
        /// con la informacion suministrada en la entidad especificada. En caso
        /// de exito, retorna true. De lo contrario, false.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad de Ejercicio que se desea modificar.
        /// </param>
        /// <param name="entidad">
        /// la entidad que contiene los nuevos datos de la modificacion.
        /// </param>
        /// <returns></returns>
        public bool Modificar(int id ,AEntidad entidad)
        {
            
            return false;
        }


        public bool Modificar(AEntidad entidad)
        {
            bool flag = false;
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[actualizarEjercicio]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEjercicio", (entidad as Ejercicio).Id);
                cmd.Parameters.AddWithValue("@nombreEjercicio", (entidad as Ejercicio).Nombre);
                cmd.Parameters.AddWithValue("@descripcionEjercicio", (entidad as Ejercicio).Descripcion);
                cmd.Parameters.AddWithValue("@idMusculo", (entidad as Ejercicio).Musculo.IdMusculo);

                dr = cmd.ExecuteReader();

                flag = true;

            }
            catch (ArgumentException e)
            {
                throw new ExcepcionEjercicioConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionEjercicioConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionEjercicioConexionBD("Ejerciocio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionEjercicioConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionEjercicioConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(conexion);
            }
            return flag;
        }

        #region ExisteEjercicio
        public bool ExisteEjercicio(AEntidad ejercicio)
        {
            
            bool flag = false;
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[existeEjercicio]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreEjercicio", (ejercicio as Ejercicio).Nombre);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                    flag = true;

            }
            catch (ArgumentException e)
            {
                throw new ExcepcionEjercicioConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionEjercicioConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionEjercicioConexionBD("Ejerciocio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionEjercicioConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionEjercicioConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(conexion);
            }
            return flag;
        }
        #endregion ExisteEjercicio

        #region ExisteEjercicioOtroId
        public bool ExisteEjercicioOtroId(AEntidad ejercicio)
        {
            
            bool flag = false;
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[existeNombreOtroId]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreEjercicio", (ejercicio as Ejercicio).Nombre);
                cmd.Parameters.AddWithValue("@idEjercicio", (ejercicio as Ejercicio).Id);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                    flag = true;

            }
            catch (ArgumentException e)
            {
                throw new ExcepcionEjercicioConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionEjercicioConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionEjercicioConexionBD("Ejerciocio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionEjercicioConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionEjercicioConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(conexion);
            }
            return flag;
        }
        #endregion ExisteEjercicioOtroId

        #region ExisteRutinaConEjercicio
        public bool ExisteRutinaConEjercicio(AEntidad ejercicio)
        {
            
            bool flag = false;
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[existeRutinaConEjercicio]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreEjercicio", (ejercicio as Ejercicio).Nombre);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                    flag = true;
            }
            catch (ArgumentException e)
            {
                throw new ExcepcionEjercicioConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionEjercicioConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionEjercicioConexionBD("Ejerciocio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionEjercicioConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionEjercicioConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(conexion);
            }
            return flag;
        }
        #endregion ExisteRutinaConEjercicio

        #endregion

    }
}