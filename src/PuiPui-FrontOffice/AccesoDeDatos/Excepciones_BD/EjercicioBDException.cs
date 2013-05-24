using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.AccesoDeDatos.Excepciones_BD
{
    public class EjercicioBDException : Exception
    {
        public EjercicioBDException()
        {
        }
        public EjercicioBDException(string message)
            : base(message)
        {
        }
        public EjercicioBDException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}