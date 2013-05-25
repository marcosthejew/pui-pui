using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_FrontOffice.Entidades.Cliente;

namespace PuiPui_FrontOffice
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        Acceso acceso;
        string loginPersona;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                acceso = (Acceso)Session["loginPersona"];
                loginPersona = acceso.Login;

            }
            catch (NullReferenceException)
            {
         
            }

        }

        protected void BRegistrar_Click(object sender, EventArgs e)
        {
            acceso.Login = null;
            acceso.Password = null;

            Session.Abandon();

            Response.Redirect("../../Home/Login.aspx");


        }
    }
}
