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
    public partial class VistaModificarEjercicio : System.Web.UI.Page, IContratoModificarEjercicio
    {
        private PModificarEjercicio _presentadorModificarComando;

        public String NombreDeEjercicio
        {
            get {return ddlEjercicios.Text;}
            set {ddlEjercicios.Text = value;}
        }

        public String tbNombreEjercicio
        {
            get {return tbNombre.Text;}
            set { tbNombre.Text= value; }
        }

        public String tbDescripcionEjer
        {
            get {return tbDescripcion.Text;}
            set { tbDescripcion.Text= value; }
        }

        public String MusculoAEjercitar
        {
            get {return ddlMusculo.Text;}
            set { ddlMusculo .Text= value; }
        }

        public VistaModificarEjercicio()
        {
            _presentadorModificarComando = new PModificarEjercicio(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bModificar_Click(object sender, EventArgs e)
        {
            _presentadorModificarComando.Click_ModificarEjercicio();
        }
    }
}