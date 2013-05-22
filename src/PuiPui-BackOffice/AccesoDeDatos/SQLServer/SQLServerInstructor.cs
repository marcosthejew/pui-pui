using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PuiPui_BackOffice.Entidades.Instructor;
using PuiPui_BackOffice.AccesoDeDatos.Conexion;
using PuiPui_BackOffice.AccesoDeDatos.Conexion.IConexion;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_BackOffice.LogicaDeNegocios.Instructor;

namespace PuiPui_BackOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerInstructor
    {
        IConexionSqlServer db = new ConexionSqlServer();




        public bool ExisteInstructor(string tb1)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[existeInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedula", tb1);
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                if (dr.Read())
                {
                    db.CerrarConexion();
                    return true;
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
            return false;

        }



        public bool insertarInstructor(string tb1, string tb2, string tb3, int tb4, string tb5, string tb6, string tb7, int tb8, string tb9, string tb10, string tb11, int tb12, DateTime calendar, string cb)
        {

            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[agregarInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedula", tb1);
                cmd.Parameters.AddWithValue("@primerNombre", tb2);
                cmd.Parameters.AddWithValue("@segundoNombre", tb6);
                cmd.Parameters.AddWithValue("@primerApellido", tb3);
                cmd.Parameters.AddWithValue("@segundoApelldo", tb7);
                cmd.Parameters.AddWithValue("@genero", cb);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", calendar);
                cmd.Parameters.AddWithValue("@fecha_registro", DateTime.Today);
                cmd.Parameters.AddWithValue("@ciudad", tb5);
                cmd.Parameters.AddWithValue("@direccion", tb9);
                cmd.Parameters.AddWithValue("@telefonoLocal", tb4);
                cmd.Parameters.AddWithValue("@telefonoCelular", tb8);
                cmd.Parameters.AddWithValue("@correoElectronico", tb10);
                cmd.Parameters.AddWithValue("@nombreEmergencia", tb11);
                cmd.Parameters.AddWithValue("@contactoEmergencia", tb12);
                cmd.Parameters.AddWithValue("@status", "Activo");
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                if (dr.Read())
                {
                    db.CerrarConexion();
                    return true;
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
            return false;
        }




        public List<Instructor> ConsultarInstructores()
        {

            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarTodosInstructores]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                List<Instructor> instructores = new List<Instructor>();

                bool entra = false;

                //Se recorre cada row

                while (dr.Read())
                {
                    entra = true;
                    Instructor instructor = new Instructor();
                    instructor.IdPersona = Convert.ToInt32(dr.GetValue(0));
                    instructor.CedulaPersona = Convert.ToInt32(dr.GetValue(1));
                    instructor.NombrePersona1 = dr.GetValue(2).ToString();
                    instructor.ApellidoPersona1 = dr.GetValue(3).ToString();
                    instructores.Add(instructor);
                }
                db.CerrarConexion();
                if (entra)
                    return instructores;
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
            return null;
        }




        public Instructor ConsultarIntructor(string cedula)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;



            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedula", cedula);
                dr = cmd.ExecuteReader();
                Instructor instructor1 = new Instructor();

                //Se recorre cada row
                if (dr.Read())
                {
                    //  instructor.IdPersona = Convert.ToInt32(dr.GetValue(0));
                    instructor1.CedulaPersona = Convert.ToInt32(dr.GetValue(0));
                    instructor1.NombrePersona1 = dr.GetValue(1).ToString();
                    instructor1.NombrePersona2 = dr.GetValue(2).ToString();
                    instructor1.ApellidoPersona1 = dr.GetValue(3).ToString();
                    instructor1.ApellidoPersona2 = dr.GetValue(4).ToString();
                    instructor1.GeneroPersona = dr.GetValue(5).ToString();
                    instructor1.FechaNacimientoPersona = DateTime.Parse(dr.GetValue(6).ToString());
                    instructor1.FechaIngresoPersona = DateTime.Parse(dr.GetValue(7).ToString());
                    instructor1.CiudadPersona = dr.GetValue(8).ToString();
                    instructor1.DireccionPersona = dr.GetValue(9).ToString();
                    instructor1.TelefonoLocalPersona = dr.GetValue(10).ToString();
                    instructor1.TelefonoCelularPersona = dr.GetValue(11).ToString();
                    instructor1.CorreoPersona = dr.GetValue(12).ToString();
                    instructor1.ContactoNombrePersona = dr.GetValue(13).ToString();
                    instructor1.ContactoTelefonoPersona = dr.GetValue(14).ToString();
                    instructor1.EstadoPersona = dr.GetValue(15).ToString();
                }
                db.CerrarConexion();
                return instructor1;
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
        }








    }
}