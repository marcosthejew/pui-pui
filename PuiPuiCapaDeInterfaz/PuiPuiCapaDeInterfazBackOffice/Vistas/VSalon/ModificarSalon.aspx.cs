using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTSalon;

namespace PuiPuiCapaDeInterfazBackOffice.Vistas.VSalon
{
    public partial class ModificarSalon : System.Web.UI.Page,IContratoModificarSalon
    {
        private int _id;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public int SessionID {
            get { return _id; }
            set { _id = value; }
        
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
            if ((TextBoxCodigo.Text.Equals("")) || (TextBoxUbicacion.Text.Equals("")) || (TextBoxCapacidad.Text.Equals("")) || (Activo.Checked == false) || (Inactivo.Checked = false))
            {
                NClase.Visible = true;
            }
            else
            { 
            
            
            }
        }
    }
}