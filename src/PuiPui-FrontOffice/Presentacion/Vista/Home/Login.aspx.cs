using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_FrontOffice.LogicaDeNegocios.Cliente;
using PuiPui_FrontOffice.Entidades.Cliente;

namespace PuiPui_FrontOffice
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool Autenticado = false;
            LogicaPersona logicaPersona = new LogicaPersona();
            Acceso acceso = new Acceso();

            Autenticado = logicaPersona.LoginCorrecto(Login1.UserName, Login1.Password);
            e.Authenticated = Autenticado;
            if (Autenticado)
            {
                acceso.Login = Login1.UserName.ToString();
                acceso.Password = Login1.Password.ToString();
                Session["loginPersona"] = acceso;

                Response.Redirect("Home.aspx");
            }
        }
    }
}
