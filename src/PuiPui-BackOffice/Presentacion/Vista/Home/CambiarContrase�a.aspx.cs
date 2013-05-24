using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.Entidades.Cliente;
using PuiPui_BackOffice.LogicaDeNegocios.Cliente;

namespace PuiPui_BackOffice.Presentacion.Vista.Home
{
    public partial class CambiarContraseña : System.Web.UI.Page
    {
        Persona persona;
        LogicaPersona logicaPersona = new LogicaPersona();

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

                Response.Redirect("Login.aspx");
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