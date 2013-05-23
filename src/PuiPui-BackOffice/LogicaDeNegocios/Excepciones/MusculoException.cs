using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_BackOffice.LogicaDeNegocios.Excepciones
{
    public class MusculoException : Exception
    {
         public MusculoException()
          {
          }
         public MusculoException(string message)
          : base(message)
          {
          }
       public MusculoException(string message, Exception inner)
          : base(message, inner)
          {
          }
    }
}