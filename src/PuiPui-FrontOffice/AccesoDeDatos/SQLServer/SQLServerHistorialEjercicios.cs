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

namespace PuiPui_FrontOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerHistorialEjercicios
    {
        IConexionSqlServer db = new ConexionSqlServer();

        public bool BDInsertarHistorial(int id_cliente, int id_rutina, int id_ejercicio_)
        {
            string _cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection _conexion = new SqlConnection();
            SqlCommand _cmd = new SqlCommand();
            _conexion = new SqlConnection(_cadenaConexion);

            _conexion.Open();
            string _inserhistorial = "Insert into Historial_Ejercicio values(id_cliente, id_rutina,  id_ejercicio)";
            SqlCommand _insertar = new SqlCommand(_inserhistorial, _conexion);
            _insertar.Parameters.Add("id_cliente", SqlDbType.Int).Value = id_cliente;
            _insertar.Parameters.Add("id_rutina", SqlDbType.Int).Value = id_rutina;
            _insertar.Parameters.Add("id_ejercicio", SqlDbType.Int).Value = id_ejercicio_;
            _insertar.ExecuteNonQuery();

            _conexion.Close();
            return true;
        }

        public List<int> listaIdejercicios(int id_cliente)
        {
            string _cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection _conexion = new SqlConnection();
            SqlCommand _cmd = new SqlCommand();
            List<int> lista = new List<int>();
            try
            {

                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                string listarut = "Select id_ejercicio from Historial_Ejercicio where id_cliente=" + id_cliente + "";
                SqlDataAdapter _querylista = new SqlDataAdapter(listarut, _conexion);
                DataSet tabla = new DataSet();
                _querylista.Fill(tabla, "Historial_Ejercicio");

                if (tabla.Tables[0].Rows.Count == 1)
                {
                    int _id = 0;
                    for (int i = 0; i < tabla.Tables[0].Rows.Count; i++)
                    {

                        _id = int.Parse(tabla.Tables[0].Rows[i]["id_ejercicio"].ToString());
                        lista.Add(_id);
                        _id = 0;
                    }

                    _conexion.Close();
                }
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
    }
}