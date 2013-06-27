using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.MobileControls;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Excepciones;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases
{
    
    /// <summary>
    /// Esta clase tiene como finalidad realizar operaciones referentes a la 
    /// entidad Clase en la base de datos de SQL Server de la capa de 
    /// datos.
    /// </summary>
    public class ClaseSQLServerDAO : ASQLServerDAO, IClaseDAO
    {
        #region Atributos
        private List<Entidades.AEntidad> listaclase;
        #endregion
        /// <summary>
        /// Devuelve una lista con todas las entidades activas de Clase que se
        /// encuentran en la base de datos de SQL Server de la capa de datos.
        /// </summary>
        /// <returns></returns>
        public List<Entidades.AEntidad> ConsultarTodos()
        {
            listaclase = new List<Entidades.AEntidad>();
            listaclase.RemoveRange(0, listaclase.Count);
            SqlConnection conexion = obtenerConexion();
            try
            {
                conexion.Open();
                
                SqlCommand cmd = new SqlCommand("[dbo].[ListarClases]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Entidades.EClases.Clase clase = (Entidades.EClases.Clase)Fabricas.FabricaEntidad.CrearClase();
                    clase.Id = Convert.ToInt32(dr.GetValue(0));
                    clase.Nombre = dr.GetValue(1).ToString();
                    clase.Status = Convert.ToInt32(dr.GetValue(2));
                    listaclase.Add(clase);

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
            
            return listaclase;
             
               
        }

        /// <summary>
        /// Devuelve la entidad de Clase activa que se encuentra en la base de
        /// datos de SQL Server de la capa de datos correspondiente al id 
        /// especificado.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad Clase que desea consultarse.
        /// </param>
        /// <returns></returns>
        public Entidades.AEntidad ConsultarPorId(int id)
        {
            Entidades.EClases.Clase clase = (Entidades.EClases.Clase)Fabricas.FabricaEntidad.CrearClase();
            SqlConnection conexion = obtenerConexion();
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[DetalleClase]",conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@Idclass", id);
                cmd.Parameters.Add(param);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
               
                while (dr.Read())
                {
                    clase.Nombre = dr.GetValue(0).ToString();
                    clase.Descripcion = dr.GetValue(1).ToString();
                    clase.Status = Convert.ToInt32(dr.GetValue(2));
                }
               conexion.Close();
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
              conexion.Close(); ;
            }
            return clase;
        }

        /// <summary>
        /// Agrega una entidad de Clase a la base de datos de SQL Server de la
        /// capa de datos, retornando el id de dicho registro.
        /// </summary>
        /// <param name="entidad">
        /// la entidad que se desea agregar.
        /// </param>
        /// <returns></returns>
        public int Agregar(Entidades.AEntidad entidad)
        {
            int insercion =1;
            Entidades.EClases.Clase clase =(Entidades.EClases.Clase)entidad ;
            SqlConnection conexion = obtenerConexion();
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[AgregarClase]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@Nombre", clase.Nombre);
                cmd.Parameters.Add(param);
                param = new SqlParameter("@Descripcion", clase.Descripcion);
                cmd.Parameters.Add(param);
                param = new SqlParameter("@Status", clase.Status);
                cmd.Parameters.Add(param);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                insercion =0;
                conexion.Close();

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
             conexion.Close(); ;

            }
            return insercion;
        }

        /// <summary>
        /// Inactiva el registro de la entidad Clase correspondiente al id 
        /// espeficidado de la base de datos de SQL Server de la capa de datos.
        /// En caso de exito, retorna true. De lo contrario, false.
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
        /// Modifica la entidad de Clase correspondiente al id especificado con
        /// la informacion suministrada en la entidad especificada. En caso de 
        /// exito, retorna true. De lo contrario, 
        /// false.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad de Clase que se desea modificar.
        /// </param>
        /// <param name="entidad">
        /// la entidad que contiene los nuevos datos de la modificacion.
        /// </param>
        /// <returns></returns>
        public bool Modificar(int id, Entidades.AEntidad entidad)
        {
            Boolean insercion = false;
            Entidades.EClases.Clase clase = (Entidades.EClases.Clase)entidad;
            SqlConnection conexion = obtenerConexion();
            try
            {
               conexion.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[ModificarClase]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@Id_clase", clase.Id);
                cmd.Parameters.Add(param);
                param = new SqlParameter("@Nombre", clase.Nombre);
                cmd.Parameters.Add(param);
                param = new SqlParameter("@Descripcion", clase.Descripcion);
                cmd.Parameters.Add(param);
                param = new SqlParameter("@Status", clase.Status);
                cmd.Parameters.Add(param);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                insercion = true;
                conexion.Close();

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

        /// <summary>
        /// Busca los nombres de la Clase
        /// la informacion suministrada en la entidad especificada. En caso de 
        /// exito, retorna una lista llena. De lo contrario, 
        /// retorna null.
        /// </summary>
        /// <param name="clase">
        /// Nombre de la clase a buscar.
        /// </param>
        /// <returns></returns>
        public List<Entidades.AEntidad> BusquedaNombreClase(String nombreClase)
        {
            listaclase.RemoveRange(0, listaclase.Count);
            SqlConnection conexion = obtenerConexion();
            try
            {
               conexion.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[BusquedaNombreClase]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@Nombre", nombreClase);
                cmd.Parameters.Add(param);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entidades.EClases.Clase clase = (Entidades.EClases.Clase)Fabricas.FabricaEntidad.CrearClase();
                    clase.Id = Convert.ToInt32(dr.GetValue(0));
                    clase.Nombre = dr.GetValue(1).ToString();
                    clase.Descripcion = dr.GetValue(2).ToString();
                    clase.Status = Convert.ToInt32(dr.GetValue(3));
                    listaclase.Add(clase);
                }

                conexion.Close();

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
            return listaclase;
        }

        /// <summary>
        /// Busca los nombres de la Clase
        /// la informacion suministrada en la entidad especificada. En caso de 
        /// exito, retorna una lista llena. De lo contrario, 
        /// retorna null.
        /// </summary>
        /// <param name="stat">
        /// nombre del status de la clase en el gym.
        /// </param>
        /// <returns></returns>
        /// 
        public List<Entidades.AEntidad> BusquedaStatusClase(int stat)
        {
            listaclase.RemoveRange(0, listaclase.Count);
            SqlConnection conexion = obtenerConexion();
            try
            {
               conexion.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[BusquedaStatusClase]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@Status", stat);
                cmd.Parameters.Add(param);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entidades.EClases.Clase clase = (Entidades.EClases.Clase)Fabricas.FabricaEntidad.CrearClase();
                    clase.Id = Convert.ToInt32(dr.GetValue(0));
                    clase.Nombre = dr.GetValue(1).ToString();
                    clase.Descripcion = dr.GetValue(2).ToString();
                    clase.Status = Convert.ToInt32(dr.GetValue(3));
                    listaclase.Add(clase);
                }

              conexion.Close();

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
            return listaclase;
        }


        
    }
}