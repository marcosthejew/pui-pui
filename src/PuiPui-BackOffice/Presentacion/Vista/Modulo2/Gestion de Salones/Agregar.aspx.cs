using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Geestion_de_Salones
{
    public partial class Agregar : System.Web.UI.Page
    {
        private LogicaSalon _objetoLogica;

        public Agregar() 
        { 
            this._objetoLogica = new LogicaSalon();
        
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {
            bool _resultado = _objetoLogica.AgregarSalones(TextBoxUbicacion.Text, Convert.ToInt32(TextBoxCapacidad.Text));

            if (_resultado != false)
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