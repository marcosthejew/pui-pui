﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones;
using PuiPuiCapaLogicaDeNegocios.Entidades.EPersonas;
using PuiPuiCapaLogicaDeNegocios.Entidades.EReservaciones;
using PuiPuiCapaLogicaDeNegocios.Entidades.EHorario;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EClases
{
    public class ClaseSalon : AEntidad
    {
        #region Atributos

       
        private Clase _clase;
        private Salon _salon;
        private Instructor _instructor;
        private Horario _horario;
  

      

        public Horario Horario
        {
            get { return _horario; }
            set { _horario = value; }
        }
        private int _disponibilidad;
        private int iid;
        private EClases.Salon sal;
        private EClases.Clase clas;
        private EPersonas.Instructor ins;
        private EHorario.Horario ho;
        private int disp;

        #endregion

        #region Getter Setter

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public Clase Clase
        {
            get { return _clase; }
            set { _clase = value; }
        }
        public Salon Salon
        {
            get { return _salon; }
            set { _salon = value; }
        }
        public Instructor Instructor
        {
            get { return _instructor; }
            set { _instructor = value; }
        }
        public int Disponibilidad
        {
            get { return _disponibilidad; }
            set { _disponibilidad = value; }
        }

        #endregion

        #region Constructor

        public ClaseSalon(Salon sal, Clase clas, Instructor ins, Horario hora)
        {
            this.Instructor = ins;
            this.Salon = sal;
            this.Clase = clas;
            this.Horario = hora;
        
        }
        public ClaseSalon()
        {
            _clase = new Clase();
            _salon = new Salon();
            _instructor = new Instructor();
            _horario = new Horario();
        }
        public ClaseSalon(Salon sal, Clase clas,  Instructor ins)
        {
            this.Instructor = ins;
            this.Salon = sal;
            this.Clase = clas;
        }
        public ClaseSalon(int iid, Salon sal, Clase clas,  Instructor ins, int disp)
        {
            this._id = iid;
            this._instructor = ins;
            this._salon = sal;
            this._clase = clas;
            this._disponibilidad = disp;
        }
        public ClaseSalon(int iid, Salon sal, Clase clas,Horario ho, Instructor ins, int disp)
        {
            this._id = iid;
            this._instructor = ins;
            this._salon = sal;
            this._clase = clas;
            this._horario = ho;
            this._disponibilidad = disp;
        }

        #endregion


        public string serializar()
        {
            string resultado = "<ClaseSalon>";

            resultado += "<Id>" + ID + "</Id>";
            resultado += "<Clase>" + Clase.Nombre + "</Clase>";
            resultado += "<Codigo>" + Salon.IdSalon + "</Codigo>";
            resultado += "<Ubicacion>" + Salon.Ubicacion + "</Ubicacion>";
            resultado += "<Instructor>" + Instructor.NombrePersona1 + "</Instructor>";
            resultado += "<HInicio>" + Horario.HoraInicio + "</HInicio>";
            resultado += "<HFin>" + Horario.HoraInicio + "</HFin>";
            resultado += "<Estatus>" + Disponibilidad+ "</Estatus>";
            resultado += "</ClaseSalon>";
            return resultado;

        }
    }
}