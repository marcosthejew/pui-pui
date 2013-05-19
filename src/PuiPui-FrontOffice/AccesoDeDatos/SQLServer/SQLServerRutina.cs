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
    public class SQLServerRutina
    {
        IConexionSqlServer db = new ConexionSqlServer();

        public List<Rutina> BDConsultaRutinas(int id_rutina)
        {
            string _cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection _conexion = new SqlConnection();
            SqlCommand _cmd = new SqlCommand();
            SqlDataReader _dr;
            Rutina _ruti = new Rutina();
            List<Rutina> _listarutina = new List<Rutina>();

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();

                string listarut = "Select * from Rutina where id_rutina=" + id_rutina + "";
                SqlDataAdapter _querylista = new SqlDataAdapter(listarut, _conexion);
                DataSet tabla = new DataSet();
                _querylista.Fill(tabla, "Rutina");
                if (tabla.Tables[0].Rows.Count == 1)
                {
                    Rutina _lista = new Rutina();
                    for (int i = 0; i < tabla.Tables[0].Rows.Count; i++)
                    {
                        _lista.Descripcion = tabla.Tables[0].Rows[i]["descripcion"].ToString();
                        _lista.Repeteciones = int.Parse(tabla.Tables[0].Rows[i]["repeticiones"].ToString());
                        _lista.Tiempo = DateTime.Parse(tabla.Tables[0].Rows[i]["duracion"].ToString());
                        _lista.Id_rutina = int.Parse(tabla.Tables[0].Rows[i]["id_rutina"].ToString());
                        _listarutina.Add(_lista);

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
            return _listarutina;
        }

        public bool BDInsertarRutina(Rutina insertaRutina)
        {
            string _cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection _conexion = new SqlConnection();
            SqlCommand _cmd = new SqlCommand();
            _conexion = new SqlConnection(_cadenaConexion);

            _conexion.Open();
            string _inserutina = "Insert into Rutina values(@descripcion, @duracion,  @repeticiones)";
            SqlCommand _insertar = new SqlCommand(_inserutina, _conexion);
            _insertar.Parameters.Add("@descripcion", SqlDbType.NChar, 100).Value = insertaRutina.Descripcion;
            _insertar.Parameters.Add("@duracion", SqlDbType.Time, 7).Value = insertaRutina.Tiempo;
            _insertar.Parameters.Add("@duracion", SqlDbType.Int).Value = insertaRutina.Repeteciones;
            _insertar.ExecuteNonQuery();

            _conexion.Close();
            return true;



        }

        public void BDUpadteRutina(Rutina updateRutina)
        {
            string _cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            SqlConnection _conexion = new SqlConnection();
            _conexion = new SqlConnection(_cadenaConexion);
            _conexion.Open();
            string sqlModificaRutina = "UPDATE Rutina ";
            sqlModificaRutina += "SET Descripcion ='" + updateRutina.Descripcion + "'";
            sqlModificaRutina += ",Duracion ='" + updateRutina.Tiempo+ "'";
            sqlModificaRutina += ",repeticiones ='" + updateRutina.Repeteciones + "'";
            sqlModificaRutina += " WHERE id_rutina =" + updateRutina.Id_rutina + "";
            SqlCommand companiaupdate = new SqlCommand(sqlModificaRutina, _conexion);
            companiaupdate.ExecuteNonQuery();
            _conexion.Close();


        }


       
    }

}
