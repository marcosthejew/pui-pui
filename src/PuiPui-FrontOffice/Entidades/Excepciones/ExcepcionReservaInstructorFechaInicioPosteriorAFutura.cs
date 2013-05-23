using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.Excepciones
{
    public class ExcepcionReservaInstructorFechaInicioPosteriorAFutura : Exception
    {
        public ExcepcionReservaInstructorFechaInicioPosteriorAFutura()
        {

        }
        public ExcepcionReservaInstructorFechaInicioPosteriorAFutura(string mensaje)
            : base(mensaje)
        {

        }
        public ExcepcionReservaInstructorFechaInicioPosteriorAFutura(string mensaje, Exception excepcionInterna)
            : base(mensaje, excepcionInterna)
        {

        }
    }
}