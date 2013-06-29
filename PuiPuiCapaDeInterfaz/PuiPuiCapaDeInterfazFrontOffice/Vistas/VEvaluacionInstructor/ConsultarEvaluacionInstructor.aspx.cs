using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTInstructor;
using PuiPuiCapaDeInterfazFrontOffice.Presentadores.PInstructor;

namespace PuiPuiCapaDeInterfazFrontOffice.Vistas.VEvaluacionInstructor
{
    public partial class ConsultarEvaluacionInstructor : System.Web.UI.Page, IContratoConsultarEvaluacionInstructor
    {
        private int _idClase = 0;

        public Boolean RBConsultaCompleta {
            get { return RadioButtonConsultaCompleta.Checked; }
            set { RadioButtonConsultaCompleta.Checked = value; }
        }

        public Boolean RBconsultaInstructorPorNombres
        {
            get { return consultaClasePorNombres.Checked; }
            set { consultaClasePorNombres.Checked = value; }

        }
        public String TextNombreInstrutor
        {
            get { return nombreInstructor.Text; }
            set { nombreInstructor.Text = value; }
        }
        public int SessionID
        {
            get { return _idClase; }
            set { _idClase = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void botonBuscarClase_Click(object sender, EventArgs e)
        {

            PConsultarEvaluacionInstructor consultar = new PConsultarEvaluacionInstructor(this);
            GridConsulta.DataSource = consultar.ConsultaClase();
            if (GridConsulta.DataSource != null)
            {
                Exito.Visible = true;
                GridConsulta.DataBind();
            }
            else
            {
                falla.Visible = true;

            }
        }

        protected void GridConsultar_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Consultar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridConsulta.Rows[index];
                String _id = Convert.ToString(row.Cells[1].Text);
                String _fecha = Convert.ToString(row.Cells[2].Text);
                String _observacion = Convert.ToString(row.Cells[3].Text);
                String _cliente = Convert.ToString(row.Cells[4].Text);
                String _instructor = Convert.ToString(row.Cells[5].Text);
                String _calificacion = Convert.ToString(row.Cells[6].Text);
                char[] charsToTrim = { '*', ' ', '\'', 'O', ':' };
                char[] charsToTrim1 = { '*', ' ', '\'', ':' };
                _observacion = _observacion.Trim(charsToTrim1);
                Response.Redirect("ModificarEvaluacionInstructor.aspx?id=" + _id + "&fecha=" + _fecha + "&observacion=" + _observacion + "&cliente=" + _cliente + "&instructor=" + _instructor + "&calificacion=" + _calificacion);
            }
        }
    }
}