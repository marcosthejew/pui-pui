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
using PuiPui_BackOffice.LogicaDeNegocios.Ejercicio;

namespace PuiPui_BackOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerMusculo
    {
        IConexionSqlServer db = new ConexionSqlServer();

        public bool ExisteMusculo(string nombreMusculo)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[existeMusculo]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreMusculo", nombreMusculo);
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

        public bool insertarMusculo(string nombreMusculo)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[agregarMusculo]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreMusculo", nombreMusculo);
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

        public List<Musculo> ConsultarMusculos()
        {

            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarTodosMusculos]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                List<Musculo> musculos = new List<Musculo>();

                bool entra = false;

                //Se recorre cada row

                while (dr.Read())
                {
                    entra = true;
                    Musculo musculo = new Musculo();
                    musculo.IdMusculo = Convert.ToInt32(dr.GetValue(0));
                    musculo.NombreMusculo = dr.GetValue(1).ToString();
                    musculos.Add(musculo);
                }
                db.CerrarConexion();
                if (entra)
                    return musculos;
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

        public int BuscarIdMusculo(string nombreMusculo)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            int idMusculo = 0;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[existeMusculo]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreMusculo", nombreMusculo);
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                if (dr.Read())
                    idMusculo = Convert.ToInt32(dr.GetValue(0));


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
            return idMusculo;
        }

        public void EliminarMusculo(int idMusculo)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[eliminarMusculo]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMusculo", idMusculo);
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
        }

        public bool ExisteEjercicioConMusculo(int idMusculo)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            bool existe = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[existeEjercicioConMusculo]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMusculo", idMusculo);
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                if (dr.Read())
                    existe = true;

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
            return existe;
        }
    }
}