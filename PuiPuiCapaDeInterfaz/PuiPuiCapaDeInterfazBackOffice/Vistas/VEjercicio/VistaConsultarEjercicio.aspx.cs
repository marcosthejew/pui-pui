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
    public partial class VistaConsultarEjercicio : System.Web.UI.Page, IContratoConsultarEjercicio
    {
        private PConsultarEjercicio _preConsultarEjercicio;

        public String NombreEjercicioAConsultar
        {
            get { return ddlEjercicios.SelectedItem.ToString(); }
        }

        public String NombreEjercicio
        {
            get { return tbNombre.Text; }
            set { tbNombre.Text = value; }
        }

        public String DescripcionMusculo
        {
            get { return tbDescripcion.Text; }
            set { tbDescripcion.Text = value; }
        }

        public String MusculoAEjercitar
        {
            get { return tbMusculo.Text; }
            set { tbMusculo.Text = value; }
        }

                protected void Page_Load(object sender, EventArgs e)
        {

        }

        public VistaConsultarEjercicio()
        {
          _preConsultarEjercicio = new PConsultarEjercicio(this);
        }

      
        
    }
}