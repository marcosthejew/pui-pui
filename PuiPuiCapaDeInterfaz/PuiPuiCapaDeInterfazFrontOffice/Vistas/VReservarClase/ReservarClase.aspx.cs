using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Collections.Generic;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTReservarClase;
using PuiPuiCapaDeInterfazFrontOffice.Contratos;
using PuiPuiCapaDeInterfazFrontOffice.Presentadores.PReservarClase;

namespace PuiPuiCapaDeInterfazFrontOffice.Vistas.VReservarClases
{
    public partial class ReservarClase : System.Web.UI.Page, IContratoReservarClase
    {

        private PReservarClase _presentador;

        protected void Page_Load(object sender, EventArgs e)
        {
            _presentador = new PReservarClase(this);
        }

        public String lbNombreClase
        {
            get { return nombreClase.Text; }
            set { nombreClase.Text = value; }
        }

   }
}