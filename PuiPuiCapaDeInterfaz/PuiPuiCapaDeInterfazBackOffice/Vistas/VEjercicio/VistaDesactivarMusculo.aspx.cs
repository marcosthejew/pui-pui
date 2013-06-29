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
        #region Atributo
        private PDesactivarMusculo _presentadorDesactivarMusculo;
        #endregion

        #region Getter and Setter
        public String Musculo
        {
            get { return _nombre.SelectedItem.ToString(); }
        }

        public String Exito
        {
            get { return _exito.Text; }
            set { _exito.Text = value; }
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

        #region Metodos
        protected void Page_Load(object sender, EventArgs e)
        {
            _presentadorDesactivarMusculo.CargarMusculos();
        }

         public VistaDesactivarMusculo()
         {
             _presentadorDesactivarMusculo = new PDesactivarMusculo(this);
         }
                
         protected void desactivar_Click(object sender, EventArgs e)
         {
              _presentadorDesactivarMusculo.DesactivarMusculo(0, Musculo);
         }
        #endregion
    }
}