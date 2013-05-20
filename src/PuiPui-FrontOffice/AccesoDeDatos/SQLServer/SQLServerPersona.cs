using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion.IConexion;
using PuiPui_FrontOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_FrontOffice.Entidades.Cliente;
using PuiPui_FrontOffice.LogicaDeNegocios.Cliente;

namespace PuiPui_FrontOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerPersona
    {
        IConexionSqlServer db = new ConexionSqlServer();

        #region ConsultarPersona
        public List<Persona> ConsultarPersona()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            Persona objetoPersona = new Persona();
            List<Persona> miLista = new List<Persona>();

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarPersona]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                while (dr.Read())
                {

                    objetoPersona = new Persona();


                    objetoPersona.IdPersona = Convert.ToInt32(dr.GetValue(0));
                    objetoPersona.NombrePersona1 = dr.GetValue(1).ToString();
                    objetoPersona.ApellidoPersona1 = dr.GetValue(2).ToString();
                    objetoPersona.FechaIngresoPersona = Convert.ToDateTime(dr.GetValue(3));


                    miLista.Add(objetoPersona);
                }

                db.CerrarConexion();

            }
            catch (SqlException error)
            {
                //En caso de que se viole alguna restriccion sobre la BD
                throw (new ExcepcionConexion(("Error: " + error.Message), error));
            }
            finally
            {
                db.CerrarConexion();
            }
            return miLista;
        }
        #endregion

        #region ConsultarDetallePersona
        public Persona ConsultarDetallePersona(int idPersona)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            Persona objetoPersona = new Persona();

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarDetallePersona]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPersona", idPersona);
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                while (dr.Read())
                {

                    objetoPersona = new Persona();

                    objetoPersona.IdPersona = Convert.ToInt32(dr.GetValue(0));
                    objetoPersona.CedulaPersona = Convert.ToInt32(dr.GetValue(1));
                    objetoPersona.NombrePersona1 = dr.GetValue(2).ToString();
                    objetoPersona.NombrePersona2 = dr.GetValue(3).ToString();
                    objetoPersona.ApellidoPersona1 = dr.GetValue(4).ToString();
                    objetoPersona.ApellidoPersona2 = dr.GetValue(5).ToString();
                    objetoPersona.GeneroPersona = dr.GetValue(6).ToString();
                    objetoPersona.FechaNacimientoPersona = Convert.ToDateTime(dr.GetValue(7));
                    objetoPersona.FechaIngresoPersona = Convert.ToDateTime(dr.GetValue(8));
                    objetoPersona.CiudadPersona = dr.GetValue(9).ToString();
                    objetoPersona.DireccionPersona = dr.GetValue(10).ToString();
                    objetoPersona.TelefonoLocalPersona = dr.GetValue(11).ToString();
                    objetoPersona.TelefonoCelularPersona = dr.GetValue(12).ToString();
                    objetoPersona.CorreoPersona = dr.GetValue(13).ToString();
                    objetoPersona.ContactoNombrePersona = dr.GetValue(14).ToString();
                    objetoPersona.ContactoTelefonoPersona = dr.GetValue(13).ToString();
                    objetoPersona.EstadoPersona = dr.GetValue(16).ToString();
                    objetoPersona.LoginPersona = dr.GetValue(17).ToString();
                    objetoPersona.PasswordPersona = dr.GetValue(18).ToString();
                    objetoPersona.TipoPersona = dr.GetValue(19).ToString();
                }

                db.CerrarConexion();

            }
            catch (SqlException error)
            {
                //En caso de que se viole alguna restriccion sobre la BD
                throw (new ExcepcionConexion(("Error: " + error.Message), error));
            }
            finally
            {
                db.CerrarConexion();
            }
            return objetoPersona;
        }
        #endregion

        #region AgregarCliente
        public Persona AgregarCliente(Persona miPersona)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            Persona objPersona = new Persona();

            try
            {
                string fechaRegistro = DateTime.Now.ToString("dd-MM-yyyy");
                miPersona.FechaIngresoPersona = Convert.ToDateTime(fechaRegistro);

                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[insertarCliente]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;



                cmd.Parameters.AddWithValue("@cedulaCliente", miPersona.CedulaPersona);
                cmd.Parameters.AddWithValue("@primerNombreCliente", miPersona.NombrePersona1);
                cmd.Parameters.AddWithValue("@segundoNombreCliente", miPersona.NombrePersona2);
                cmd.Parameters.AddWithValue("@primerApellidoCliente", miPersona.ApellidoPersona1);
                cmd.Parameters.AddWithValue("@segundoaApellidoCliente", miPersona.ApellidoPersona2);
                cmd.Parameters.AddWithValue("@genero", miPersona.GeneroPersona);
                cmd.Parameters.AddWithValue("@fechaNacimiento", miPersona.FechaNacimientoPersona);
                cmd.Parameters.AddWithValue("@fechaRegistro", miPersona.FechaIngresoPersona);
                cmd.Parameters.AddWithValue("@ciudad", miPersona.CiudadPersona);
                cmd.Parameters.AddWithValue("@direccion", miPersona.DireccionPersona);
                cmd.Parameters.AddWithValue("@telefonoLocal", miPersona.TelefonoLocalPersona);
                cmd.Parameters.AddWithValue("@telefonoCelular", miPersona.TelefonoCelularPersona);
                cmd.Parameters.AddWithValue("@email", miPersona.CorreoPersona);
                cmd.Parameters.AddWithValue("@nombreContactoEmergencia", miPersona.ContactoNombrePersona);
                cmd.Parameters.AddWithValue("@telefonoContactoEmergencia", miPersona.ContactoTelefonoPersona);
                cmd.Parameters.AddWithValue("@estado", miPersona.EstadoPersona);
                cmd.Parameters.AddWithValue("@usuario", miPersona.LoginPersona);
                cmd.Parameters.AddWithValue("@password", miPersona.PasswordPersona);
                cmd.Parameters.AddWithValue("@tipo", miPersona.TipoPersona);


                dr = cmd.ExecuteReader();
                db.CerrarConexion();
            }
            catch (SqlException error)
            {
                //En caso de que se viole alguna restriccion sobre la BD
                throw (new ExcepcionConexion(("Error: " + error.Message), error));
            }
            finally
            {
                db.CerrarConexion();
            }
            return objPersona;
        }
        #endregion

        #region Modificar Persona
        public bool ModificarPersona(Persona nuevaPersona)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[modificarPersona]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPersona", nuevaPersona.IdPersona);
                cmd.Parameters.AddWithValue("@cedulaPersona", nuevaPersona.CedulaPersona);
                cmd.Parameters.AddWithValue("@nombrePersona1", nuevaPersona.NombrePersona1);
                cmd.Parameters.AddWithValue("@nombrePersona2", nuevaPersona.NombrePersona2);
                cmd.Parameters.AddWithValue("@apellidoPersona1", nuevaPersona.ApellidoPersona1);
                cmd.Parameters.AddWithValue("@apellidoPersona2", nuevaPersona.ApellidoPersona2);
                cmd.Parameters.AddWithValue("@generoPersona", nuevaPersona.GeneroPersona);
                cmd.Parameters.AddWithValue("@fechaNacimientoPersona", nuevaPersona.FechaNacimientoPersona);
                cmd.Parameters.AddWithValue("@fechaIngresoPersona", nuevaPersona.FechaIngresoPersona);
                cmd.Parameters.AddWithValue("@ciudadPersona", nuevaPersona.CiudadPersona);
                cmd.Parameters.AddWithValue("@direccionPersona", nuevaPersona.DireccionPersona);
                cmd.Parameters.AddWithValue("@telefonoLocalPersona", nuevaPersona.TelefonoLocalPersona);
                cmd.Parameters.AddWithValue("@telefonoCelularPersona", nuevaPersona.TelefonoCelularPersona);
                cmd.Parameters.AddWithValue("@correoPersona", nuevaPersona.CorreoPersona);
                cmd.Parameters.AddWithValue("@contactoNombrePersona", nuevaPersona.ContactoNombrePersona);
                cmd.Parameters.AddWithValue("@contactoTelefonoPersona", nuevaPersona.ContactoTelefonoPersona);
                cmd.Parameters.AddWithValue("@estadoPersona", nuevaPersona.EstadoPersona);
                cmd.Parameters.AddWithValue("@loginPersona", nuevaPersona.LoginPersona);
                cmd.Parameters.AddWithValue("@passwordPersona", nuevaPersona.PasswordPersona);
                cmd.Parameters.AddWithValue("@tipoPersona", nuevaPersona.TipoPersona);

                dr = cmd.ExecuteReader();
                dr.Read();
                db.CerrarConexion();
                return true;
            }
            catch (SqlException error)
            {
                //En caso de que se viole alguna restriccion sobre la BD
                throw (new ExcepcionConexion(("Error: " + error.Message), error));
                return false;
            }

            finally
            {
                db.CerrarConexion();
            }
        }
        #endregion

        #region ConsultarActivarDesactivarPersona
        public List<Persona> ConsultarActivarDesactivarPersona()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            Persona objetoPersona = new Persona();
            List<Persona> miLista = new List<Persona>();

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarActivarDesactivarPersona]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                while (dr.Read())
                {

                    objetoPersona = new Persona();


                    objetoPersona.IdPersona = Convert.ToInt32(dr.GetValue(0));
                    objetoPersona.NombrePersona1 = dr.GetValue(1).ToString();
                    objetoPersona.ApellidoPersona1 = dr.GetValue(2).ToString();
                    objetoPersona.EstadoPersona = dr.GetValue(3).ToString();


                    miLista.Add(objetoPersona);
                }

                db.CerrarConexion();

            }
            catch (SqlException error)
            {
                //En caso de que se viole alguna restriccion sobre la BD
                throw (new ExcepcionConexion(("Error: " + error.Message), error));
            }
            finally
            {
                db.CerrarConexion();
            }
            return miLista;
        }
        #endregion

        #region ActivarDesactivarPersona
        public bool ActivarDesactivarPersona(Persona persona)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            List<Persona> miLista = new List<Persona>();

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[ActivarDesactivarPersona]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@estadoPersona", persona.EstadoPersona);
                cmd.Parameters.AddWithValue("@idPersona", persona.IdPersona);
                dr = cmd.ExecuteReader();

                dr.Read();
                db.CerrarConexion();
                return true;

            }
            catch (SqlException error)
            {
                //En caso de que se viole alguna restriccion sobre la BD
                throw (new ExcepcionConexion(("Error: " + error.Message), error));
            }
            finally
            {
                db.CerrarConexion();
            }
            return false;
        }
        #endregion

        #region ConsultarAccesoPersona
        public bool ConsultarAccesoPersona(Acceso persona)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            Acceso objAcceso = new Acceso();

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarAccesoPersonaF]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@loginPersona", persona.Login);
                cmd.Parameters.AddWithValue("@passwordPersona", persona.Password);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                    return true;
                db.CerrarConexion();

            }
            catch (SqlException error)
            {
                //En caso de que se viole alguna restriccion sobre la BD
                throw (new ExcepcionConexion(("Error: " + error.Message), error));
            }
            finally
            {
                db.CerrarConexion();
            }
            return false;
        }
        #endregion
    }
}