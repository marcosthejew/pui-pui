using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Excepciones
{
    public class ExcepcionMusculoConexionBD:AExcepcionLogicaPuiPui
    {
        public ExcepcionMusculoConexionBD(string message): base(message) { }
        public ExcepcionMusculoConexionBD(string message, Exception inner) : base(message, inner) { }
    }
}