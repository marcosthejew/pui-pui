using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Presentadores.PEjercicio;

namespace PuiPuiCapaDeInterfazBackOffice.Vistas.VEjercicio
{
    public partial class VistaDesactivarMusculo : System.Web.UI.Page, IContratoDesactivarMusculo
    {
        private PDesactivarMusculo _presentadorDesactivarMusculo;

        public String MusculoADesactivar
        {
            get { return ddlMusculo.SelectedItem.ToString(); }
        }

         protected void Page_Load(object sender, EventArgs e)
        {

        }

         public VistaDesactivarMusculo()
         {
             _presentadorDesactivarMusculo = new PDesactivarMusculo(this);
         }
    }
}