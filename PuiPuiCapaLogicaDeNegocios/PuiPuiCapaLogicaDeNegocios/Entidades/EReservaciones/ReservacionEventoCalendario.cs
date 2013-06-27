using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EReservaciones
{
    /// <summary>
    /// Esta clase tiene como finalidad cargar los datos para mostrarlos
    /// en el calendario fullcalendar por ello su estructura es diferente
    /// </summary>
    public class ReservacionEventoCalendario : AEntidad
    {
        #region Atributos

        public int id { get; set; }
        public String title { get; set; }
        public String start { get; set; }
        public String end { get; set; }
        public bool allDay { get; set; }
        public String instructor { get; set; }
        public int cuposDisponibles { get; set; }
        public int status { get; set; }
        public String color { get; set; }
        public String textColor { get; set; }
  
        #endregion

       #region constructor
        public ReservacionEventoCalendario()
        { 
        }
        #endregion
    }
}