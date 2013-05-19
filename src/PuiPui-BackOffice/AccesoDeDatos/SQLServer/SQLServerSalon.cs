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
using PuiPui_BackOffice.Entidades.Salon;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon;

namespace PuiPui_BackOffice.AccesoDeDatos.SQLServer
{
    public class SQLServerSalon
    {
              #region Atributos
         
        private List<Salon> _listaSalones ;
        private Salon _objetoSalon;
        private IConexionSqlServer _db ;
        private string _cadenaConexion;
        private SqlConnection _conexion;
        private SqlCommand _cmd;
        private SqlDataReader _dr;
        #endregion

        #region Constructor
        public SQLServerSalon()
        {
            _listaSalones = new List<Salon>();
            _db = new ConexionSqlServer();
            _cadenaConexion = ConfigurationManager.ConnectionStrings["ConnPuiPui"].ToString();
            _conexion = new SqlConnection();
            _cmd = new SqlCommand();
        }
        #endregion

        #region Metodos 

        public List<Salon> ConsultarSalones()
        {

            try
            {
                _conexion = new SqlConnection(_cadenaConexion);
                _conexion.Open();
                _cmd = new SqlCommand("[dbo].[ListarSalones]", _conexion);
                _cmd.CommandType = CommandType.StoredProcedure;
                _dr = _cmd.ExecuteReader();

                //Llena la lista de salones
                while (_dr.Read())
                {

                    _objetoSalon = new Salon();

                    _objetoSalon.IdSalon = Convert.ToInt32(_dr.GetValue(0));
                    _objetoSalon.Nombre = _dr.GetValue(1).ToString();
                    _objetoSalon.Ubicacion = _dr.GetValue(2).ToString();
                    _objetoSalon.Capacidad = Convert.ToInt32(_dr.GetValue(3));
                    _objetoSalon.Status = Convert.ToInt32(_dr.GetValue(4));

                    _listaSalones.Add(_objetoSalon);
                }

                _db.CerrarConexion();

            }
            catch (SqlException error)
            {
                //En caso de que se viole alguna restriccion sobre la BD
                throw (new ExcepcionConexion(("Error: " + error.Message), error));
            }
            finally
            {
                _db.CerrarConexion();
            }
            return _listaSalones;
        }

        #endregion

    }
}