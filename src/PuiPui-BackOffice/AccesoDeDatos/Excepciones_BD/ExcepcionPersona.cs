namespace PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD
{
    public class ExcepcionPersona : System.Exception
    {
        public ExcepcionPersona() { }
        public ExcepcionPersona(string message) : base(message) { }
        public ExcepcionPersona(string message, System.Exception inner) : base(message, inner) { }
    }
}