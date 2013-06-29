using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTInstructor;
using PuiPuiCapaDeInterfazBackOffice.Presentadores.PInstructor;

namespace PuiPuiCapaDeInterfazBackOffice.Vistas.VInstructor
{
    public partial class EliminarInstructor : System.Web.UI.Page, IContratoEliminarInstructor
    {
        private PEliminarInstructor _presentador;

        public EliminarInstructor() 
        {
            _presentador = new PEliminarInstructor(this);
        }

        public String ElegirInstructor
        {
            get
            {
                return dp1.SelectedItem.ToString();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Desactivar_Click(object sender, EventArgs e)
        {

        }
    }
}