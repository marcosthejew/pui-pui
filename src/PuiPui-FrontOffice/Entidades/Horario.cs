using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades
{
    public class Horario
    {
        private String _dia;
        private DateTime _horaini;
        private DateTime _horafin;

        public Horario()
        {
        }

        public String dia
        {
            get { return _dia; }
            set { _dia = value; }

        }

        public DateTime horaini
        {
            get { return _horaini; }
            set { _horaini = value; }
        }

        public DateTime horafin
        {
            get { return _horafin; }
            set { _horafin = value; }
        }
    }
}