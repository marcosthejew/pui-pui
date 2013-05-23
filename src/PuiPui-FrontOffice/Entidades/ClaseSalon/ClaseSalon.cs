using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.ClaseSalon
{
    public class ClaseSalon
    {
        private int idClaseSalon;

        public int IdClaseSalon
        {
            get { return idClaseSalon; }
            set { idClaseSalon = value; }
        }
        private int reservado;

        public int Reservado
        {
            get { return reservado; }
            set { reservado = value; }
        }
        private Clase.Clase fkIdClase;

        public Clase.Clase FkIdClase
        {
            get { return fkIdClase; }
            set { fkIdClase = value; }
        }
        private Salon.Salon fkIdSalon;

        public Salon.Salon FkIdSalon
        {
            get { return fkIdSalon; }
            set { fkIdSalon = value; }
        }
        private Instructor.Instructor fkIdInstructor;

        public Instructor.Instructor FkIdInstructor
        {
            get { return fkIdInstructor; }
            set { fkIdInstructor = value; }
        }

        public ClaseSalon()
        {
            fkIdClase = new Clase.Clase();
            fkIdInstructor = new Instructor.Instructor();
            fkIdSalon = new Salon.Salon();
        }

    }
}