namespace PuiPui_BackOffice.AccesoDeDatos.Excepciones_BD
{
    public class ExcepcionConexion : System.Exception
    {
        public ExcepcionConexion() { }
        public ExcepcionConexion(string message) : base(message) { }
        public ExcepcionConexion(string message, System.Exception inner) : base(message, inner) { }
    }
}