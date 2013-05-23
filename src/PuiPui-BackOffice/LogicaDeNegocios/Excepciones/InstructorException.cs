using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_BackOffice.LogicaDeNegocios.Excepciones
{
    public class InstructorException : Exception
    {
        public InstructorException()
        {
        }
        public InstructorException(string message)
            : base(message)
        {
        }
        public InstructorException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}