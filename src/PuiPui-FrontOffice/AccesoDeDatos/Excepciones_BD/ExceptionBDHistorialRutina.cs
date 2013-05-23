using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.AccesoDeDatos.Excepciones_BD
{
    public class ExceptionBDHistorialRutina:Exception
    {
        public ExceptionBDHistorialRutina() { }
        public ExceptionBDHistorialRutina(string message):base(message){  }
        public ExceptionBDHistorialRutina(string message, Exception inner) : base(message, inner) { }
    }
}