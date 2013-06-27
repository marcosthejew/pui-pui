using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTInstructor;

namespace PuiPuiCapaDeInterfazFrontOffice.Vistas.VEvaluacionInstructor
{
    public partial class ConsultarTodosEvaluacionInstructor : System.Web.UI.Page,IContratoConsultarEvaluacionInstructor
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public String TextNombreClase
        {
            get { return nombreIntructor.Text; }
            set { nombreIntructor.Text = value; }

        }

        public Boolean RBConsultaCompleta
        {
            get { return RadioButtonConsultaCompleta.Checked; }
            set { RadioButtonConsultaCompleta.Checked = value; }


        }


        public Boolean RBconsultaClasePorNombres
        {
            get { return consultaClasePorNombres.Checked; }
            set { consultaClasePorNombres.Checked = value; }

        }


        protected void botonBuscarClase_Click(object sender, EventArgs e)
        {

        }



    }
}