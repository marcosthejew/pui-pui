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
    public partial class ConsultarInstructor : System.Web.UI.Page, IContratoConsultarInstructor
    {
        #region Atributos

        private PConsultarInstructor _presentador;

        #endregion

        #region Constructor

        public ConsultarInstructor() 
        {
            _presentador = new PConsultarInstructor(this);
        
        }

        #endregion

        public String NombreInstructorAConsultar
        {
            get { return ddlInstructores.SelectedItem.ToString(); }
        }

        public DropDownList ListaInstructores
        {
            get { return ddlInstructores; }
        }

        public String cedulaInstructor
        {
            /*get
            {
                return tbcedula.Text;
            }*/
            set
            {
                lbCedula.Text = value;
            }
        }

        public String primerNombreInstructor
        {
            /*get
            {
                return tbprimer_nombre.Text;
            }*/
            set
            {
                lbNombre1.Text = value;
            }
        }

        public String segundoNombreInstructor
        {
            /*get
            {
                return tbsegundo_nombre.Text;
            }*/
            set
            {
                lbNombre2.Text = value;
            }
        }

        public String primerApellidoInstructor
        {
            /*get
            {
                return tbprimer_apellido.Text;
            }*/
            set
            {
                lbApellido1.Text = value;
            }
        }

        public String segundoApellidoInstructor
        {
            /*get
            {
                return tbsegundo_apellido.Text;
            }*/
            set
            {
                lbApellido2.Text = value;
            }
        }

        public String sexoInstructor
        {
            /*get
            {
                return tbsegundo_apellido.Text;
            }*/
            set
            {
                lbGenero.Text = value;
            }
        }

        public String fechaNacimientoInstructor
        {
            /*get
            {
                return tbsegundo_apellido.Text;
            }*/
            set
            {
                lbFechaNac.Text = value;
            }
        }

        public String fechaIngresoInstructor
        {
            /*get
            {
                return tbsegundo_apellido.Text;
            }*/
            set
            {
                lbFechaRes.Text = value;
            }
        }

        public String ciudadInstructor
        {
            /*get
            {
                return tbsegundo_apellido.Text;
            }*/
            set
            {
                lbCiudad.Text = value;
            }
        }

        public String direccionInstructor
        {
            /*get
            {
                return tbsegundo_apellido.Text;
            }*/
            set
            {
                lbDireccion.Text = value;
            }
        }

        public String telefonoLocalInstructor
        {
            /*get
            {
                return tbsegundo_apellido.Text;
            }*/
            set
            {
                lbTlfLocal.Text = value;
            }
        }

        public String telefonoCelularInstructor
        {
            /*get
            {
                return tbsegundo_apellido.Text;
            }*/
            set
            {
                lbTlfCel.Text = value;
            }
        }

        public String correoInstructor
        {
            /*get
            {
                return tbsegundo_apellido.Text;
            }*/
            set
            {
                lbMail.Text = value;
            }
        }

        public String nombreContactoInstructor
        {
            /*get
            {
                return tbsegundo_apellido.Text;
            }*/
            set
            {
                lbNomContacto.Text = value;
            }
        }

        public String telefonoContactoInstructor
        {
            /*get
            {
                return tbsegundo_apellido.Text;
            }*/
            set
            {
                lbTLfContacto.Text = value;
            }
        }

        public String statusInstructor
        {
            /*get
            {
                return tbsegundo_apellido.Text;
            }*/
            set
            {
                lbStatus.Text = value;
            }
        }

                
        
        protected void Page_Load(object sender, EventArgs e)
        {
            _presentador.CargarInstructores();
        }

        protected void ddlInstructores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}