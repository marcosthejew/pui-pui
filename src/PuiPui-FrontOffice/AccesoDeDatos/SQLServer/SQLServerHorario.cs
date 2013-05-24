using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PuiPui_FrontOffice.Entidades;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion.IConexion;
using PuiPui_FrontOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_FrontOffice.LogicaDeNegocios.Instructor;

namespace PuiPui_FrontOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerHorario
    {

        IConexionSqlServer db = new ConexionSqlServer();
        IConexionSqlServer db2 = new ConexionSqlServer();

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
            catch (SqlException error)
            {
                //En caso de que se viole alguna restriccion sobre la BD
                throw (new ExcepcionConexion(("Error: " + error.Message), error));
            }
            finally
            {
                db.CerrarConexion();
            }
            return 0;
        }




        public void agregarHorario(Horario horario, int a)
        {
            // string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
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

                //Se recorre cada row
                if (dr.Read())
                {
                    db2.CerrarConexion();

                }

                db2.CerrarConexion();
            }
            catch (SqlException error)
            {
                //En caso de que se viole alguna restriccion sobre la BD
                throw (new ExcepcionConexion(("Error: " + error.Message), error));
            }
            finally
            {
                db2.CerrarConexion();
            }

        }



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
                // List<Horario> horarios = new List<Horario>();
                bool entra = false;
                //Se recorre cada row

                while (dr.Read())
                {
                    entra = true;
                    Horario horario = new Horario();
                    horario.dia = dr.GetValue(0).ToString();
                    horario.horaini = DateTime.Parse(dr.GetValue(1).ToString());
                    horario.horafin = DateTime.Parse(dr.GetValue(2).ToString());
                    horarios.Add(horario);
                }
                db.CerrarConexion();
                //  if (entra)
                // return horarios;
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
            // return null;
            return horarios;
        }





    }
}