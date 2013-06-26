using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EPersonas;
using PuiPuiCapaLogicaDeNegocios.Excepciones;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsPersonas
{
    /// <summary>
    /// Esta clase tiene como finalidad realizar operaciones referentes a la 
    /// entidad Instructor en la base de datos de SQL Server de la capa de 
    /// datos.
    /// </summary>
    public class InstructorSQLServerDAO : APersonaSQLServerDAO, IInstructorDAO
    {
        #region Atributos

        private SqlConnection conexion;
        private SqlCommand cmd;
        private SqlDataReader dr;

        #endregion

        #region Metodos

        /// <summary>
        /// Devuelve una lista con todas las entidades activas de Instructor 
        /// que se encuentran en la base de datos de SQL Server de la capa de 
        /// datos.
        /// </summary>
        /// <returns></returns>
        public List<Entidades.AEntidad> ConsultarTodos()
        {
            List<AEntidad> instructores = new List<AEntidad>();
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarTodosInstructores]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    AEntidad instructor = FabricaEntidad.CrearInstructor();
                    (instructor as Instructor).Id = Convert.ToInt32(dr.GetValue(0));
                    (instructor as Instructor).CedulaPersona = dr.GetValue(1).ToString();
                    (instructor as Instructor).NombrePersona1 = dr.GetValue(2).ToString();
                    //(instructor as Instructor).NombrePersona2 = dr.GetValue(3).ToString();
                    (instructor as Instructor).ApellidoPersona1 = dr.GetValue(4).ToString();
                    /*(instructor as Instructor).ApellidoPersona2 = dr.GetValue(5).ToString();
                    (instructor as Instructor).GeneroPersona = dr.GetValue(6).ToString();
                    (instructor as Instructor).FechaNacimientoPersona = dr.GetDateTime(7);
                    (instructor as Instructor).FechaIngresoPersona = dr.GetDateTime(8);
                    (instructor as Instructor).EntidadFederal = dr.GetValue(9).ToString();
                    (instructor as Instructor).CiudadPersona = dr.GetValue(10).ToString();
                    (instructor as Instructor).DireccionPersona = dr.GetValue(11).ToString();
                    (instructor as Instructor).TelefonoLocalPersona = dr.GetValue(12).ToString();
                    (instructor as Instructor).TelefonoCelularPersona = dr.GetValue(13).ToString();
                    (instructor as Instructor).CorreoPersona = dr.GetValue(14).ToString();
                    (instructor as Instructor).NombreContactoEmergencia = dr.GetValue(15).ToString();
                    (instructor as Instructor).TelefonoContactoEmergencia = dr.GetValue(16).ToString();
                    (instructor as Instructor).EstadoPersona = dr.GetValue(17).ToString();
                    FALTA HORARIO
                    (instructor as Instructor).Horario = Convert.ToString(dr.GetValue());*/
                    instructores.Add(instructor);
                }
            }
            catch (ArgumentException e)
            {
                throw new ExcepcionInstructorConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionInstructorConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionInstructorConexionBD("Instructor no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionInstructorConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionInstructorConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(conexion);
            }
            return instructores;
        }

        /// <summary>
        /// Devuelve la entidad de Instructor activa que se encuentra en la 
        /// base de datos de SQL Server de la capa de datos correspondiente 
        /// al id especificado.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad Instructor que desea consultarse.
        /// </param>
        /// <returns></returns>
        public Entidades.AEntidad ConsultarPorId(int id)
        {
            AEntidad instructor = FabricaEntidad.CrearInstructor();
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idInstructor", id);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    (instructor as Instructor).Id = Convert.ToInt32(dr.GetValue(0));
                    (instructor as Instructor).CedulaPersona = dr.GetValue(1).ToString();
                    (instructor as Instructor).NombrePersona1 = dr.GetValue(2).ToString();
                    (instructor as Instructor).NombrePersona2 = dr.GetValue(3).ToString();
                    (instructor as Instructor).ApellidoPersona1 = dr.GetValue(4).ToString();
                    (instructor as Instructor).ApellidoPersona2 = dr.GetValue(5).ToString();
                    (instructor as Instructor).GeneroPersona = dr.GetValue(6).ToString();
                    (instructor as Instructor).FechaNacimientoPersona = DateTime.Parse(dr.GetValue(7).ToString());
                    (instructor as Instructor).FechaIngresoPersona = DateTime.Parse(dr.GetValue(8).ToString());
                    //(instructor as Instructor).EntidadFederal = dr.GetValue(9).ToString();
                    (instructor as Instructor).CiudadPersona = dr.GetValue(9).ToString();
                    (instructor as Instructor).DireccionPersona = dr.GetValue(10).ToString();
                    (instructor as Instructor).TelefonoLocalPersona = dr.GetValue(11).ToString();
                    (instructor as Instructor).TelefonoCelularPersona = dr.GetValue(12).ToString();
                    (instructor as Instructor).CorreoPersona = dr.GetValue(13).ToString();
                    (instructor as Instructor).NombreContactoEmergencia = dr.GetValue(14).ToString();
                    (instructor as Instructor).TelefonoContactoEmergencia = dr.GetValue(15).ToString();
                    (instructor as Instructor).EstadoPersona = dr.GetValue(16).ToString();
                }
            }
            catch (ArgumentException e)
            {
                throw new ExcepcionInstructorConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionInstructorConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionInstructorConexionBD("Instructor no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionInstructorConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionInstructorConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(conexion);
            }
            return instructor;
        }

        /// <summary>
        /// Agrega una entidad de Instructor a la base de datos de SQL Server 
        /// de la capa de datos, retornando el id de dicho registro.
        /// </summary>
        /// <param name="entidad">
        /// la entidad que se desea agregar.
        /// </param>
        /// <returns></returns>
        public int Agregar(Entidades.AEntidad entidad)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(int a, Entidades.AEntidad entidad)
        {
            bool _flag = false;
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[agregarInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedula", (entidad as Instructor).CedulaPersona);
                cmd.Parameters.AddWithValue("@primerNombre", (entidad as Instructor).NombrePersona1);
                cmd.Parameters.AddWithValue("@segundoNombre", (entidad as Instructor).NombrePersona2);
                cmd.Parameters.AddWithValue("@primerApellido", (entidad as Instructor).ApellidoPersona1);
                cmd.Parameters.AddWithValue("@segundoApellido", (entidad as Instructor).ApellidoPersona2);
                cmd.Parameters.AddWithValue("@genero", (entidad as Instructor).GeneroPersona);
                cmd.Parameters.AddWithValue("@fechaNacimiento", (entidad as Instructor).FechaNacimientoPersona);
                //cmd.Parameters.AddWithValue("@fechaRegistro", DateTime.Today);
                cmd.Parameters.AddWithValue("@fechaRegistro", (entidad as Instructor).FechaIngresoPersona);
                //cmd.Parameters.AddWithValue("@entidadFederal", (entidad as Instructor).EntidadFederal);
                cmd.Parameters.AddWithValue("@ciudad", (entidad as Instructor).CiudadPersona);
                cmd.Parameters.AddWithValue("@direccion", (entidad as Instructor).DireccionPersona);
                cmd.Parameters.AddWithValue("@telefonoLocal", (entidad as Instructor).TelefonoLocalPersona);
                cmd.Parameters.AddWithValue("@telefonoCelular", (entidad as Instructor).TelefonoCelularPersona);
                cmd.Parameters.AddWithValue("@correoElectronico", (entidad as Instructor).CorreoPersona);
                cmd.Parameters.AddWithValue("@nombreEmergencia", (entidad as Instructor).NombreContactoEmergencia);
                cmd.Parameters.AddWithValue("@contactoEmergencia", (entidad as Instructor).TelefonoContactoEmergencia);
                cmd.Parameters.AddWithValue("@status", (entidad as Instructor).EstadoPersona);
                dr = cmd.ExecuteReader();
                _flag = true;
            }
            catch (ArgumentException e)
            {
                throw new ExcepcionInstructorConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionInstructorConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionInstructorConexionBD("Instructor no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionInstructorConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionInstructorConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(conexion);
            }
            return _flag;
        }

        /// <summary>
        /// Inactiva el registro de la entidad Instructor correspondiente al 
        /// id espeficidado de la base de datos de SQL Server de la capa de 
        /// datos. En caso de exito, retorna true. De lo contrario, false.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad que se desea inactivar.
        /// </param>
        /// <returns></returns>
        public bool Inactivar(int id)
        {
            bool _flag = false;
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[eliminarInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idInstructor", id);
                dr = cmd.ExecuteReader();
                _flag = true;
            }
            catch (ArgumentException e)
            {
                throw new ExcepcionInstructorConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionInstructorConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionInstructorConexionBD("Instructor no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionInstructorConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionInstructorConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(conexion);
            }
            return _flag;
        }

        /// <summary>
        /// Modifica la entidad de Instructor correspondiente al id 
        /// especificado con la informacion suministrada en la entidad 
        /// especificada. En caso de exito, retorna true. De lo contrario, 
        /// false.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad de Instructor que se desea modificar.
        /// </param>
        /// <param name="entidad">
        /// la entidad que contiene los nuevos datos de la modificacion.
        /// </param>
        /// <returns></returns>
        public bool Modificar(int id, Entidades.AEntidad entidad)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifica la entidad de Instructor correspondiente al id 
        /// especificado con la informacion suministrada en la entidad 
        /// especificada. En caso de exito, retorna true. De lo contrario, 
        /// false.
        /// </summary>
        /// <param name="entidad">
        /// la entidad que contiene los nuevos datos de la modificacion.
        /// </param>
        /// <returns></returns>
        public bool Modificar(Entidades.AEntidad entidad)
        {
            bool _flag = false;
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[actualizarInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedula", (entidad as Instructor).CedulaPersona);
                cmd.Parameters.AddWithValue("@primerNombre", (entidad as Instructor).NombrePersona1);
                cmd.Parameters.AddWithValue("@segundoNombre", (entidad as Instructor).NombrePersona2);
                cmd.Parameters.AddWithValue("@primerApellido", (entidad as Instructor).ApellidoPersona1);
                cmd.Parameters.AddWithValue("@segundoApellido", (entidad as Instructor).ApellidoPersona2);
                cmd.Parameters.AddWithValue("@genero", (entidad as Instructor).GeneroPersona);
                cmd.Parameters.AddWithValue("@fechaNacimiento", (entidad as Instructor).FechaNacimientoPersona);
                //cmd.Parameters.AddWithValue("@entidadFederal", (entidad as Instructor).EntidadFederal);
                cmd.Parameters.AddWithValue("@ciudad", (entidad as Instructor).CiudadPersona);
                cmd.Parameters.AddWithValue("@direccion", (entidad as Instructor).DireccionPersona);
                cmd.Parameters.AddWithValue("@telefonoLocal", (entidad as Instructor).TelefonoLocalPersona);
                cmd.Parameters.AddWithValue("@telefonoCelular", (entidad as Instructor).TelefonoCelularPersona);
                cmd.Parameters.AddWithValue("@correoElectronico", (entidad as Instructor).CorreoPersona);
                cmd.Parameters.AddWithValue("@nombreEmergencia", (entidad as Instructor).NombreContactoEmergencia);
                cmd.Parameters.AddWithValue("@contactoEmergencia", (entidad as Instructor).TelefonoContactoEmergencia);
                cmd.Parameters.AddWithValue("@status", (entidad as Instructor).EstadoPersona);
                dr = cmd.ExecuteReader();
                _flag = true;
            }
            catch (ArgumentException e)
            {
                throw new ExcepcionInstructorConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionInstructorConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionInstructorConexionBD("Instructor no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionInstructorConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionInstructorConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(conexion);
            }
            return _flag;
        }

        public bool ExisteInstructor(Entidades.AEntidad entidad)
        {
            bool _flag = false;
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[existeInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedulaInstructor", (entidad as Instructor).CedulaPersona);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                    _flag = true;
            }
            catch (ArgumentException e)
            {
                throw new ExcepcionInstructorConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionInstructorConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionInstructorConexionBD("Instructor no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionInstructorConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionInstructorConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(conexion);
            }
            return _flag;
        }

        public List<Entidades.AEntidad> ConsultarInstructoresActivos()
        {
            List<AEntidad> instructores = new List<AEntidad>();
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarTodosInstructoresActivos]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    AEntidad instructor = FabricaEntidad.CrearInstructor();
                    (instructor as Instructor).Id = Convert.ToInt32(dr.GetValue(0));
                    (instructor as Instructor).CedulaPersona = dr.GetValue(1).ToString();
                    (instructor as Instructor).NombrePersona1 = dr.GetValue(2).ToString();
                    //(instructor as Instructor).NombrePersona2 = dr.GetValue(3).ToString();
                    (instructor as Instructor).ApellidoPersona1 = dr.GetValue(4).ToString();
                    /*(instructor as Instructor).ApellidoPersona2 = dr.GetValue(5).ToString();
                    (instructor as Instructor).GeneroPersona = dr.GetValue(6).ToString();
                    (instructor as Instructor).FechaNacimientoPersona = dr.GetDateTime(7);
                    (instructor as Instructor).FechaIngresoPersona = dr.GetDateTime(8);
                    (instructor as Instructor).EntidadFederal = dr.GetValue(9).ToString();
                    (instructor as Instructor).CiudadPersona = dr.GetValue(10).ToString();
                    (instructor as Instructor).DireccionPersona = dr.GetValue(11).ToString();
                    (instructor as Instructor).TelefonoLocalPersona = dr.GetValue(12).ToString();
                    (instructor as Instructor).TelefonoCelularPersona = dr.GetValue(13).ToString();
                    (instructor as Instructor).CorreoPersona = dr.GetValue(14).ToString();
                    (instructor as Instructor).NombreContactoEmergencia = dr.GetValue(15).ToString();
                    (instructor as Instructor).TelefonoContactoEmergencia = dr.GetValue(16).ToString();
                    (instructor as Instructor).EstadoPersona = dr.GetValue(17).ToString();
                    FALTA HORARIO
                    (instructor as Instructor).Horario = Convert.ToString(dr.GetValue());*/
                    instructores.Add(instructor);
                }
            }
            catch (ArgumentException e)
            {
                throw new ExcepcionInstructorConexionBD("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new ExcepcionInstructorConexionBD("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new ExcepcionInstructorConexionBD("Instructor no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new ExcepcionInstructorConexionBD("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new ExcepcionInstructorConexionBD("Error general", e);
            }
            finally
            {
                CerrarConexion(conexion);
            }
            return instructores;
        }

        #endregion
    }
}