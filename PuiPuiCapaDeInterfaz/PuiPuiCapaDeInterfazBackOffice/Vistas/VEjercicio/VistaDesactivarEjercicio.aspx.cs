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
        #region Atributos
        private PDesactivarEjercicio _presentadorDesactivarEjercicio;
        #endregion

        #region Getter and Setter
        public String Ejercicio{
            get { return _nombre.SelectedItem.ToString(); }
        }

        public String Exito 
        {
            get { return _exito.Text; }
            set {_exito.Text=value;}
        }

        public DropDownList ComboMusculo
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Label Mensaje
        {
            get { return _exito; }
        }
        #endregion

        #region Atributos
        public VistaDesactivarEjercicio()
        {
            _presentadorDesactivarEjercicio = new PDesactivarEjercicio(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _presentadorDesactivarEjercicio.CargarEjercicios();
        }

        protected void Desactivar_Click(object sender, EventArgs e)
        {
            _presentadorDesactivarEjercicio.Click_PDesactivarEjercicio();
        }
        #endregion
    }
}