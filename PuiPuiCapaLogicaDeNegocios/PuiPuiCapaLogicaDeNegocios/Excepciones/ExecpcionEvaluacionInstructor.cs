using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Excepciones
{
    public class ExecpcionEvaluacionInstructor: AExcepcionLogicaPuiPui
    {
        
        public ExecpcionEvaluacionInstructor(string message) : base(message) { }
        public ExecpcionEvaluacionInstructor(string message, Exception inner) : base(message, inner) { }
    }
}