using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Excepciones
{
    public class ExecpcionClaseSalon: AExcepcionLogicaPuiPui
    {
        
        public ExecpcionClaseSalon(string message) : base(message) { }
        public ExecpcionClaseSalon(string message, Exception inner) : base(message, inner) { }
    }
}