using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_de_Clases
{
    public partial class Agregar : System.Web.UI.Page
    {

        private LogicaClase _objLogica;
       
        public Agregar() 
        {
            this._objLogica = new LogicaClase();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void defaultButton_Click(object sender, EventArgs e)
        {

            _objLogica.AgregarClase(nombreNuevaClase.Text, descripcioNuevaClase.Text);
        }
    }
}