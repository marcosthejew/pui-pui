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
    public partial class VistaAgregarEjercicio : System.Web.UI.Page, IAgregarEjercicio
    {
        #region Atributos
        PAgregarEjercicio _presentadorEjercicio;
        #endregion

        #region Getter & Setter
        public string Nombre
        {
            get { return _nombre.Text; }
            set { _nombre.Text = value; }

        }
        public string Descripcion
        {
            get { return _descripcion.Text; }
            set { _descripcion.Text = value; }

        }
        public string Musculos
        {
            get { return _musculo.SelectedItem.ToString(); }
            
        }
        public string Exito
        {
            get { return _exito.Text; }
            set { _exito.Text = value; }

        }
        public DropDownList ComboMusculo
        {
            get{return _musculo;}
            set { _musculo = value; }
        }
        public Label Mensaje
        {
            get { return _exito; }
        }
        #endregion

        #region Constructor
        public VistaAgregarEjercicio()
        {
            _presentadorEjercicio = new PAgregarEjercicio(this);
        }
        #endregion

        #region Metodos

        protected void Page_Load(object sender, EventArgs e)
        {
            _presentadorEjercicio.CargarMusculos();
        }

        protected void bAgregar_Click(object sender, EventArgs e)
        {
            _presentadorEjercicio.AgregarEjercicio(Nombre,Descripcion,Musculos);
        }
                
        #endregion
    }
}