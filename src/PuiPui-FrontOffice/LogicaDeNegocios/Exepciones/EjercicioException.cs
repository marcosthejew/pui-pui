using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.LogicaDeNegocios.Excepciones
{
    public class EjercicioException : Exception
    {
        public EjercicioException()
        {
        }
        public EjercicioException(string message)
            : base(message)
        {
        }
        public EjercicioException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}