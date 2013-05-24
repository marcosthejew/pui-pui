using System;

namespace PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD
{
    public class MusculoBDException : Exception
    {
        public MusculoBDException() { }
        public MusculoBDException(string message): base(message) { }
        public MusculoBDException(string message, Exception inner): base(message, inner){ }
    }
}