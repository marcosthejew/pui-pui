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
        #region Atributos
        private PAgregarMusculo _pAgregarMusculo;
        #endregion
              
        #region Constructor
        public VistaAgregarMusculo()
        {
            _pAgregarMusculo = new PAgregarMusculo(this);
        }
        #endregion

        #region Getter and Setter
        public String nombreMusculo
        {
            get { return _nombre.Text; }
            set { _nombre.Text = value; }           
        }

        public String descripcionMusculo
        {
            get { return _descripcion.Text; }
            set { _descripcion.Text = value; }
        }

        public String Exito
        {
            get { return _exito.Text; }
            set { _exito.Text = value; }
        }

        public Label Mensaje
        {
            get { return _exito; }
        }
        #endregion

        #region Metodos
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Aceptar_Click(object sender, EventArgs e)
        {
           _pAgregarMusculo.AgregarMusculo(nombreMusculo,descripcionMusculo);
        }
            
    }
        #endregion  
    
}