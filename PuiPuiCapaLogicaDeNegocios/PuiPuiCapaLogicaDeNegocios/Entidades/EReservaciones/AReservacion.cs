using PuiPuiCapaLogicaDeNegocios.Entidades.EHorario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EReservaciones
{
    /// <summary>
    /// Clase abstracta que tiene como finalidad englobar funcionalidades de las
    /// reservaciones de instructores y clases.
    /// </summary>
    public class AReservacion : AEntidad
    {
        protected Horario _horarioReservacion;
        protected IReservable _objetoReservado;

        /// <summary>
        /// Establece u obtiene el horario de la reservacion.
        /// </summary>
        public Horario HorarioReservacion
        {
            get 
            { 
                return _horarioReservacion;
            }
            set 
            {
                _horarioReservacion = value;
            }
        }

        /// <summary>
        /// Establece u obtiene el objeto reservado de la reservacion.
        /// </summary>
        public IReservable ObjetoReservado
        {
            get 
            { 
                return _objetoReservado; 
            }
            set 
            { 
                _objetoReservado = value;
            }
        }
    }
}