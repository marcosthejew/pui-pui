using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD
{
    public class ExecpcionClaseSalon : Exception
        {
            public ExecpcionClaseSalon()
            {
            }
            public ExecpcionClaseSalon(string message)
                : base(message)
            {
            }
            public ExecpcionClaseSalon(string message, Exception inner)
                : base(message, inner)
            {
            }
        
    }
}