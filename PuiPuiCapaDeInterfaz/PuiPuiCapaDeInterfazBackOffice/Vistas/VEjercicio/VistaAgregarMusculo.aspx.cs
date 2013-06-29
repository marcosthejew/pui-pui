using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazBackOffice.Presentadores.PEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;

namespace PuiPuiCapaDeInterfazBackOffice.Vistas.VEjercicio
{
    public partial class VistaAgregarMusculo : System.Web.UI.Page, IContratoAgregarMusculo
    {
        private PAgregarMusculo _pAgregarMusculo;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
      
        public VistaAgregarMusculo()
        {
            _pAgregarMusculo = new PAgregarMusculo(this);
        }

        public String nombreMusculo
        {
            get{ return tbNombre.Text;}
            set { tbNombre.Text = value; }           
        }

        public String descripcionMusculo
        {
            get { return tbDescripcion.Text; }
            set { tbDescripcion.Text = value; }
        }        

        public void Aceptar_Click(object sender, EventArgs e)
        {
            _pAgregarMusculo.AgregarMusculo();
        }
   
    }
}