using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTSalon;
using PuiPuiCapaDeInterfazBackOffice.Presentadores.PSalon;

namespace PuiPuiCapaDeInterfazBackOffice.Vistas.VSalon
{
    public partial class ModificarSalon : System.Web.UI.Page,IContratoModificarSalon
    {
        private int _idSalon = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            String _id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            String _codigo = Convert.ToString((Request.QueryString["codigo"] != null) ? Request.QueryString["codigo"] : "");
            String _ubicacion = Convert.ToString((Request.QueryString["ubicacion"] != null) ? Request.QueryString["ubicacion"] : "");
            String _capacidad = Convert.ToString((Request.QueryString["capacidad"] != null) ? Request.QueryString["capacidad"] : "");
            String _status = Convert.ToString((Request.QueryString["status"] != null) ? Request.QueryString["status"] : "");
            _idSalon = int.Parse(_id);
            if (!IsPostBack)
            {
            TextBoxCapacidad.Text = _capacidad;
            TextBoxCodigo.Text = _codigo;
            TextBoxUbicacion.Text = _ubicacion;
            if (_status.Equals("Activo"))
                Activo.Enabled = true;
            else
                Inactivo.Enabled = true;
            
            }
             
            
        }

        public int SessionID {
            get { return _idSalon; }
            set { SessionID = value; }
        
        }

        public Boolean RBStatus_Activo {
            get { return Activo.Checked; }
            set { RBStatus_Activo = value; }
        }
        public Boolean RBStatus_Inactivo {
            get { return Inactivo.Checked; }
            set { RBStatus_Inactivo = value; }
        
        }
        public String TXTSalonModificar {

            get { return TextBoxUbicacion.Text; }
            set { TXTSalonModificar = value; }
        }
        public String TXTSalonCodigo {

            get { return TextBoxCodigo.Text; }
            set { TXTSalonCodigo = value; }
        
        }
        public int TxtCapacidad {
            get { return int.Parse(TextBoxCapacidad.Text); }
            set { TxtCapacidad = value; }
        
        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {
            if ((TextBoxCodigo.Text.Equals("")) || (TextBoxUbicacion.Text.Equals("")) || (TextBoxCapacidad.Text.Equals("")) || ((Activo.Checked == false) && (Inactivo.Checked = false)))
            {
                NClase.Visible = true;
            }
            else
            {
                PModificarSalon modificar = new PModificarSalon(this);
                bool seModifico = modificar.ModificarSalon();
                if (seModifico == true)
                    Exito.Visible = true;
                else
                    falla.Visible = true;

            
            }
        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarSalon.aspx");
        }
    }
}