using PuiPui_FrontOffice.Entidades.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.Evaluacion
{
    public class Evaluacion
    {
        private int idEvaluacion;

        public int IdEvaluacion
        {
            get { return idEvaluacion; }
            set { idEvaluacion = value; }
        }
        private String pregunta1;

        public String Pregunta1
        {
            get { return pregunta1; }
            set { pregunta1 = value; }
        }
        private String pregunta2;

        public String Pregunta2
        {
            get { return pregunta2; }
            set { pregunta2 = value; }
        }
        private String pregunta3;

        public String Pregunta3
        {
            get { return pregunta3; }
            set { pregunta3 = value; }
        }
        private String pregunta4;

        public String Pregunta4
        {
            get { return pregunta4; }
            set { pregunta4 = value; }
        }
        private String pregunta5;

        public String Pregunta5
        {
            get { return pregunta5; }
            set { pregunta5 = value; }
        }
        private String observaciones;

        public String Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int calificacion;

        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }
        private Persona fkIdPersona;

        public Persona FkIdPersona
        {
            get { return fkIdPersona; }
            set { fkIdPersona = value; }
        }
        private Instructor.Instructor fkIdInstructor;

        public Instructor.Instructor FkIdInstructor
        {
            get { return fkIdInstructor; }
            set { fkIdInstructor = value; }
        }

        public Evaluacion()
        {
            fkIdPersona = new Persona();
            fkIdInstructor = new Instructor.Instructor();
           
        }

    }
}