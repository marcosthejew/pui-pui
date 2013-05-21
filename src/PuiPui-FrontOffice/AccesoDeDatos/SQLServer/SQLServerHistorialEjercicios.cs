using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion;
using PuiPui_FrontOffice.AccesoDeDatos.Conexion.IConexion;
using PuiPui_FrontOffice.AccesoDeDatos.Excepciones_BD;
using PuiPui_FrontOffice.Entidades.Rutina;

namespace PuiPui_FrontOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerHistorialEjercicios
    {
        IConexionSqlServer db = new ConexionSqlServer();

        public bool BDInsertarHistorial(int id_cliente, int id_rutina, int id_ejercicio_)
        {
            string _cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection _conexion = new SqlConnection();
            SqlCommand _insertar = new SqlCommand();
            SqlDataReader _execute;
            _conexion = new SqlConnection(_cadenaConexion);
          
            try
            {
                _conexion.Open();
                _insertar = new SqlCommand("[dbo].[insertar_HistorialEjercicio]", _conexion);
                _insertar.CommandType = CommandType.StoredProcedure;
                _insertar.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
                _insertar.Parameters.Add("@id_rutina", SqlDbType.Int).Value = id_rutina;
                _insertar.Parameters.Add("@id_ejercicio", SqlDbType.Int).Value = id_ejercicio_;
                _execute = _insertar.ExecuteReader();

                if (_execute.Read())
                {
                    db.CerrarConexion();
                    return true;
                }
            }
            catch (SqlException error)
            {

                throw (new ExcepcionConexion(("Error: " + error.Message), error));

            }
            finally
            {
                db.CerrarConexion();
            }
            return false;
        }

        public List<Historial_Ejercicio> listaIdejercicios(int id_cliente, int id_rutina)
        {
            string _cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection _conexion = new SqlConnection();
            SqlCommand _cmd = new SqlCommand();
            List<Historial_Ejercicio> lista = new List<Historial_Ejercicio>();
            SqlDataReader _execute;
            Historial_Ejercicio _id_ejer = new Historial_Ejercicio();
            try
            {

                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[busca_rutina_idEjercicio]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@id_cli", id_cliente);
                _cmd.Parameters.AddWithValue("@id_ru", id_rutina);
                _execute = _cmd.ExecuteReader();

                while (_execute.Read())
                {

                    _id_ejer.Id_ejercicio = Convert.ToInt32(_execute.GetValue(0));
                    lista.Add(_id_ejer);

                }

                _conexion.Close();

            }
            catch (SqlException e)
            {

                throw (new ExcepcionConexion(("Error: " + e.Message), e));

            }
            finally
            {
                _conexion.Close();
            }
            return lista;

        }
        public List<Historial_Ejercicio> busca_id_rutina(int id_cliente)
        {
            string _cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection _conexion = new SqlConnection();
            SqlCommand _cmd = new SqlCommand();
            List<Historial_Ejercicio> lista = new List<Historial_Ejercicio>();
            SqlDataReader _execute;
            Historial_Ejercicio _id_ruti = new Historial_Ejercicio();
            try
            {

                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[busca_rutina_idCliente]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@id_cli", id_cliente);
                _execute = _cmd.ExecuteReader();

                while (_execute.Read())
                {

                    _id_ruti.Id_rutina = Convert.ToInt32(_execute.GetValue(0));
                    lista.Add(_id_ruti);

                }

                db.CerrarConexion();

            }
            catch (SqlException e)
            {

                throw (new ExcepcionConexion(("Error: " + e.Message), e));

            }
            finally
            {
                _conexion.Close();
            }
            return lista;

        }

        public bool BDEliminaHistorial(int id_cliente, int id_rutina)
        {

    
            string _cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection _conexion = new SqlConnection();
            SqlCommand _borrar = new SqlCommand();
            SqlDataReader _execute;
         
            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _borrar = new SqlCommand("[dbo].[delete_Historial_Rutina]", _conexion);
                _borrar.CommandType = CommandType.StoredProcedure;
                _borrar.Parameters.AddWithValue("@id_ruti", id_rutina);
                _borrar.Parameters.AddWithValue("@id_cli", id_cliente);
                _execute = _borrar.ExecuteReader();
                db.CerrarConexion();
                return  true;

               
            }
            catch (SqlException error)
            {

                throw (new ExcepcionConexion(("Error: " + error.Message), error));
                
            }
               
            finally
            {
               
                db.CerrarConexion();
               
            }
            return false;
           
        }
    }
}