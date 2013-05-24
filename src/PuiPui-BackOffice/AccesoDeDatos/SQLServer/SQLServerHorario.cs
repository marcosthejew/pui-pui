using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PuiPui_BackOffice.Entidades;
using PuiPui_BackOffice.AccesoDeDatos.Conexion;
using PuiPui_BackOffice.AccesoDeDatos.Conexion.IConexion;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_BackOffice.LogicaDeNegocios.Instructor;

namespace PuiPui_BackOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerHorario
    {

        IConexionSqlServer db = new ConexionSqlServer();
        IConexionSqlServer db2 = new ConexionSqlServer();

        #region BuscarId
        public int BuscarId(string cedula)
        {
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[obtenerIdInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedula", cedula);
                
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                if (dr.Read())
                {
                    db.CerrarConexion();
                    return Convert.ToInt32(dr.GetValue(0));
                }
                
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
                throw new EjercicioBDException("Horario no encontrado", e);
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
            return 0;
           }
        #endregion BuscarId

        #region AgregarHorario
        public void agregarHorario(Horario horario,int a)
        {
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[agregarHorario]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dia", horario.dia);
                cmd.Parameters.AddWithValue("@hora_inicio", horario.horaini);
                cmd.Parameters.AddWithValue("@hora_fin", horario.horafin);
                cmd.Parameters.AddWithValue("@id_instructor", a);
                dr = cmd.ExecuteReader();
                 
                db2.CerrarConexion();
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
                throw new EjercicioBDException("Horario no encontrado", e);
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
                db2.CerrarConexion();
            }
           
        }
        #endregion AgregarHorario

        #region ConsultarHorarios
        public List<Horario> ConsultarHorarios(String cedula)
        {
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            string cadenaConexion = "Data Source=localhost;Initial Catalog=puipuiDB;Integrated Security=True";
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
 
            List<Horario> horarios = new List<Horario>();
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarHorariosInstructor]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedula", cedula);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Horario horario = new Horario();
                    horario.dia = dr.GetValue(0).ToString();
                    horario.horaini = DateTime.Parse(dr.GetValue(1).ToString());
                    horario.horafin = DateTime.Parse(dr.GetValue(2).ToString());
                    horarios.Add(horario);
                }
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
                throw new EjercicioBDException("Horario no encontrado", e);
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
            return horarios;
        }
        #endregion ConsultarHorarios



        #region ActualizarHorario
        public void ActualizarHorario(Horario horario, int idInstructor)
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
                cmd = new SqlCommand("[dbo].[actualizarHorario]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idInstructor", idInstructor);
                cmd.Parameters.AddWithValue("@dia", horario.dia);
                cmd.Parameters.AddWithValue("@horaini", horario.horaini);
                cmd.Parameters.AddWithValue("@horafin", horario.horafin);

                dr = cmd.ExecuteReader();
                db.CerrarConexion();
            }
            catch (Exception)
            {

            }
            finally
            {
                db.CerrarConexion();
            }
        }
        #endregion ActualizarHorario

    }
}