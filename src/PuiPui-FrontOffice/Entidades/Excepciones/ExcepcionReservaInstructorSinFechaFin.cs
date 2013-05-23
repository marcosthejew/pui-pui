using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.Excepciones
{
    public class ExcepcionReservaInstructorSinFechaFin : Exception
    {
        public ExcepcionReservaInstructorSinFechaFin()
        {

        }
        public ExcepcionReservaInstructorSinFechaFin(string mensaje)
            : base(mensaje)
        {

        }
        public ExcepcionReservaInstructorSinFechaFin(string mensaje, Exception excepcionInterna)
            : base(mensaje, excepcionInterna)
        {

        }
    }
}