using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTRutina;
using PuiPuiCapaDeInterfazFrontOffice.Presentadores.PRutina;


namespace PuiPuiCapaDeInterfazFrontOffice.Vistas.VRutina
{
    public partial class AgregarRutina : System.Web.UI.Page, IContratoAgregarRutina
    {

        #region Atributos

        private PresentadorAgregarRutina _presentador;

        #endregion


        #region Constructor

        public AgregarRutina()
        {
            _presentador = new PresentadorAgregarRutina(this);
        }
        #endregion

        #region Contrato

        public Label Lerror
        {
            get { return Lerror; }
            set { Lerror = value; }
        }

        public TextBox nombre
        {
            get { return LNombre; }
            set { LNombre = value; }
        }

        public TextBox descripcion
        {
            get { return LDescripcion; }
            set { LDescripcion = value; }
        }

        public RadioButton Rduracion
        {
            get { return duracionRadioButton; }
            set { duracionRadioButton = value; }
        }

        public RadioButton Rrepeticion
        {
            get { return repeticionRadioButton; }
            set { repeticionRadioButton = value; }
        }

        public TextBox Tduracion
        {
            get { return LDuracion; }
            set { LDuracion = value; }
        }

        public TextBox Trepeticion
        {
            get { return LRepeticiones; }
            set { LRepeticiones = value; }
        }

        public ListBox ejercicioNoAsociado
        {
            get { return LBEjercicioNoAsociado; }
            set { LBEjercicioNoAsociado = value; }
        }

        public ListBox ejercicioAsociado
        {
            get { return LBEjercicioAsociado; }
            set { LBEjercicioAsociado = value; }
        }

        #endregion

        #region Metodos



        public void Page_Load(object sender, EventArgs e)
        {
            _presentador.PageLoad(sender, e);

            if (!IsPostBack)
            { 
            
            }
        }

        
        public void AgregarEjercicio_Click(object sender, EventArgs e)
        {
            //_presentador.BotonAgregarEjercicio(sender, e);
        }

        public void EliminarEjercicio_Click(object sender, EventArgs e)
        {
            //_presentador.BotonEliminarEjercicio(sender, e);
        }

        public void BGuardar_Click(object sender, EventArgs e)
        {
            _presentador.Agregar();
        }


        public void repeticionRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void duracionRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void EjercicioNoAsociado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void EjercicioAsociado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        


        #endregion 

    }
}
