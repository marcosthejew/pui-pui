﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PuiPui_BackOffice.AccesoDeDatos.Conexion;
using PuiPui_BackOffice.AccesoDeDatos.Conexion.IConexion;
using PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_BackOffice.Entidades.Cliente;
using PuiPui_BackOffice.LogicaDeNegocios.Cliente;

namespace PuiPui_BackOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerPersona
    {
        IConexionSqlServer db = new ConexionSqlServer();

        #region ConsultarModificarPersona
        public List<Persona> ConsultarModificarPersona()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            Persona objetoPersona = new Persona();
            List<Persona> miLista = new List<Persona>();

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarModificarPersona]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                while (dr.Read())
                {

                    objetoPersona = new Persona();


                    objetoPersona.IdPersona = Convert.ToInt32(dr.GetValue(0));
                    objetoPersona.NombrePersona1 = dr.GetValue(1).ToString();
                    objetoPersona.ApellidoPersona1 = dr.GetValue(2).ToString();
                    objetoPersona.FechaIngresoPersona = Convert.ToDateTime(dr.GetValue(3));


                    miLista.Add(objetoPersona);
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

        public Persona ConsultarDetallePersona(int idPersona)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            Persona objetoPersona = new Persona();

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                cmd = new SqlCommand("[dbo].[consultarDetallePersona]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPersona", idPersona);
                dr = cmd.ExecuteReader();

                //Se recorre cada row
                while (dr.Read())
                {

                    objetoPersona = new Persona();

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
                    objetoPersona.TipoPersona = dr.GetValue(19).ToString();
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