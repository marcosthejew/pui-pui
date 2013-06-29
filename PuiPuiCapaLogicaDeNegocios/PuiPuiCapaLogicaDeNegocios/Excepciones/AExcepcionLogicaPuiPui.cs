using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Excepciones
{
    /// <summary>
    /// Excepcion general del sistema PuiPui.
    /// </summary>
    public abstract class AExcepcionLogicaPuiPui : System.Exception
    {
        /// <summary>
        /// Instancia una excepcion del sistema PuiPui especificando un mensaje
        /// descriptivo de la misma.
        /// </summary>
        /// <param name="message">
        /// el mensaje que describe la excepcion.
        /// </param>
        public AExcepcionLogicaPuiPui(string message) : base(message) { }

        /// <summary>
        /// Instancia una excepcion del sistema PuiPui especificando un mensaje
        /// descriptivo de la misma y la excepcion interna que dio lugar a esta
        /// nueva excepcion.
        /// </summary>
        /// <param name="message">
        /// el mensaje que describe la excepcion.
        /// </param>
        /// <param name="inner">
        /// la excepcion de sistema que genero esta nueva excepcion.
        /// </param>
        public AExcepcionLogicaPuiPui(string message, System.Exception inner) 
                : base(message, inner) { }
    }
}