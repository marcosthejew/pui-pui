using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Geestion_de_Salones
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Home/Modulo2/Geestion_de_Salones/Consultar.aspx");
        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Home/Modulo2/Geestion_de_Salones/Modificar.aspx");
        }
    }
}