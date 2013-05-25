namespace PuiPui_BackOffice.Entidades.Cliente
{
    public class Acceso
    {
        private string _login;

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Acceso()
        {

        }
    }
}