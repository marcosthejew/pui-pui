using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones
{
    /// <summary>
    /// Clase abstracta que tiene como finalidad englobar funcionalidades de las
    /// evaluaciones a instructores y clases.
    /// </summary>
    public abstract class AEvaluacion : AEntidad
    {
        protected int _calificacion;
        protected IEvaluable _objetoEvaluado;

        /// <summary>
        /// Establece u obtiene la calificacion de la evaluacion.
        /// </summary>
        public int Calificacion
        {
            get 
            { 
                return _calificacion; 
            }
            set
            { 
                _calificacion = value;
            }
        }

        /// <summary>
        /// Establece u obtiene el objeto evaluado de la evaluacion.
        /// </summary>
        public IEvaluable ObjetoEvaluado
        {
            get 
            { 
                return _objetoEvaluado; 
            }
            set
            { 
                _objetoEvaluado = value;
            }
        }
    }
}