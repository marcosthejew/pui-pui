using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.AccesoDeDatos.Excepciones_BD
{
    public class ExceptionHistorialRutina: System.Exception
    {
        public ExceptionHistorialRutina() { }
        public ExceptionHistorialRutina(string message) : base(message) { }
        public ExceptionHistorialRutina(string message, System.Exception inner) :base(message,inner) {}
    }
}