using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_FrontOffice.Entidades.Cliente;
using PuiPui_FrontOffice.LogicaDeNegocios.Cliente;

namespace PuiPui_FrontOffice.Presentacion.Vista.Home
{
    public partial class CambiarContraseña : System.Web.UI.Page
    {
        Persona persona;
        Acceso acceso;
        LogicaPersona logicaPersona = new LogicaPersona();
        string loginPersona;
        string passwordPersona;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                persona = (Persona)Session["idPersona"];
                int idPersona = persona.IdPersona;



                if (!IsPostBack)
                {

                }

            }
            catch (NullReferenceException)
            {

                Response.Redirect("Presentacion/Vista/Home/Login.aspx");
            }

        }

        protected void ChangePassword1_ChangingPassword(object sender, LoginCancelEventArgs e)
        {
            persona.PasswordPersona = ChangePassword1.ConfirmNewPassword;


            bool cambio = logicaPersona.CambiarContraseña(persona);
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

 
    }
}