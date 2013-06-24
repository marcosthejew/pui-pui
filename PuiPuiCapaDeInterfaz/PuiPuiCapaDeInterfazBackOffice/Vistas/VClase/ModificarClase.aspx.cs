using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTClase;

namespace PuiPuiCapaDeInterfazBackOffice.Vistas.VClase
{
    public partial class ModificarClase : System.Web.UI.Page,IContratoModificaClase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public String TxtClaseModificar {
            get { return nombreClaseAModificar.Text; }
            set { nombreClaseAModificar.Text = value; }
        
        }
        public String TADescripcionModificar
        {
            get { return TADescripcion.Text; }
            set { TADescripcion.Text = value; }

        }
        public Boolean RBStatus_Activo {

            get { return Activo.Checked; }
            set { Activo.Checked = value; }
        }
        public Boolean RBStatus_Inactivo
        {

            get { return Inactivo.Checked; }
            set { Inactivo.Checked = value; }
        }


    }
}