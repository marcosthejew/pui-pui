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
    public partial class VistaDesactivarEjercicio : System.Web.UI.Page, IContratoDesactivarEjercicio
    {
        private PDesactivarEjercicio _presentadorDesactivarEjercicio;

        public String ElegirEjercicio{
            get { return ddlEjercicios.SelectedItem.ToString();}
        }

        public String NombreDelEjercicio 
        {
            get {return tbNombre.Text;}
            set {tbNombre.Text=value;}
        }

        public String DescripcionDelEjercicio
        {
            get { return tbDescripcion.Text;}
            set { tbDescripcion.Text = value;}
        }

        public String NombreDelMusculo
        {
            get {return tbMusculo.Text;}
            set {tbMusculo.Text = value;}
        }

        public VistaDesactivarEjercicio()
        {
            _presentadorDesactivarEjercicio = new PDesactivarEjercicio(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Desactivar_Click(object sender, EventArgs e)
        {
            //_presentadorDesactivarEjercicio.Click_PDesactivarEjercicio();
        }
    }
}