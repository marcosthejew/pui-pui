using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_BackOffice.PruebasUnitarias.Excepciones
{
    public class ExcepcionCliente : System.Exception
    {
        public ExcepcionCliente() : base() { }
        public ExcepcionCliente(string message) : base(message) { }
        public ExcepcionCliente(string message, System.Exception inner) : base(message, inner) { }

    }
}