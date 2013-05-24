using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.LogicaDeNegocios.Exepciones
{
    public class ExcepcionRutina : Exception
    {
       
            public ExcepcionRutina()
            {
            }
            public ExcepcionRutina(string message)
                : base(message)
            {
            }
            public ExcepcionRutina(string message, Exception inner)
                : base(message, inner)
            {
            }
        
    }
}