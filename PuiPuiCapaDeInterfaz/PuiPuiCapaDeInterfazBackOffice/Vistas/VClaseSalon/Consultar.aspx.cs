using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTClaseSalon;
using PuiPuiCapaDeInterfazBackOffice.Presentadores.PClaseSalon;
namespace PuiPuiCapaDeInterfazBackOffice.Vistas.VClaseSalon
{
    public partial class Consular : System.Web.UI.Page,IContratoConsultarClaseSalon
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public Boolean RBTodos {
            get { return Todos.Checked; }
            set { RBTodos = value; }
        
        }
        
        public Boolean RBSalon 
        {
            get { return consultaSalon.Checked ; }
            set { RBSalon = value; }

        }
        public Boolean RBClase 
        {
            get { return RadioButtonConsultaCompleta.Checked; }
            set { RBClase = value; }

        }
        public Boolean RBInstructor
        {
            get { return consultaClasePorInstructor.Checked; }
            set { RBInstructor = value; }

        }
        public String TXTSalon {

            get { return nombreSalon.Text; }
            set { TXTSalon = value; }
        }
        public String TXTClase
        {

            get { return nombreClase.Text; }
            set { TXTClase = value; }
        }
        public String TXTInstructor
        {

            get { return nombreInstructor.Text; }
            set { TXTInstructor = value; }
        }

        protected void GridConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void botonBuscarClase_Click(object sender, EventArgs e)
        {
            PConsultaClaseSalon consulta = new PConsultaClaseSalon(this);
            GridConsultar.DataSource = consulta.Consulta();
            GridConsultar.DataBind();

        }

        protected void nombreClase_TextChanged(object sender, EventArgs e)
        {

        }

        protected void consultaClasePorInstructor_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void consultaClasePorNombres_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}