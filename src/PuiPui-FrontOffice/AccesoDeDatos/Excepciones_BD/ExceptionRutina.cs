using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.AccesoDeDatos.Excepciones_BD
{
    public class ExceptionRutina: System.Exception
    {
        public ExceptionRutina() { }
        public ExceptionRutina(string message):base(message) {}
        public ExceptionRutina(string message, System.Exception inner) : base(message, inner) { }
    }
}