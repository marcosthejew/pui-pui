using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EReservaciones;
using PuiPuiCapaLogicaDeNegocios.Excepciones;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsReservaciones
{
    /// <summary>
    /// Esta clase tiene como finalidad realizar operaciones referentes a la 
    /// entidad ReservacionClase en la base de datos de SQL Server de la capa de
    /// datos.
    /// </summary>
    public class ReservacionClaseSQLServerDAO : AReservacionSQLServerDAO,IReservacionClaseDAO
    {

        #region Atributos
        private SqlConnection conexion;
        private SqlCommand cmd;
        private SqlDataReader dr;
        #endregion 

        #region Metodos

        #region horarios clases
        /// <summary>
        /// Devuelve una lista con todas las entidades activas de 
        /// ReservacionClase que se encuentran en la base de datos de SQL Server
        /// de la capa de datos.
        /// </summary>
        /// <returns></returns>
         public List<AEntidad> ConsultarTodos()
        {

            List<AEntidad> eventos = new List<AEntidad>();

            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarTodosReservacionesCalendario]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
           
                while (dr.Read())
                {
                   eventos.Add(new ReservacionEventoCalendario
                    {
                        id = Convert.ToInt32(dr.GetValue(0)),
                        title = dr.GetValue(1).ToString(),
                        start = dr.GetValue(2).ToString(),
                        end = dr.GetValue(3).ToString(),
                        allDay = false,
                        instructor = dr.GetValue(4).ToString(),
                        cuposDisponibles = Convert.ToInt32(dr.GetValue(5)),
                        status = Convert.ToInt32(dr.GetValue(6)),
                        color = "#CCFF33",
                        textColor = "black"
                    });
                }
            }
            catch (ArgumentException e)
            {
                throw new ExcepcionReservarClaseConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionReservarClaseConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionReservarClaseConexionBD("Ejercicio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionReservarClaseConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionReservarClaseConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(conexion);
            }
            return eventos;

        }
        #endregion
        /// <summary>
        /// Devuelve la entidad de ReservacionClase activa que se encuentra en 
        /// la base de datos de SQL Server de la capa de datos correspondiente
        /// al id especificado.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad ReservacionClase que desea consultarse.
        /// </param>
        /// <returns></returns>
        public Entidades.AEntidad ConsultarPorId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Agrega una entidad de ReservacionClase a la base de datos de SQL 
        /// Server de la capa de datos, retornando el id de dicho registro.
        /// </summary>
        /// <param name="entidad">
        /// la entidad que se desea agregar.
        /// </param>
        /// <returns></returns>
        public int Agregar(Entidades.AEntidad entidad)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Inactiva el registro de la entidad ReservacionClase correspondiente
        /// al id espeficidado de la base de datos de SQL Server de la capa de 
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
        /// Modifica la entidad de ReservacionClase correspondiente al id 
        /// especificado con la informacion suministrada en la entidad 
        /// especificada. En caso de exito, retorna true. De lo contrario, 
        /// false.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad de ReservacionClase que se desea modificar.
        /// </param>
        /// <param name="entidad">
        /// la entidad que contiene los nuevos datos de la modificacion.
        /// </param>
        /// <returns></returns>
        public bool Modificar(int id, Entidades.AEntidad entidad)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}