using System;

namespace PuiPui_BackOffice.LogicaDeNegocios.Excepciones
{
    public class HorarioException : Exception
    {
        public HorarioException() { }
        public HorarioException(string message): base(message) { }
        public HorarioException(string message, Exception inner) : base(message, inner) { }
    }
}