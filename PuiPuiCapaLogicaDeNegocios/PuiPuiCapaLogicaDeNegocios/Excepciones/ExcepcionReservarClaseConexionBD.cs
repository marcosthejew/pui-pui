using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Excepciones
{
    public class ExcepcionReservarClaseConexionBD : AExcepcionLogicaPuiPui
    {
        public ExcepcionReservarClaseConexionBD(string message) : base(message) { }
        public ExcepcionReservarClaseConexionBD(string message, Exception inner) : base(message, inner) { }
    }
}