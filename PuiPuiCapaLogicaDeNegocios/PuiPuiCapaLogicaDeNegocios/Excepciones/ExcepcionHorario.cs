using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Excepciones
{
    public class ExcepcionHorario : AExcepcionLogicaPuiPui
    {
          public ExcepcionHorario(string message) : base(message) { }
          public ExcepcionHorario(string message, Exception inner) : base(message, inner) { }
    }
}