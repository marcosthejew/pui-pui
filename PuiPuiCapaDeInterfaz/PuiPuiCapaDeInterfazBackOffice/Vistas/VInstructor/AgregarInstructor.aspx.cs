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
    public partial class AgregarInstructor : System.Web.UI.Page, IContratoAgregarInstructor
    {
        #region Atributos

        private PAgregarInstructor _presentador;

        #endregion

        #region Constructor

        public AgregarInstructor()
        {
            _presentador = new PAgregarInstructor(this);
        }

        #endregion

        #region Metodos

        public string cedulaInstructor
        {
            get
            {
                return tbcedula.Text;
            }
            set
            {
                tbcedula.Text = value;
            }
        }

        public string primerNombreInstructor
        {
            get
            {
                return tbprimer_nombre.Text;
            }
            set
            {
                tbprimer_nombre.Text = value;
            }
        }

        public string segundoNombreInstructor
        {
            get 
            {
                return tbsegundo_nombre.Text;
            }
            set 
            {
                tbsegundo_nombre.Text = value;
            }     
        }

        public string primerApellidoInstructor
        {
            get
            {
                return tbprimer_apellido.Text;
            }
            set
            {
                tbprimer_apellido.Text = value;
            }
        }

        public string segundoApellidoInstructor
        {
            get
            {
                return tbsegundo_apellido.Text;
            }
            set
            {
                tbsegundo_apellido.Text = value;
            }
        }

        /*public string sexoInstructor
        {
            get 
            {
                return tb
            }
            set;
        }*/

        //public string fechaNacimientoInstructor { get; set; }

        //public string fechaIngresoInstructor { get; set; }

        /*public string entidadFederalInstructor
        {
            get 
            {
                return tb
            }
            set 
            {
            }
        }*/

        public string ciudadInstructor
        {
            get 
            {
                return tbciudad.Text;
            }
            set 
            {
                tbciudad.Text = value;
            }
        }

        public string direccionInstructor
        {
            get { return tbdireccion.Text; }
            set { tbdireccion.Text = value; }
        }

        public string telefonoLocalInstructor
        {
            get { return tbtelefono_local.Text; }
            set { tbtelefono_local.Text = value; }
        }

        public string telefonoCelularInstructor
        {
            get { return tbtelefono_celular.Text; }
            set { tbtelefono_celular.Text = value;}
        }

        public string correoInstructor
        {
            get { return tbemail.Text; }
            set { tbemail.Text = value; }
        }

        /*string horarioInstructor { get; set; }
        string nombreContactoInstructor { get; set; }
        string telefonoContactoInstructor { get; set; }
        string statusInstructor { get; set; }*/

        public string Exito
        {
            get { return lexito.Text; }
            set { lexito.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #endregion

        protected void Aceptar_Click(object sender, EventArgs e)
        {
            _presentador.ManejarClick();
        }
    }
}