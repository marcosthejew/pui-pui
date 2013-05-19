using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PuiPui_BackOffice.AccesoDeDatos.Conexion;
using PuiPui_BackOffice.AccesoDeDatos.Conexion.IConexion;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;

namespace PuiPui_BackOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerClase
    {

        IConexionSqlServer db = new ConexionSqlServer();

        public Clase ConsultarDetallePersona(int idClase)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            Clase objetoPersona = new Clase();

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarDetallePersona]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPersona", idClase);
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                while (dr.Read())
                {

                    objetoPersona = new Clase();
/*
                    objetoPersona.IdPersona = Convert.ToInt32(dr.GetValue(0));
                    objetoPersona.CedulaPersona = Convert.ToInt32(dr.GetValue(1));
                    objetoPersona.NombrePersona1 = dr.GetValue(2).ToString();
                    objetoPersona.NombrePersona2 = dr.GetValue(3).ToString();
                    objetoPersona.ApellidoPersona1 = dr.GetValue(4).ToString();
                    objetoPersona.ApellidoPersona2 = dr.GetValue(5).ToString();
                    objetoPersona.GeneroPersona = dr.GetValue(6).ToString();
                    objetoPersona.FechaNacimientoPersona = Convert.ToDateTime(dr.GetValue(7));
                    objetoPersona.FechaIngresoPersona = Convert.ToDateTime(dr.GetValue(8));
                    objetoPersona.CiudadPersona = dr.GetValue(9).ToString();
                    objetoPersona.DireccionPersona = dr.GetValue(10).ToString();
                    objetoPersona.TelefonoLocalPersona = dr.GetValue(11).ToString();
                    objetoPersona.TelefonoCelularPersona = dr.GetValue(12).ToString();
                    objetoPersona.CorreoPersona = dr.GetValue(13).ToString();
                    objetoPersona.ContactoNombrePersona = dr.GetValue(14).ToString();
                    objetoPersona.ContactoTelefonoPersona = dr.GetValue(13).ToString();
                    objetoPersona.EstadoPersona = dr.GetValue(16).ToString();
                    objetoPersona.LoginPersona = dr.GetValue(17).ToString();
                    objetoPersona.PasswordPersona = dr.GetValue(18).ToString();
                    objetoPersona.TipoPersona = dr.GetValue(19).ToString();*/
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
            return objetoPersona;
        }

    }
}