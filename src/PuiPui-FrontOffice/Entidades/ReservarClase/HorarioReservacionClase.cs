using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.ReservarClase
{
    public class HorarioReservacionClase
    {
        #region Atributos

        private int _idHoraReserva;
        private String _horario;
     

        #endregion

        #region Getter Setters

        public int HoraReserva
        {
            get { return _idHoraReserva; }
            set { _idHoraReserva = value; }
        }


        public String Horario
        {
            get { return _horario; }
            set { _horario = value; }
        }
       
        #endregion

        #region contructores

        public HorarioReservacionClase()
        { 
        
        }
        #endregion
    }
}