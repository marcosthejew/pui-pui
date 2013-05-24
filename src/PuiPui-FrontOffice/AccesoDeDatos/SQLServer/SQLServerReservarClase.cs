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
using PuiPui_FrontOffice.Entidades;
using PuiPui_FrontOffice.Entidades.Clase;
using PuiPui_FrontOffice.LogicaDeNegocios.ReservarClase;
using PuiPui_FrontOffice.Entidades.ReservarClase;


namespace PuiPui_FrontOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerReservarClase
    {

        IConexionSqlServer db = new ConexionSqlServer();

        #region Clases Disponibles
        
        public List<Clase> ListarClasesDisponibles()
        {
            //string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            string cadenaConexion = "Data Source=DT_DESARROLLO\\SQLEXPRESS;Initial Catalog=puipuiDB;Integrated Security=True";
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            Clase objetoClase = new Clase();
            List<Clase> miLista = new List<Clase>();

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[ListarClases]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                while (dr.Read())
                {

                    objetoClase = new Clase();

                    objetoClase.IdClase = Convert.ToInt32(dr.GetValue(0));
                    objetoClase.Nombre = dr.GetValue(1).ToString();
                    //objetoClase.Status = Convert.ToInt32(dr.GetValue(2));

                    miLista.Add(objetoClase);
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

        #region Buscar Horarios Reservacion Clase

        public List<HorarioReservacionClase> ListarHorariosDisponibles(int idClase)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            //string cadenaConexion = "Data Source=DT_DESARROLLO\\SQLEXPRESS;Initial Catalog=puipuiDB;Integrated Security=True";
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            HorarioReservacionClase objetoHorario = new HorarioReservacionClase();
            List<HorarioReservacionClase> miLista = new List<HorarioReservacionClase>();

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[SPHorariosDisponiblesPorClase]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idClase", idClase);
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                while (dr.Read())
                {

                    objetoHorario = new HorarioReservacionClase();
                    objetoHorario.HoraReserva = Convert.ToInt32(dr.GetValue(0));
                    objetoHorario.Horario = dr.GetValue(1).ToString();
                  
                   
                    miLista.Add(objetoHorario);
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

        #region Listar Instructores Disponibles

        public List<InstructorClase> ListarInstructoresDisponibles(int idHorario)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            //string cadenaConexion = "Data Source=DT_DESARROLLO\\SQLEXPRESS;Initial Catalog=puipuiDB;Integrated Security=True";
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            InstructorClase objetoInstructor = new InstructorClase();
            List<InstructorClase> miLista = new List<InstructorClase>();

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[SPInstructoresDisponiblesPorHorario]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idHorario", idHorario);
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                while (dr.Read())
                {

                    objetoInstructor = new InstructorClase();
                    objetoInstructor.Idinstructor = Convert.ToInt32(dr.GetValue(0));
                    objetoInstructor.Nombre = dr.GetValue(1).ToString();


                    miLista.Add(objetoInstructor);
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
    }
}