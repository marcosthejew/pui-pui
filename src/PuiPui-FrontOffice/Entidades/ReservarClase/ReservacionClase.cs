using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.ReservarClase
{
    public class ReservacionClase
    {
        #region atributos

        private DateTime fechaReservacion;
        private String statusReservacion;
        private int horarioReserva;
        private int idCliente;

        #endregion

        #region getter setter


        public DateTime FechaReservacion
        {
            get { return fechaReservacion; }
            set { fechaReservacion = value; }
        }

        public String StatusReservacion
        {
            get { return statusReservacion; }
            set { statusReservacion = value; }
        }

        public int HorarioReserva
        {
            get { return horarioReserva; }
            set { horarioReserva = value; }
        }


        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        #endregion

        #region constructor

        public ReservacionClase()
        { 
        }
        #endregion
    }
}