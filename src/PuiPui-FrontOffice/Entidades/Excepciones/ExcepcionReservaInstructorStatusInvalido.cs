using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.Excepciones
{
    public class ExcepcionReservaInstructorStatusInvalido : Exception
    {
        public ExcepcionReservaInstructorStatusInvalido()
        {

        }
        public ExcepcionReservaInstructorStatusInvalido(string mensaje)
            : base(mensaje)
        {

        }
        public ExcepcionReservaInstructorStatusInvalido(string mensaje, Exception excepcionInterna)
            : base(mensaje, excepcionInterna)
        {

        }
    }
}