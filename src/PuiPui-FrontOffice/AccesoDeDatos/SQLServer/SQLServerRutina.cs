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

        public Rutina BDConsultaRutinas(int id_rutina)
        {


            string _cadenaConexion = "Server= localhost;database=puipuiDB;integrated security=true";
            SqlConnection _conexion = new SqlConnection();
            SqlCommand _cmd = new SqlCommand();
            SqlDataReader _dr;
            Rutina _ruti = new Rutina();
            List<Rutina> _listarutina = new List<Rutina>();
            DateTime _miTiempo;
            string tiempo = "";
            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[buscar_rutina]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@id_ruti", id_rutina);
                _dr = _cmd.ExecuteReader();

                while (_dr.Read())
                {

                    _ruti.Descripcion = _dr.GetValue(1).ToString();
                    tiempo = _dr.GetValue(2).ToString();
                    _miTiempo = new DateTime();
                    _miTiempo = DateTime.ParseExact(tiempo, "HH:mm:ss", null);
                    _ruti.Tiempo = _miTiempo;
                    _ruti.Repeteciones = Convert.ToInt32(_dr.GetValue(3));
                    _listarutina.Add(_ruti);

                }
                db.CerrarConexion();
                if (_listarutina != null)
                    return _ruti;
            }
            catch (SqlException e)
            {
                throw (new ExcepcionConexion(("Error: " + e.Message), e));


            }

            finally
            {
                _conexion.Close();
            }
            return _ruti;
        }
        public List<Rutina> BDTodosConsultaRutinas()
        {


            string _cadenaConexion = "Server= localhost;database=puipuiDB;integrated security=true";
            SqlConnection _conexion = new SqlConnection();
            SqlCommand _cmd = new SqlCommand();
            SqlDataReader _dr;

            List<Rutina> _listarutina = new List<Rutina>();
            DateTime _miTiempo;
            string tiempo = "";
            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[buscar_rutina_todas]", _conexion);
                _dr = _cmd.ExecuteReader();

                while (_dr.Read())
                {
                    Rutina _ruti = new Rutina();
                    _ruti.Id_rutina = Convert.ToInt32(_dr.GetValue(0));
                    _ruti.Descripcion = _dr.GetValue(1).ToString();
                    tiempo = _dr.GetValue(2).ToString();
                    _miTiempo = new DateTime();
                    _miTiempo = DateTime.ParseExact(tiempo, "HH:mm:ss", null);
                    _ruti.Tiempo = _miTiempo;
                    if (_dr[3] != DBNull.Value)
                    {
                        _ruti.Repeteciones = Convert.ToInt32(_dr.GetValue(3));

                    }
                    else
                    {
                        _ruti.Repeteciones = 0;
                    }


                    _listarutina.Add(_ruti);

                }
                db.CerrarConexion();
                if (_listarutina != null)
                    return _listarutina;
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
            string _cadenaConexion = "Server= localhost;database=puipuiDB;integrated security=true";
            SqlConnection _conexion = new SqlConnection();
            SqlCommand _insertar = new SqlCommand();
            SqlDataReader _execute;
            _conexion = new SqlConnection(_cadenaConexion);
            try
            {
                _conexion.Open();

                _insertar = new SqlCommand("[dbo].[insertar_Rutina]", _conexion);
                _insertar.CommandType = CommandType.StoredProcedure;
                _insertar.Parameters.Add("@descripcion", SqlDbType.NChar, 100).Value = insertaRutina.Descripcion;
                _insertar.Parameters.Add("@duracion", SqlDbType.DateTime, 7).Value = insertaRutina.Tiempo;
                _insertar.Parameters.Add("@repeticiones", SqlDbType.Int).Value = insertaRutina.Repeteciones;
                _execute = _insertar.ExecuteReader();
                if (_execute.Read())
                {
                    db.CerrarConexion();
                    return false;
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
            return true;
        }

        public Rutina BDUltimo_ID_Rutina()
        {
            string _cadenaConexion = "Server= localhost;database=puipuiDB;integrated security=true";
            SqlConnection _conexion = new SqlConnection();
            SqlCommand _cmd = new SqlCommand();
            SqlDataReader _dr;
            Rutina _ruti = new Rutina();
            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[buscar_ultimo_id]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _dr = _cmd.ExecuteReader();
                while (_dr.Read())
                {
                    _ruti.Id_rutina = Convert.ToInt32(_dr.GetValue(0));

                }

                db.CerrarConexion();
                return _ruti;


            }
            catch (SqlException error)
            {
                return _ruti;
                throw (new ExcepcionConexion(("Error: " + error.Message), error));


            }
            finally
            {
                db.CerrarConexion();

            }
        }



        public bool BDUpadteRutina(Rutina updateRutina)
        {
            bool _updateo = false;
            string _cadenaConexion = "Server=localhost;database=puipuiDB;integrated security=true";
            SqlConnection _conexion = new SqlConnection();
            SqlCommand _updatear = new SqlCommand();
            SqlDataReader _execute;
            _conexion = new SqlConnection(_cadenaConexion);
            _conexion.Open();
            _updatear = new SqlCommand("[dbo].[update_Rutina]", _conexion);
            _updatear.CommandType = CommandType.StoredProcedure;
            _updatear.Parameters.AddWithValue("@id_ruti", updateRutina.Id_rutina);
            _updatear.Parameters.AddWithValue("@descripcion", updateRutina.Descripcion);
            _updatear.Parameters.AddWithValue("@duracion", updateRutina.Tiempo);
            _updatear.Parameters.AddWithValue("@repeticiones", updateRutina.Repeteciones);
            _execute = _updatear.ExecuteReader();
            _conexion.Close();
            return _updateo;
        }
    }

}