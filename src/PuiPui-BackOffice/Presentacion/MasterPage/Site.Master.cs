using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.Entidades.Cliente;

namespace PuiPui_BackOffice
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {

        Persona persona;
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
       
     


