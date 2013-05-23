using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.AccesoDeDatos.Excepciones_BD
{
    public class ExcepcionPersona : System.Exception
    {
        public ExcepcionPersona() : base() { }
        public ExcepcionPersona(string message) : base(message) { }
        public ExcepcionPersona(string message, System.Exception inner) : base(message, inner) { }
    }
}