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
    public partial class Home : System.Web.UI.Page
    {
        Acceso acceso = new Acceso();
        Persona persona = new Persona();
        LogicaPersona logicaPersona = new LogicaPersona();

        protected void Page_Load(object sender, EventArgs e)
        {
            Acceso acceso = new Acceso();
            acceso = (Acceso)Session["loginPersona"];
            string a = acceso.Login;
            Session["loginPersona"] = acceso;
            persona = logicaPersona.ConsultarPersonaPorLogin(a);

            
            
            Session["idPersona"] = persona;
            Label1.Text = a;
        }

        
        

    }
}