using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Excepciones
{
    public class ExcepcionInstructorConexionBD : AExcepcionLogicaPuiPui
    {
        public ExcepcionInstructorConexionBD(string message) : base(message) { }
        public ExcepcionInstructorConexionBD(string message, Exception inner) : base(message, inner) { }
    }
}