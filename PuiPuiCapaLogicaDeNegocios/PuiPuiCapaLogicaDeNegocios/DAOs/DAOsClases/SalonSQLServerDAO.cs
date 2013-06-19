using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Excepciones;

namespace PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases
{
    /// <summary>
    /// Esta clase tiene como finalidad realizar operaciones referentes a la 
    /// entidad Salon en la base de datos de SQL Server de la capa de 
    /// datos.
    /// </summary>
    public class SalonSQLServerDAO : ASQLServerDAO, ISalonDAO
    {
        
        #region Atributos
        private List<Entidades.AEntidad> listasalon;
        #endregion
        /// <summary>
        /// Devuelve una lista con todas las entidades activas de Salon que se
        /// encuentran en la base de datos de SQL Server de la capa de datos.
        /// </summary>
        /// <returns></returns>
        public List<Entidades.AEntidad> ConsultarTodos()
        {
            listasalon = new List<Entidades.AEntidad>();
            listasalon.RemoveRange(0, listasalon.Count);
            try
            {
                ASQLServerDAO.obtenerConexion().Open();

                SqlCommand cmd = new SqlCommand("[dbo].[ListarSalones]", ASQLServerDAO.obtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Entidades.EClases.Salon salon = (Entidades.EClases.Salon)Fabricas.FabricaEntidad.CrearSalon();
                    salon.IdSalon = Convert.ToInt32(dr.GetValue(0));
                    salon.Ubicacion = dr.GetValue(1).ToString();
                    salon.Capacidad = Convert.ToInt32(dr.GetValue(2));
                    salon.Status = Convert.ToInt32(dr.GetValue(3));
                    listasalon.Add(salon);

                }
                ASQLServerDAO.obtenerConexion().Close();
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
                ASQLServerDAO.obtenerConexion().Close();
            }

            return listasalon;
             

            
        }

        /// <summary>
        /// Devuelve la entidad de Salon activa que se encuentra en la base de
        /// datos de SQL Server de la capa de datos correspondiente al id 
        /// especificado.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad Salon que desea consultarse.
        /// </param>
        /// <returns></returns>
        public Entidades.AEntidad ConsultarPorId(int id)
        {

            throw new NotImplementedException();
        }

        /// <summary>
        /// Agrega una entidad de Salon a la base de datos de SQL Server de la
        /// capa de datos, retornando el id de dicho registro.
        /// </summary>
        /// <param name="entidad">
        /// la entidad que se desea agregar.
        /// </param>
        /// <returns></returns>
        public int Agregar(Entidades.AEntidad entidad)
        {
            int insercion = 1;
            Entidades.EClases.Salon salon = (Entidades.EClases.Salon)Fabricas.FabricaEntidad.CrearSalon();
            try
            {
                ASQLServerDAO.obtenerConexion().Open();
                SqlCommand cmd = new SqlCommand("[dbo].[AgregarSalon]", ASQLServerDAO.obtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@Ubicacion", salon.Ubicacion);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@Capacidad", salon.Capacidad);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@Status", salon.Status);
                cmd.Parameters.Add(param);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                insercion = 0;
                ASQLServerDAO.obtenerConexion().Close();
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
                ASQLServerDAO.obtenerConexion().Close();

            }
            return insercion;
        }

        /// <summary>
        /// Inactiva el registro de la entidad Salon correspondiente al id 
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
        /// Modifica la entidad de Salon correspondiente al id especificado con
        /// la informacion suministrada en la entidad especificada. En caso de
        /// exito, retorna true. De lo contrario, false.
        /// </summary>
        /// <param name="id">
        /// el id de la entidad de Salon que se desea modificar.
        /// </param>
        /// <param name="entidad">
        /// la entidad que contiene los nuevos datos de la modificacion.
        /// </param>
        /// <returns></returns>
        public bool Modificar(int id, Entidades.AEntidad entidad)
        {
            Boolean insercion = false;
            Entidades.EClases.Salon salon = (Entidades.EClases.Salon)Fabricas.FabricaEntidad.CrearSalon();
            try
            {
                 ASQLServerDAO.obtenerConexion().Open();
                 SqlCommand cmd = new SqlCommand("[dbo].[ModificarSalon]", ASQLServerDAO.obtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@Id_salon", salon.IdSalon);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@Ubicacion", salon.Ubicacion);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@Capacidad", salon.Capacidad);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@Status", salon.Status);
                cmd.Parameters.Add(param);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                insercion = true;
                ASQLServerDAO.obtenerConexion().Close();

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
                ASQLServerDAO.obtenerConexion().Close();


            }
            return insercion;

            throw new NotImplementedException();
        }
        /// <summary>
        /// Busca por la ubicacion los salones
        ///  informacion suministrada en la entidad especificada. En caso de 
        /// exito, retorna una lista llena. De lo contrario, 
        /// retorna null.
        /// </summary>
        /// <param name="ubicacion">
        /// ubicacion de los salones.
        /// </param>
        /// <returns></returns>
        /// 
        public List<Entidades.AEntidad> BusquedaUbicacion(String ubicacion)
        {
            listasalon = new List<Entidades.AEntidad>();
            listasalon.RemoveRange(0, listasalon.Count);
            try
            {
                ASQLServerDAO.obtenerConexion().Open();
                SqlCommand cmd = new SqlCommand("[dbo].[BusquedaUbicacionSalon]", ASQLServerDAO.obtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@Ubicacion", ubicacion);
                cmd.Parameters.Add(param);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entidades.EClases.Salon salon = (Entidades.EClases.Salon)Fabricas.FabricaEntidad.CrearSalon();
                    salon.IdSalon = Convert.ToInt32(dr.GetValue(0));
                    salon.Ubicacion = dr.GetValue(1).ToString();
                    salon.Capacidad = Convert.ToInt32(dr.GetValue(2).ToString());
                    salon.Status = Convert.ToInt32(dr.GetValue(3));
                    listasalon.Add(salon);
                }

                ASQLServerDAO.obtenerConexion().Close();

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
                ASQLServerDAO.obtenerConexion().Close();
            }
            return listasalon;
        }
        /// <summary>
        ///Busca por la capacidad de personas los salones
        /// la informacion suministrada en la entidad especificada. En caso de 
        /// exito, retorna una lista llena. De lo contrario, 
        /// retorna null.
        /// </summary>
        /// <param name="capacidad">
        ///capacidad de los salones.
        /// </param>
        /// <returns></returns>
        /// 
        public List<Entidades.AEntidad> BusquedaCapacidadMayorSalon(int capacidad)
        {

            listasalon = new List<Entidades.AEntidad>();
            listasalon.RemoveRange(0, listasalon.Count);
            try
            {

                ASQLServerDAO.obtenerConexion().Open();
                SqlCommand cmd = new SqlCommand("[dbo].[BusquedaCapacidadMayorSalon]", ASQLServerDAO.obtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@Capacidad", capacidad);
                cmd.Parameters.Add(param);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entidades.EClases.Salon salon = (Entidades.EClases.Salon)Fabricas.FabricaEntidad.CrearSalon();
                    salon.IdSalon = Convert.ToInt32(dr.GetValue(0));
                    salon.Ubicacion = dr.GetValue(1).ToString();
                    salon.Capacidad = Convert.ToInt32(dr.GetValue(2).ToString());
                    salon.Status = Convert.ToInt32(dr.GetValue(3));
                    listasalon.Add(salon);
                }

                ASQLServerDAO.obtenerConexion().Close();

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
                ASQLServerDAO.obtenerConexion().Close();
            }
            return listasalon;
        }
        /// <summary>
        /// Busca por capacidad los salones con menor capacidad
        /// la informacion suministrada en la entidad especificada. En caso de 
        /// exito, retorna una lista llena. De lo contrario, 
        /// retorna null.
        /// </summary>
        /// <param name="stat">
        /// capacidad de los salones.
        /// </param>
        /// <returns></returns>
        /// 
        public List<Entidades.AEntidad> BusquedaCapacidadMenorSalon(int stat)
        {
            listasalon = new List<Entidades.AEntidad>();
            listasalon.RemoveRange(0, listasalon.Count);
            try
            {
                ASQLServerDAO.obtenerConexion().Open();
                SqlCommand cmd = new SqlCommand("[dbo].[BusquedaCapacidadMenorSalon]", ASQLServerDAO.obtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@Capacidad", stat);
                cmd.Parameters.Add(param);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entidades.EClases.Salon salon = (Entidades.EClases.Salon)Fabricas.FabricaEntidad.CrearSalon();
                    salon.IdSalon = Convert.ToInt32(dr.GetValue(0));
                    salon.Ubicacion = dr.GetValue(1).ToString();
                    salon.Capacidad = Convert.ToInt32(dr.GetValue(2).ToString());
                    salon.Status = Convert.ToInt32(dr.GetValue(3));
                    listasalon.Add(salon);
                }

                ASQLServerDAO.obtenerConexion().Close();

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
                ASQLServerDAO.obtenerConexion().Close();
            }
            return listasalon;
        }
        /// <summary>
        /// Busca los salones de clase por el estatus
        /// la informacion suministrada en la entidad especificada. En caso de 
        /// exito, retorna una lista llena. De lo contrario, 
        /// retorna null.
        /// </summary>
        /// <param name="stat">
        /// estatus de los salones.
        /// </param>
        /// <returns></returns>
        /// 
        public List<Entidades.AEntidad> BusquedaStatusSalon(int stat)
        {
            listasalon = new List<Entidades.AEntidad>();
            listasalon.RemoveRange(0, listasalon.Count);
            try
            {
                ASQLServerDAO.obtenerConexion().Open();
                SqlCommand cmd = new SqlCommand("[dbo].[BusquedaStatusSalon]", ASQLServerDAO.obtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@Status", stat);
                cmd.Parameters.Add(param);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entidades.EClases.Salon salon = (Entidades.EClases.Salon)Fabricas.FabricaEntidad.CrearSalon();
                    salon.IdSalon = Convert.ToInt32(dr.GetValue(0));
                    salon.Ubicacion = dr.GetValue(1).ToString();
                    salon.Capacidad = Convert.ToInt32(dr.GetValue(2).ToString());
                    salon.Status = Convert.ToInt32(dr.GetValue(3));
                    listasalon.Add(salon);
                }

                ASQLServerDAO.obtenerConexion().Close();

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
                ASQLServerDAO.obtenerConexion().Close();
            }
            return listasalon;
        }
    }
}