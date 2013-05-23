using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades
{
    public abstract class Evaluacion
    {
        protected DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        protected string _observaciones, _status;

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        protected int _calificacion, _idClaseSalon, _idCliente, _idInstructor, _idEvaluacion;

        public int IdEvaluacion
        {
            get { return _idEvaluacion; }
            set { _idEvaluacion = value; }
        }

        public int IdInstructor
        {
            get { return _idInstructor; }
            set { _idInstructor = value; }
        }

        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        public int IdClaseSalon
        {
            get { return _idClaseSalon; }
            set { _idClaseSalon = value; }
        }

        public int Calificacion
        {
            get { return _calificacion; }
            set { _calificacion = value; }
        }

    }
}