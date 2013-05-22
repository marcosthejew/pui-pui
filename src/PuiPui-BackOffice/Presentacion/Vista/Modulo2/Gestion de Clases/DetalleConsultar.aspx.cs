using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_de_Clases
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            String nombre = Convert.ToString((Request.QueryString["nombre"] != null) ? Request.QueryString["nombre"] : "");
            String estatus = Convert.ToString((Request.QueryString["estatus"] != null) ? Request.QueryString["estatus"] : "");
        }
    }
}