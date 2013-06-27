using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Excepciones;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios
{
    /// <summary>
    /// Esta clase tiene como finalidad realizar operaciones referentes a la 
    /// entidad Musculo en la base de datos de SQL Server de la capa de 
    /// datos.
    /// </summary>
    public class MusculoSQLServerDAO : ASQLServerDAO, IMusculoDAO
    {
        #region Atributos

        SqlConnection _conexion;
        SqlCommand _cmd;
        SqlDataReader _dr;

        #endregion

        /// <summary>
        /// Devuelve una lista con todas las entidades activas de Musculo 
        /// que se encuentran en la base de datos de SQL Server de la capa de 
        /// datos.
        /// </summary>
        /// <returns></returns>
        public List<AEntidad> ConsultarTodos()
        {
            //Devuelvo esta lista
            List<AEntidad> musculos = new List<AEntidad>();
            try
            {
                _conexion = obtenerConexion();
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[consultarTodosMusculos]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _dr = _cmd.ExecuteReader();

                while (_dr.Read())
                {
                    AEntidad musculo = FabricaEntidad.CrearMusculo();
                    (musculo as Musculo).IdMusculo = Convert.ToInt32(_dr.GetValue(0));
                    (musculo as Musculo).NombreMusculo = _dr.GetValue(1).ToString();
                    (musculo as Musculo).Descripcion = _dr.GetValue(2).ToString();
                    (musculo as Musculo).Status = Convert.ToBoolean(_dr.GetValue(3));

                    musculos.Add(musculo);
                }

            }
            catch (ArgumentException e)
            {
                throw new ExcepcionMusculoConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionMusculoConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionMusculoConexionBD("Musculo no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionMusculoConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionMusculoConexionBD("Error general musculo", e);
            }
            finally
            {
                CerrarConexion(_conexion);
            }
            return musculos;
        }

        /// <summary>
        /// Devuelve la entidad de Musculo activa que se encuentra en la 
        /// base de datos de SQL Server de la capa de datos correspondiente 
        /// al id especificado.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad Musculo que desea consultarse.
        /// </param>
        /// <returns></returns>
        public AEntidad ConsultarPorId(int id)
        {

            AEntidad musculoCompleto = FabricaEntidad.CrearMusculo();

            try
            {
                _conexion = obtenerConexion();
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[buscarMusculoPorId]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@idMusculo", id);
                _dr = _cmd.ExecuteReader();

                if (_dr.Read())
                {
                    (musculoCompleto as Musculo).IdMusculo = Convert.ToInt32(_dr.GetValue(0));
                    (musculoCompleto as Musculo).NombreMusculo = _dr.GetValue(1).ToString();
                    (musculoCompleto as Musculo).Descripcion = _dr.GetValue(2).ToString();
                    (musculoCompleto as Musculo).Status = Convert.ToBoolean(_dr.GetValue(3));

                }

            }
            catch (ArgumentException e)
            {
                throw new ExcepcionMusculoConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionMusculoConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionMusculoConexionBD("Musculo no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionMusculoConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionMusculoConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(_conexion);
            }
            return musculoCompleto;
        }

        /// <summary>
        /// Agrega una entidad de Musculo a la base de datos de SQL Server 
        /// de la capa de datos, retornando el id de dicho registro.
        /// </summary>
        /// <param name="entidad">
        /// la entidad que se desea agregar.
        /// </param>
        /// <returns></returns>
        public int Agregar(AEntidad entidad)
        {
            return 0;
        }

        public bool Agregar(int x, AEntidad entidad)
        {

            bool flag = false;

            try
            {
                _conexion = obtenerConexion();
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[agregarMusculo]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@nombreMusculo", (entidad as Musculo).NombreMusculo);
                _cmd.Parameters.AddWithValue("@descripcionMusculo", (entidad as Musculo).Descripcion);
                _dr = _cmd.ExecuteReader();
                flag = true;

            }
            catch (ArgumentException e)
            {
                throw new ExcepcionMusculoConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionMusculoConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionMusculoConexionBD("Musculo no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionMusculoConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionMusculoConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(_conexion);
            }
            return flag;
        }

        /// <summary>
        /// Inactiva el registro de la entidad Musculo correspondiente al 
        /// id espeficidado de la base de datos de SQL Server de la capa de 
        /// datos. En caso de exito, retorna true. De lo contrario, false.
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
                _conexion = obtenerConexion();
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[eliminarMusculo]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@idMusculo", id);
                _dr = _cmd.ExecuteReader();
                flag = true;
            }
            catch (ArgumentException e)
            {
                throw new ExcepcionMusculoConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionMusculoConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionMusculoConexionBD("Musculo no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionMusculoConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionMusculoConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(_conexion);
            }
            return flag;
        }

        /// <summary>
        /// Modifica la entidad de Musculo correspondiente al id 
        /// especificado con la informacion suministrada en la entidad 
        /// especificada. En caso de exito, retorna true. De lo contrario, 
        /// false.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad de Musculo que se desea modificar.
        /// </param>
        /// <param name="entidad">
        /// la entidad que contiene los nuevos datos de la modificacion.
        /// </param>
        /// <returns></returns>
        public bool Modificar(int id, AEntidad entidad)
        {
            throw new NotImplementedException();
        }


        public bool ExisteMusculo(string nombreMusculo)
        {

            bool flag = false;
            try
            {
                _conexion = obtenerConexion();
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[existeMusculo]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@nombreMusculo", nombreMusculo);
                _dr = _cmd.ExecuteReader();

                if (_dr.Read())
                {
                    flag = true;
                }

            }
            catch (ArgumentException e)
            {
                throw new ExcepcionMusculoConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionMusculoConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionMusculoConexionBD("Musculo no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionMusculoConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionMusculoConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(_conexion);
            }
            return flag;
        }

        public bool ExisteEjercicioConMusculo(int idMusculo)
        {

            bool flag = false;
            try
            {
                _conexion = obtenerConexion();
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[existeEjercicioConMusculo]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@idMusculo", idMusculo);
                _dr = _cmd.ExecuteReader();

                if (_dr.Read())
                {
                    flag = true;
                }
                
            }
            catch (ArgumentException e)
            {
                throw new ExcepcionMusculoConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionMusculoConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionMusculoConexionBD("Musculo no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionMusculoConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionMusculoConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(_conexion);
            }
            return flag;
        }

    }
}