using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.AccesoDeDatos.Excepciones_BD
{
    public class ExcepcionBDRutina: Exception
    {
        public ExcepcionBDRutina()
        { 
        
        }
        public ExcepcionBDRutina(string  message):base(message)
        {
            
        }
        public ExcepcionBDRutina(string message, Exception inner)
            : base(message, inner)
        { }
    }
}