using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using PuiPui_BackOffice.Entidades.Salon;
using PuiPui_BackOffice.AccesoDeDatos.SQLServer;

namespace PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon
{
    public class LogicaSalon
    {

        #region Atributos

        private Salon _salon;
        private SQLServerSalon _accesoSalon;
        private List<Salon> _miLista;

        #endregion

        #region Constructor

        public LogicaSalon()
        {
            _salon = new Salon();
            _accesoSalon = new SQLServerSalon();
            _miLista= new List<Salon>();

        }


        #endregion

        #region Metodos Salon

        public DataTable ConsultarSalones()
        {
            DataTable miTabla = new DataTable();

            _miLista = _accesoSalon.ConsultarSalones();

            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

            foreach (Salon salon in _miLista)
            {

                miTabla.Rows.Add(salon.IdSalon,salon.Ubicacion,salon.Capacidad,salon.Status);
            }

            return miTabla;
        }

        public Boolean ModificarSalones(Salon salon)
        {

            Boolean retorno = false;

            retorno = _accesoSalon.ModificarSalon(salon);

            return retorno;

        }

        public Boolean AgregarSalones(String ubicacion, int capacidad)
        {
            Boolean resultado = false;
            _salon.Ubicacion = ubicacion;
            _salon.Capacidad = capacidad;
            _salon.Status = 0;
            resultado = _accesoSalon.AgregarSalon(_salon);
            //conectar a la bd

            return resultado;

        }

        public DataTable ConsultarSalonesUbicacion(String ubi)
        {
            DataTable miTabla = new DataTable();

            _miLista = _accesoSalon.BusquedaUbicacion(ubi);

            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

            foreach (Salon salon in _miLista)
            {

                miTabla.Rows.Add(salon.IdSalon, salon.Ubicacion, salon.Capacidad, salon.Status);
            }

            return miTabla;
        }

        public DataTable ConsultarSalonesCapacidadMayo(int capa)
        {
            DataTable miTabla = new DataTable();

            _miLista = _accesoSalon.BusquedaCapacidadMayorSalon(capa);

            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

            foreach (Salon salon in _miLista)
            {

                miTabla.Rows.Add(salon.IdSalon, salon.Ubicacion, salon.Capacidad, salon.Status);
            }

            return miTabla;
        }

        public DataTable ConsultarSalonesCapacidadMenor(int capa)
        {
            DataTable miTabla = new DataTable();

            _miLista = _accesoSalon.BusquedaCapacidadMenorSalon(capa);

            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

            foreach (Salon salon in _miLista)
            {

                miTabla.Rows.Add(salon.IdSalon, salon.Ubicacion, salon.Capacidad, salon.Status);
            }

            return miTabla;
        }

        public DataTable ConsultarSalonesStatus(int stat)
        {
            DataTable miTabla = new DataTable();

            _miLista = _accesoSalon.BusquedaStatusSalon(stat);

            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

            foreach (Salon salon in _miLista)
            {

                miTabla.Rows.Add(salon.IdSalon, salon.Ubicacion, salon.Capacidad, salon.Status);
            }

            return miTabla;
        }

        #endregion

        #region Metodos Clase Salon Instructor

        public DataTable ConsultarSalonesClase()
        {
            DataTable miTabla = new DataTable();

            _miLista = _accesoSalon.ConsultarSalones();

            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

            foreach (Salon salon in _miLista)
            {

                miTabla.Rows.Add(salon.IdSalon, salon.Ubicacion, salon.Capacidad, salon.Status);
            }

            return miTabla;
        }

        public Boolean ModificarSalonesClase(Salon salon)
        {

            Boolean retorno = false;

            retorno = _accesoSalon.ModificarSalon(salon);

            return retorno;

        }

        public Boolean AgregarSalonesClase(String ubicacion, int capacidad)
        {
            Boolean resultado = false;
            _salon.Ubicacion = ubicacion;
            _salon.Capacidad = capacidad;
            _salon.Status = 0;
            resultado = _accesoSalon.AgregarSalon(_salon);
            //conectar a la bd

            return resultado;

        }

        public DataTable ConsultarSalonesClaseUbicacion(String ubi)
        {
            DataTable miTabla = new DataTable();

            _miLista = _accesoSalon.BusquedaUbicacion(ubi);

            miTabla.Columns.Add("Nro.Salon", typeof(string));
            miTabla.Columns.Add("Ubicacion", typeof(string));
            miTabla.Columns.Add("Capacidad", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

            foreach (Salon salon in _miLista)
            {

                miTabla.Rows.Add(salon.IdSalon, salon.Ubicacion, salon.Capacidad, salon.Status);
            }

            return miTabla;
        }

        #endregion
    }
}