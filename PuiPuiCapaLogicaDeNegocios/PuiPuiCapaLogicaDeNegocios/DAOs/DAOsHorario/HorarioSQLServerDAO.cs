using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Excepciones;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsHorario
{
    /// <summary>
    /// Esta clase tiene como finalidad realizar operaciones referentes a la 
    /// entidad Horario en la base de datos de SQL Server de la capa de 
    /// datos.
    /// </summary>
    public class HorarioSQLServerDAO : ASQLServerDAO, IHorarioDAO
    {
        /// <summary>
        /// Devuelve una lista con todas las entidades activas de Horario 
        /// que se encuentran en la base de datos de SQL Server de la capa de 
        /// datos.
        /// </summary>
        /// <returns></returns>
        public List<Entidades.AEntidad> ConsultarTodos()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Devuelve la entidad de Horario activa que se encuentra en la 
        /// base de datos de SQL Server de la capa de datos correspondiente 
        /// al id especificado.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad Horario que desea consultarse.
        /// </param>
        /// <returns></returns>
        public Entidades.AEntidad ConsultarPorId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Agrega una entidad de Horario a la base de datos de SQL Server 
        /// de la capa de datos, retornando el id de dicho registro.
        /// </summary>
        /// <param name="entidad">
        /// la entidad que se desea agregar.
        /// </param>
        /// <returns></returns>
        public int Agregar(Entidades.AEntidad entidad)
        {
            int insercion = 1;
            Entidades.EHorario.Horario horario = (Entidades.EHorario.Horario)entidad;
            SqlConnection conexion = obtenerConexion();
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[agregarHorario]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@hora_inicio", horario.HoraInicio);
                cmd.Parameters.Add(param);
                param = new SqlParameter("@hora_fin", horario.HoraFin);
                cmd.Parameters.Add(param);
                param = new SqlParameter("@dia_semana", horario.DiaSemana);
                cmd.Parameters.Add(param);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                insercion = 0;
                conexion.Close();

            }
            catch (ArgumentException e)
            {
                insercion = 1;
                throw new ExcepcionHorario("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                insercion = 1;
                throw new ExcepcionHorario("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                insercion = 1;
                throw new ExcepcionHorario("Objetos Vacios", e);
            }
            catch (SqlException e)
            {
                insercion = 1;
                throw new ExcepcionHorario("Error con la base de datos", e);
            }
            catch (Exception e)
            {
                insercion = 1;
                throw new ExcepcionHorario("Falla", e);
            }
            finally
            {
                conexion.Close(); ;

            }
            return insercion;
        }

        /// <summary>
        /// Inactiva el registro de la entidad Horario correspondiente al 
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
        /// Modifica la entidad de Horario correspondiente al id 
        /// especificado con la informacion suministrada en la entidad 
        /// especificada. En caso de exito, retorna true. De lo contrario, 
        /// false.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad de Horario que se desea modificar.
        /// </param>
        /// <param name="entidad">
        /// la entidad que contiene los nuevos datos de la modificacion.
        /// </param>
        /// <returns></returns>
        public bool Modificar(int id, Entidades.AEntidad entidad)
        {
            throw new NotImplementedException();
        }
    }
}