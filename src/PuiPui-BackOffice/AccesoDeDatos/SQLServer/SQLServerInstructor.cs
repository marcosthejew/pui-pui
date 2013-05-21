using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PuiPui_BackOffice.Entidades.Ejercicio;
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
    }
}