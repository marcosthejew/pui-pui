using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Excepciones
{
    public class ExcepcionEjercicioConexionBD: AExcepcionLogicaPuiPui
    {

        public ExcepcionEjercicioConexionBD(string message): base(message) { }
        public ExcepcionEjercicioConexionBD(string message, Exception inner) : base(message, inner) { }
    }
}