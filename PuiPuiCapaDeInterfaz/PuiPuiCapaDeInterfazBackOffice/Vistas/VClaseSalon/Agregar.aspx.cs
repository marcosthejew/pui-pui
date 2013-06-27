using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTClaseSalon;

namespace PuiPuiCapaDeInterfazBackOffice.Vistas.VClaseSalon
{
    public partial class Agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {

        }

        protected void defaultButton_Click(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        public DropDownList salones {

            get { return ComboSalon; }
            set { salones = value; }
        }
        public DropDownList clases
        {
            get { return ComboClase; }
            set { clases = value; }
        
        }
        public DropDownList instructores
        {
            get { return ComboInstructor; }
            set { instructores = value; }
        
        
        }
        public string hora_inicio
        {
            get {return TBHoraInicio.Text; }
            set { hora_inicio = value; }
        }

        public string hora_fin
        {
            get { return TBHoraFin.Text; }
            set { hora_fin = value; }
        }
    }

}