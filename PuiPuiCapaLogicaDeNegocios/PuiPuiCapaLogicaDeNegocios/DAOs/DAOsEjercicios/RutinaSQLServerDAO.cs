using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios;
using PuiPuiCapaLogicaDeNegocios.Excepciones;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios
{
    /// <summary>
    /// Esta clase tiene como finalidad realizar operaciones referentes a la 
    /// entidad Rutina en la base de datos de SQL Server de la capa de 
    /// datos.
    /// </summary>
    public class RutinaSQLServerDAO : ASQLServerDAO, IRutinaDAO
    {
        #region Atributos

        private SqlConnection conexion;
        private SqlCommand cmd;
        private SqlDataReader dr;

        #endregion
        
        #region ConsultarRutinasPorIDCliente
        public List<Rutina> ConsultarRutinasPorIDCliente(int idPersona)
        {

            List<Rutina> listaRutina = new List<Rutina>();
            Rutina objetoRutina;

            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarRutinasPorCliente]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPersona", idPersona);
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                while (dr.Read())
                {

                    objetoRutina = new Rutina();

                    objetoRutina.Id = Convert.ToInt32(dr.GetValue(0));
                    objetoRutina.Nombre = dr.GetValue(1).ToString();
                    objetoRutina.Descripcion = dr.GetValue(2).ToString();
                    objetoRutina.Inactivo = Convert.ToByte(dr.GetValue(3));

                    listaRutina.Add(objetoRutina);
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

            return listaRutina;
        }
        #endregion

        #region ConsultarEjerciciosPorIDRutina
        public List<Ejercicio> ConsultarEjerciciosPorIDRutina(int idRutina)
        {
            List<Ejercicio> listaEjercicio = new List<Ejercicio>();

            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[ConsultarEjerciciosPorIDRutina]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRutina", idRutina);
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                while (dr.Read())
                {
                    Ejercicio objetoEjercicio = new Ejercicio();
                    objetoEjercicio.Id = Convert.ToInt32(dr.GetValue(0));
                    objetoEjercicio.Nombre = dr.GetValue(1).ToString();
                    objetoEjercicio.Descripcion = dr.GetValue(2).ToString();
                    objetoEjercicio.Repeticiones = Convert.ToInt32(dr.GetValue(3));
                    objetoEjercicio.Duracion = dr.GetValue(4).ToString();


                    listaEjercicio.Add(objetoEjercicio);
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
            return listaEjercicio;
        }
        #endregion

        #region ActivarInactivarRutina
        public bool ActivarInactivarRutina(int idRutina, byte inactivo)
        {
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[ActivarDesactivarRutina]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRutina", idRutina);
                cmd.Parameters.AddWithValue("@inactivo", inactivo);
                dr = cmd.ExecuteReader();

                dr.Read();
                return true;

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
            
        }
        #endregion

        #region AgregarRutina
        public bool AgregarRutina(string nombre, string descripcion)
        {
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[insertar_Rutina]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                dr = cmd.ExecuteReader();
                dr.Read();
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
                throw new ExcepcionEjercicioConexionBD("Rutina no agregada", e);
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
            return true;

        }
        #endregion

        #region AgregarHistorialRutina
        public bool AgregarHistorialRutina(string duracion, int repeticion, int cliente, int rutina, int ejercicio)
        {
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[insertar_HistorialEjercicio]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@duracion", duracion);
                cmd.Parameters.AddWithValue("@repeticion", repeticion);
                cmd.Parameters.AddWithValue("@idCliente", cliente);
                cmd.Parameters.AddWithValue("@idRutina", rutina);
                cmd.Parameters.AddWithValue("@idEjercicio", ejercicio);
                cmd.Parameters.AddWithValue("@inactivo", 0);

                dr = cmd.ExecuteReader();


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

            return true;
        }
        #endregion

        #region ConsultarPersonaPorLogin
        public int ConsultarPersonaPorLogin(string loginPersona)
        {
            Entidades.EPersonas.Cliente objetoPersona = (Entidades.EPersonas.Cliente)Fabricas.FabricaEntidad.CrearCliente();

            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarPersonaPorLogin]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@loginPersona", loginPersona);
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                while (dr.Read())
                {

                    objetoPersona = (Entidades.EPersonas.Cliente)Fabricas.FabricaEntidad.CrearCliente();

                    objetoPersona.Id = Convert.ToInt32(dr.GetValue(0));

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
            return objetoPersona.Id;
        }
        #endregion 

        #region ObtenerUltimoIDRutina
        public int ObtenerUltimoIDRutina()
        {
            Entidades.EEjercicios.Rutina objetoRutina = (Entidades.EEjercicios.Rutina)Fabricas.FabricaEntidad.CrearRutina();
            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[buscarUltimoIdRutina]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                while (dr.Read())
                {

                    objetoRutina = (Entidades.EEjercicios.Rutina)Fabricas.FabricaEntidad.CrearRutina();

                    objetoRutina.Id = Convert.ToInt32(dr.GetValue(0));

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
            return objetoRutina.Id;
        }
        #endregion 

        #region ConsultarTodosEjerciciosR
        public List<Ejercicio> ConsultarTodosEjerciciosR()
        {
            List<Ejercicio> listaEjercicio = new List<Ejercicio>();

            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarTodosEjerciciosR]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                while (dr.Read())
                {
                    Ejercicio objetoEjercicio = new Ejercicio();
                    objetoEjercicio.Id = Convert.ToInt32(dr.GetValue(0));
                    objetoEjercicio.Nombre = dr.GetValue(1).ToString();
                    
                    

                    listaEjercicio.Add(objetoEjercicio);
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
            return listaEjercicio;
        }
        #endregion

        #region ConsultarStatusRutinaPorID
        public string ConsultarStatusRutinaPorID(int idRutina)
        {
            string resultado="";

            try
            {
                conexion = obtenerConexion();
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarStatusRutinaPorID]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRutina", idRutina);
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                while (dr.Read())
                {

                    resultado = dr.GetValue(0).ToString();
                    
                }
                return resultado;
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

            
        }
        #endregion


        /// <summary>
        /// Devuelve una lista con todas las entidades activas de Rutina 
        /// que se encuentran en la base de datos de SQL Server de la capa de 
        /// datos.
        /// </summary>
        /// <returns></returns>
        public List<Entidades.AEntidad> ConsultarTodos()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Devuelve la entidad de Rutina activa que se encuentra en la 
        /// base de datos de SQL Server de la capa de datos correspondiente 
        /// al id especificado.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad Rutina que desea consultarse.
        /// </param>
        /// <returns></returns>
        public Entidades.AEntidad ConsultarPorId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Agrega una entidad de Rutina a la base de datos de SQL Server 
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

        /// <summary>
        /// Inactiva el registro de la entidad Rutina correspondiente al 
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
        /// Modifica la entidad de Rutina correspondiente al id 
        /// especificado con la informacion suministrada en la entidad 
        /// especificada. En caso de exito, retorna true. De lo contrario, 
        /// false.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad de Rutina que se desea modificar.
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