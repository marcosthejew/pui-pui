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
            set { SessionID= value; }

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

    }
}