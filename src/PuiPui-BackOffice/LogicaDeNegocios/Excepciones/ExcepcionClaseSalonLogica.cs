using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_BackOffice.LogicaDeNegocios.Excepciones
{
    public class ExcepcionClaseSalonLogica: Exception
    {
        public ExcepcionClaseSalonLogica()
        {
        }
        public ExcepcionClaseSalonLogica(string message)
            : base(message)
        {
        }
        public ExcepcionClaseSalonLogica(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}