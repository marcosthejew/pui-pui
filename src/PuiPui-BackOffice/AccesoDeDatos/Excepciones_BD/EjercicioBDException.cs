using System;

namespace PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD
{
    public class EjercicioBDException : Exception
    {
        public EjercicioBDException() { }
        public EjercicioBDException(string message): base(message) { }
        public EjercicioBDException(string message, Exception inner): base(message, inner) { }
    }
}