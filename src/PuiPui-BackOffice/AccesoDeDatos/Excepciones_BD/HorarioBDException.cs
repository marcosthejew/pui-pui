using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD
{
    public class HorarioBDException : Exception 
    {
        public HorarioBDException()
        {
        }
        public HorarioBDException(string message)
            : base(message)
        {
        }
        public HorarioBDException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}