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

        #region ExisteMusculo
        public bool ExisteMusculo(string nombreMusculo)
        {
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
            //ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            bool existe = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[existeMusculo]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreMusculo", nombreMusculo);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                    existe = true;

                db.CerrarConexion();
            }
            catch (ArgumentException e)
            {
                 throw new MusculoBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                 throw new MusculoBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new MusculoBDException("Musculo no encontrado", e);
            }
            catch (SqlException e)
            { 
                throw new MusculoBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new MusculoBDException("Error general", e);  
            }
            finally
            {
                db.CerrarConexion();
            }
            return existe;
        }
        #endregion ExisteMusculo

        #region InsertarMusculo
        public bool InsertarMusculo(string nombreMusculo)
        {
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
            //ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            bool inserto = false;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[agregarMusculo]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreMusculo", nombreMusculo);
                dr = cmd.ExecuteReader();
                inserto = true;
                db.CerrarConexion();
            }
            catch (ArgumentException e)
            {
                throw new MusculoBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new MusculoBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new MusculoBDException("Musculo no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new MusculoBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new MusculoBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
            return inserto;
        }
        #endregion InsertarMusculo

        #region ConsultarMusculos
        public List<Musculo> ConsultarMusculos()
        {
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
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
            catch (ArgumentException e)
            {
                throw new MusculoBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new MusculoBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new MusculoBDException("Musculo no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new MusculoBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new MusculoBDException("Error general musculo", e);
            }
            finally
            {
                db.CerrarConexion();
            }
            return null;
        }
        #endregion ConsultarMusculos

        #region BuscarIdMusculo
        public int BuscarIdMusculo(string nombreMusculo)
        {
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
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

                if (dr.Read())
                    idMusculo = Convert.ToInt32(dr.GetValue(0));

                db.CerrarConexion();
            }
            catch (ArgumentException e)
            {
                throw new MusculoBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new MusculoBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new MusculoBDException("Musculo no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new MusculoBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new MusculoBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
            return idMusculo;
        }
        #endregion BuscarIdMusculo

        #region EliminarMusculo
        public void EliminarMusculo(int idMusculo)
        {
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
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
            catch (ArgumentException e)
            {
                throw new MusculoBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new MusculoBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new MusculoBDException("Musculo no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new MusculoBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new MusculoBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
        }
        #endregion EliminarMusculo

        #region ExisteEjercicioConMusculo
        public bool ExisteEjercicioConMusculo(int idMusculo)
        {
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
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

                if (dr.Read())
                    existe = true;

                db.CerrarConexion();
            }
            catch (ArgumentException e)
            {
                throw new MusculoBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new MusculoBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new MusculoBDException("Musculo no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new MusculoBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new MusculoBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
            return existe;
        }
        #endregion ExisteEjercicioConMusculo
    }
}