using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPui_FrontOffice.Entidades.Ejercicio;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion.IConexion;
using PuiPui_FrontOffice.AccesoDeDatos.Excepciones_BD;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PuiPui_FrontOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerEjercicio
    {
        IConexionSqlServer db = new ConexionSqlServer();
        string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
        #region ExisteEjercicio
        public bool ExisteEjercicio(string nombreEjercicio)
        {
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";//ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();

            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[existeEjercicio]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreEjercicio", nombreEjercicio);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                    exito = true;

                db.CerrarConexion();
            }
            catch (ArgumentException e)
            {
                throw new EjercicioBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new EjercicioBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new EjercicioBDException("ejercicio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new EjercicioBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new EjercicioBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
            return exito;
        }
        #endregion ExisteEjercicio

        #region InsertarEjercicio
        public bool InsertarEjercicio(string nombreEjercicio, String descripcion, int musculo)
        {
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";//ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();

            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            bool exito = false;
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
                exito = true;
                db.CerrarConexion();
            }
            catch (ArgumentException e)
            {
                throw new EjercicioBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new EjercicioBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new EjercicioBDException("ejercicio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new EjercicioBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new EjercicioBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
            return exito;
        }
        #endregion InsertarEjercicio

        #region ConsultarEjercicios
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
            catch (ArgumentException e)
            {
                throw new EjercicioBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new EjercicioBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new EjercicioBDException("ejercicio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new EjercicioBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new EjercicioBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
            return null;
        }
        #endregion ConsultarEjercicios

        #region ConsultarEjercicio
        public Ejercicio ConsultarEjercicio(string nombre)
        {
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";//ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();

            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
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
            catch (ArgumentException e)
            {
                throw new EjercicioBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new EjercicioBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new EjercicioBDException("ejercicio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new EjercicioBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new EjercicioBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
        }
        #endregion ConsultarEjercicio

        #region ExisteRutinaConEjercicio
        public bool ExisteRutinaConEjercicio(string nombreEjercicio)
        {
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";//ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();

            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            bool existe = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[existeRutinaConEjercicio]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreEjercicio", nombreEjercicio);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                    existe = true;

                db.CerrarConexion();
            }
            catch (ArgumentException e)
            {
                throw new EjercicioBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new EjercicioBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new EjercicioBDException("ejercicio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new EjercicioBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new EjercicioBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
            return existe;
        }
        #endregion ExisteRutinaConEjercicio

        #region EliminarEjercicio
        public void EliminarEjercicio(string nombreEjercicio)
        {
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";//ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();

            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[eliminarEjercicio]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreEjercicio", nombreEjercicio);
                dr = cmd.ExecuteReader();

                db.CerrarConexion();
            }
            catch (ArgumentException e)
            {
                throw new EjercicioBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new EjercicioBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new EjercicioBDException("ejercicio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new EjercicioBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new EjercicioBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }

        }
        #endregion EliminarEjercicio

        #region ActualizarEjercicio
        public void ActualizarEjercicio(Ejercicio ejercicio, int idMusculo)
        {
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";//ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();

            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[actualizarEjercicio]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEjercicio", ejercicio.Id);
                cmd.Parameters.AddWithValue("@nombreEjercicio", ejercicio.Nombre);
                cmd.Parameters.AddWithValue("@descripcionEjercicio", ejercicio.Descripcion);
                cmd.Parameters.AddWithValue("@idMusculo", idMusculo);

                dr = cmd.ExecuteReader();
                db.CerrarConexion();
            }
            catch (ArgumentException e)
            {
                throw new EjercicioBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new EjercicioBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new EjercicioBDException("ejercicio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new EjercicioBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new EjercicioBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }

        }
        #endregion ActualizarEjercicio

        #region ExisteEjercicioOtroId
        public bool ExisteEjercicioOtroId(string nombreEjercicio, int idEjercicio)
        {
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";//ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();

            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[existeNombreOtroId]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreEjercicio", nombreEjercicio);
                cmd.Parameters.AddWithValue("@idEjercicio", idEjercicio);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                    exito = true;

                db.CerrarConexion();
            }
            catch (ArgumentException e)
            {
                throw new EjercicioBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new EjercicioBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new EjercicioBDException("ejercicio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new EjercicioBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new EjercicioBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
            return exito;
        }
        #endregion ExisteEjercicioOtroId

        public Ejercicio ConsultarEjercicioId(int id_ejercicio)
        {
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";//ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            List<Ejercicio> lista_ejercicios = new List<Ejercicio>();

            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarEjercicioId]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEjercicio", id_ejercicio);
                dr = cmd.ExecuteReader();
                Ejercicio ejercicio = new Ejercicio();

                while (dr.Read())
                {
                    ejercicio.Id = Convert.ToInt32(dr.GetValue(0));
                    ejercicio.Nombre = dr.GetValue(1).ToString();
                    lista_ejercicios.Add(ejercicio);
                }

                db.CerrarConexion();
                return ejercicio;
            }
            catch (ArgumentException e)
            {
                throw new EjercicioBDException("Parametros invalidos", e);
            }
            catch (InvalidOperationException e)
            {
                throw new EjercicioBDException("Operacion Invalida", e);
            }
            catch (NullReferenceException e)
            {
                throw new EjercicioBDException("ejercicio no encontrado", e);
            }
            catch (SqlException e)
            {
                throw new EjercicioBDException("Error con base de datos", e);
            }
            catch (Exception e)
            {
                throw new EjercicioBDException("Error general", e);
            }
            finally
            {
                db.CerrarConexion();
            }
        }
    }
}