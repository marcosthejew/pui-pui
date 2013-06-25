using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EReservaciones
{
    public class ReservacionClase : AEntidad
    {
        #region Atributos
        
        private DateTime _fechaReservacion;
        private int _status;
        private int _idClaseSalon;
        private int _idCliente;
        
        #endregion

        #region Getters&Setters

        public DateTime FechaReservacion
        {
            get { return _fechaReservacion; }
            set { _fechaReservacion = value; }
        }

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public int IdClaseSalon
        {
            get { return _idClaseSalon; }
            set { _idClaseSalon = value; }
        }

        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        #endregion

        #region Constructores

        public ReservacionClase()
        { 
        }

        public ReservacionClase(int id)
        {
            _id = id;
        }

        public ReservacionClase(int id,DateTime fecha)
        {
            _id = id;
            _fechaReservacion = fecha;
        }

        public ReservacionClase(int id, DateTime fecha,int status)
        {
            _id = id;
            _fechaReservacion = fecha;
            _status = status;
        }

        public ReservacionClase(int id, DateTime fecha, int status,int idClaseSalon)
        {
            _id = id;
            _fechaReservacion = fecha;
            _status = status;
            _idClaseSalon = idClaseSalon;
        }

        public ReservacionClase(int id, DateTime fecha, int status, int idClaseSalon,int idCliente)
        {
            _id = id;
            _fechaReservacion = fecha;
            _status = status;
            _idClaseSalon = idClaseSalon;
            _idCliente = idCliente;
        }
        #endregion
    }
}