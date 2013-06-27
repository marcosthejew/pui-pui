using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazBackOffice.Contractos.CTSalon;
using PuiPuiCapaDeInterfazBackOffice.Presentadores.PSalon;
namespace PuiPuiCapaDeInterfazBackOffice.Vistas.VSalon
{
    public partial class AgregarSalon : System.Web.UI.Page,IContratoAgregarSalon
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public String TxtCodigoSalon
        {

            get { return TextBoxCodigo.Text; }
            set { TextBoxCodigo.Text=value; }
        
        }
        public int TextCapacidadSalon
        {

            get { return (int.Parse(TextBoxCapacidad.Text)); }
            set { TextCapacidadSalon = value; }

        }
        public String TxtNombreSalon
        {

            get { return TextBoxUbicacion.Text; }
            set { TextBoxUbicacion.Text = value; }
        }
        protected void Cancelar_Click(object sender, EventArgs e)
        {

        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {

            if ((TextBoxCodigo.Text.Equals("")) || (TextBoxUbicacion.Text.Equals("")) || (TextBoxCapacidad.Text.Equals("")))
            {
                NClase.Visible = true;
            }
            else
            {
                NClase.Visible = false;
                PAgregarSalon agrega = new PAgregarSalon(this);
                agrega.AgregarSalon();
                if (agrega.AgregarSalon() == true)
                {
                    Exito.Visible = true;

                }
                else
                {

                    falla.Visible = true;
                
                }
            }
        }
    }
}