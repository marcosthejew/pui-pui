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
    public partial class ConsultarClases : System.Web.UI.Page, IContratoConsultarClase
    {
        private int _idClase = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public String TextNombreClase
        {
            get { return nombreClase.Text; }
            set { nombreClase.Text = value; }

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

        public String DPLStatus
        {
            get { return DropDownListEstatusClase.SelectedValue.ToString(); }
            set { DropDownListEstatusClase.Text = value; }

        }
        public int SessionID
        {
            get { return _idClase; }
            set { SessionID = value; }

        }

        public bool RBPorStatus
        {
            get { return consultaClasePorEstatus.Checked; }
            set { RBPorStatus = value; }

        }

        protected void botonBuscarClase_Click(object sender, EventArgs e)
        {
            PConsultarClase consultar = new PConsultarClase(this);
            GridConsultar.DataSource = consultar.ConsultaClase();
            if (GridConsultar.DataSource != null)
            {
                Exito.Visible = true;
                GridConsultar.DataBind();
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
                GridViewRow row = GridConsultar.Rows[index];
                String _id = Convert.ToString(row.Cells[1].Text);
                String _nombre = Convert.ToString(row.Cells[2].Text);
                String _descripcion = Convert.ToString(row.Cells[3].Text);
                String _status = Convert.ToString(row.Cells[4].Text);
                Session["_idClase"] = _id;
                char[] charsToTrim = { '*', ' ', '\'', 'O', ':' };
                char[] charsToTrim1 = { '*', ' ', '\'', ':' };
                _nombre = _nombre.Trim(charsToTrim1);
                Response.Redirect("DetalleConsultaClase.aspx?nombre=" + _nombre + "&status=" + _status + "&id=" + _id + "&descripcion=" + _descripcion);
            }

        }
    }
}