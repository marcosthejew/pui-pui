using System;

namespace PuiPui_BackOffice.Entidades
{
    public class Horario
    {
        private String _dia;
        private DateTime _horaInicio;
        private DateTime _horaFin;

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
            get { return _horaInicio; }
            set { _horaInicio = value; }
        }

        public DateTime horafin
        {
            get { return _horaFin; }
            set { _horaFin = value; }
        }
    }
}