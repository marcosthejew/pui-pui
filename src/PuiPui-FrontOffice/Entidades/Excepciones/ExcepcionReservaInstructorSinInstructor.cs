using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.Excepciones
{
    public class ExcepcionReservaInstructorSinInstructor : Exception
    {
        public ExcepcionReservaInstructorSinInstructor()
        {

        }
        public ExcepcionReservaInstructorSinInstructor(string mensaje)
            : base(mensaje)
        {

        }
        public ExcepcionReservaInstructorSinInstructor(string mensaje, Exception excepcionInterna)
            : base(mensaje, excepcionInterna)
        {

        }
    }
}