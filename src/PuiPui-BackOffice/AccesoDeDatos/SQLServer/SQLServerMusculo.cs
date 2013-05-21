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
   
    }
}