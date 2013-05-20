using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPui_FrontOffice.Entidades.Cliente
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