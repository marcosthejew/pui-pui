using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.Excepciones
{
    public class ExcepcionReservaInstructorSinFechaInicio : Exception
    {
        public ExcepcionReservaInstructorSinFechaInicio()
        {

        }
        public ExcepcionReservaInstructorSinFechaInicio(string mensaje)
            : base(mensaje)
        {

        }
        public ExcepcionReservaInstructorSinFechaInicio(string mensaje, Exception excepcionInterna)
            : base(mensaje, excepcionInterna)
        {

        }
    }
}