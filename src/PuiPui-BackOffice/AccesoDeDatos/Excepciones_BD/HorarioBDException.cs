using System;

namespace PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD
{
    public class HorarioBDException : Exception 
    {
        public HorarioBDException() { }
        public HorarioBDException(string message): base(message) { }
        public HorarioBDException(string message, Exception inner): base(message, inner) { }
    }
}