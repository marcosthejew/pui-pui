using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_BackOffice.Entidades.Ejercicio;
using PuiPui_BackOffice.AccesoDeDatos.Conexion;
using PuiPui_BackOffice.AccesoDeDatos.Conexion.IConexion;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_BackOffice.LogicaDeNegocios.Ejercicio;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PuiPui_BackOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerEjercicio
    {
        IConexionSqlServer db = new ConexionSqlServer();



        public bool ExisteEjercicio(string nombreEjercicio)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[existeEjercicio]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreEjercicio", nombreEjercicio);
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




        public bool insertarEjercicio(string nombreEjercicio, String descripcion, int musculo)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[insertarEjercicio]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreEjercicio", nombreEjercicio);
                cmd.Parameters.AddWithValue("@descripcionEjercicio", descripcion);
                cmd.Parameters.AddWithValue("@idMusculo", musculo);
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




        public List<Ejercicio> ConsultarEjercicios()
        {

            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();

            SqlConnection conexion = new SqlConnection();

            SqlCommand cmd = new SqlCommand();

            SqlDataReader dr;



            try
            {

                conexion = new SqlConnection(cadenaConexion);

                conexion.Open();

                cmd = new SqlCommand("[dbo].[consultarTodosEjercicios]", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                dr = cmd.ExecuteReader();

                List<Ejercicio> ejercicios = new List<Ejercicio>();

                bool entra = false;

                //Se recorre cada row



                while (dr.Read())
                {

                    entra = true;

                    Ejercicio ejercicio = new Ejercicio();

                    ejercicio.Id = Convert.ToInt32(dr.GetValue(0));

                    ejercicio.Nombre = dr.GetValue(1).ToString();

                    ejercicios.Add(ejercicio);

                }

                db.CerrarConexion();

                if (entra)

                    return ejercicios;

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



        public Ejercicio ConsultarEjercicio(string nombre)
        {

            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();

            SqlConnection conexion = new SqlConnection();

            SqlCommand cmd = new SqlCommand();

            SqlDataReader dr;



            try
            {

                conexion = new SqlConnection(cadenaConexion);

                conexion.Open();

                cmd = new SqlCommand("[dbo].[consultarEjercicio]", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", nombre);

                dr = cmd.ExecuteReader();

                Ejercicio ejercicio = new Ejercicio();



                //Se recorre cada row

                if (dr.Read())
                {

                    ejercicio.Id = Convert.ToInt32(dr.GetValue(0));

                    ejercicio.Nombre = dr.GetValue(1).ToString();

                    ejercicio.Descripcion = dr.GetValue(2).ToString();

                    Musculo musculo = new Musculo();

                    musculo.IdMusculo = Convert.ToInt32(dr.GetValue(3));

                    musculo.NombreMusculo = dr.GetValue(4).ToString();

                    ejercicio.Musculo = musculo;

                }

                db.CerrarConexion();

                return ejercicio;

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