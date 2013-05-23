using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.ReservarClase
{
    public class EventoCalendario
    {

        #region atributos

        private int id;
        private String title;
        private DateTime start;
        private DateTime end;
        private String allDay;
        private String color; 
        private String  textColor;
        private String  editable;



        #endregion

        #region getter setter

        
            public int Id
            {
              get { return id; }
              set { id = value; }
            }
        
            public String Title
            {
              get { return title; }
              set { title = value; }
            }
        
            public DateTime Start
            {
              get { return start; }
              set { start = value; }
            }
        
            public DateTime End
            {
              get { return end; }
              set { end = value; }
            }
        

            public String AllDay
            {
              get { return allDay; }
              set { allDay = value; }
            }
        

            public String Color
            {
              get { return color; }
              set { color = value; }
            }
       
            public String TextColor
            {
              get { return textColor; }
              set { textColor = value; }
            }
        

            public String Editable
            {
              get { return editable; }
              set { editable = value; }
            }

        #endregion

        #region constructor

        public EventoCalendario()
        { 
        }
        #endregion
    }

    }
