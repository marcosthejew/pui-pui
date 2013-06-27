using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EHorario
{
    public class Horario : AEntidad
    {
        #region Atributos
        
        private TimeSpan _horaInicio;
        private TimeSpan _horaFin;
        private string _diaSemana;
        private int _status;
             
        #endregion

        #region Getters&Setters
        
        public TimeSpan HoraInicio
        {
            get { return _horaInicio; }
            set { _horaInicio = value; }
        }
        
        public TimeSpan HoraFin
        {
            get { return _horaFin; }
            set { _horaFin = value; }
        }
        
        public string DiaSemana
        {
            get { return _diaSemana; }
            set { _diaSemana = value; }
        }
        
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        #endregion

        #region Constructores

        public Horario()
        {
        }

        public Horario(int id)
        {
            _id = id;
            
        }
        public Horario(int id, TimeSpan horaInicio, TimeSpan horaFin)
        {
            _id = id;
            _horaInicio = horaInicio;
            _horaFin = horaFin;
        }
        public Horario( TimeSpan horaInicio, TimeSpan horaFin)
        {
            _horaInicio = horaInicio;
            _horaFin = horaFin;
        }


        public Horario(int id, TimeSpan horaInicio,TimeSpan horaFin,string diaSemana)
        {
            _id = id;
            _horaInicio = horaInicio;
            _horaFin = horaFin;
            _diaSemana = diaSemana;
        }

        public Horario(int id, TimeSpan horaInicio, TimeSpan horaFin, string diaSemana,int status)
        {
            _id = id;
            _horaInicio = horaInicio;
            _horaFin = horaFin;
            _diaSemana = diaSemana;
            _status = status;
        }
       

        #endregion
    }
}