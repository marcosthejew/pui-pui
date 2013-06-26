using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuiPuiCapaDeInterfazBackOffice.Vistas.VSalon
{
    public partial class ModificarSalon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {
            if ((TextBoxCodigo.Text.Equals("")) || (TextBoxUbicacion.Text.Equals("")) || (TextBoxCapacidad.Text.Equals("") )||(Activo.Checked==false)||(Inactivo.Checked=false) )
            {
                NClase.Visible = true;
            }
        }
    }
}