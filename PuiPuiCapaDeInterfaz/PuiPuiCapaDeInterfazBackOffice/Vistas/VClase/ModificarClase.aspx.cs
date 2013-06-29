using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTClase;
using PuiPuiCapaDeInterfazBackOffice.Presentadores.PClase;

namespace PuiPuiCapaDeInterfazBackOffice.Vistas.VClase
{
    public partial class ModificarClase : System.Web.UI.Page,IContratoModificaClase
    {
        private int _idClase = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            String _id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            String _clase = Convert.ToString((Request.QueryString["nombre"] != null) ? Request.QueryString["nombre"] : "");
            String _descripcion = Convert.ToString((Request.QueryString["descripcion"] != null) ? Request.QueryString["descripcion"] : "");
           String _status = Convert.ToString((Request.QueryString["status"] != null) ? Request.QueryString["status"] : "");
           _idClase = int.Parse(_id);
            if (!IsPostBack)
            {
                nombreClaseAModificar.Text = _clase;
                TADescripcion.Text = _descripcion;
                if (_status.Equals("Activo"))
                    Activo.Checked = true;
                else
                    Inactivo.Checked = true;
            }

        }

        public String TxtClaseModificar {
            get { return nombreClaseAModificar.Text; }
            set { nombreClaseAModificar.Text = value; }
        
        }
        public String TADescripcionModificar
        {
            get { return TADescripcion.Text; }
            set { TADescripcion.Text = value; }

        }
        public Boolean RBStatus_Activo {

            get { return Activo.Checked; }
            set { Activo.Checked = value; }
        }
        public Boolean RBStatus_Inactivo
        {

            get { return Inactivo.Checked; }
            set { Inactivo.Checked = value; }
        }
        public int idClase {
            get { return _idClase; }
            set { idClase = value; }
        
        }

        protected void botonAceptar_Click(object sender, EventArgs e)
        {
            if((nombreClaseAModificar.Text.Equals(""))||(TADescripcion.Text.Equals(""))||((Activo.Checked==false)&&(Inactivo.Checked==false)))
            {
            
               NClase.Visible=true;
            
            
            
            }
            else
            {
            PModificarClase modificarClase = new PModificarClase(this);
            bool seModifico = modificarClase.ModificarClase();
                if(seModifico==true)
                    Exito.Visible=true;
                else
                      falla.Visible=true;

            }
        }

        protected void botonRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarClases.aspx");
        }
        

    }
}