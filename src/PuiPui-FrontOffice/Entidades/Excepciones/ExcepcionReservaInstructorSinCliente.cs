using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.Excepciones
{
    public class ExcepcionReservaInstructorSinCliente : Exception
    {
        public ExcepcionReservaInstructorSinCliente()
        {

        }
        public ExcepcionReservaInstructorSinCliente(string mensaje)
            : base(mensaje)
        {

        }
        public ExcepcionReservaInstructorSinCliente(string mensaje, Exception excepcionInterna)
            : base(mensaje, excepcionInterna)
        {

        }
    }
}