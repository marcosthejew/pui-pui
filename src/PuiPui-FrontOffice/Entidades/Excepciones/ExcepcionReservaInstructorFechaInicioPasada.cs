using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.Excepciones
{
    public class ExcepcionReservaInstructorFechaInicioPasada : Exception
    {
        public ExcepcionReservaInstructorFechaInicioPasada()
        {

        }
        public ExcepcionReservaInstructorFechaInicioPasada(string mensaje)
            : base(mensaje)
        {

        }
        public ExcepcionReservaInstructorFechaInicioPasada(string mensaje, Exception excepcionInterna)
            : base(mensaje, excepcionInterna)
        {

        }
    }
}