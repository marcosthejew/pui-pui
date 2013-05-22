using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_de_Clases
{
    public partial class Consultar : System.Web.UI.Page
    { 
        private List<Clase> _idClase;
        private String _nombreClase ;
        private int _estatusClase;
        private  LogicaClase logicaClase;
        private int seleccionCheck;

        public Consultar()
        {

            this._nombreClase = nombreClase.Text;
            this._estatusClase = Int32.Parse(DropDownListEstatusClase.SelectedValue);
            this.logicaClase = new LogicaClase();
        }
   
        protected void Page_Load(object sender, EventArgs e)
        {
                       
            
        }

        protected void GridConsultar_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
                GridConsultar.PageIndex = e.NewPageIndex;
                GridConsultar.DataSource = logicaClase.ConsultarClase();
                GridConsultar.DataBind();  
           
        }

        protected void GridConsultar_RowCommand(Object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Consultar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridConsultar.Rows[index];
                String id = Convert.ToString(row.Cells[1].Text);
                String nombre = Convert.ToString(row.Cells[2].Text);
                String estatus = Convert.ToString(row.Cells[3].Text);
                Session["idcita"] = id;
                char[] charsToTrim = { '*', ' ', '\'', 'O', ':' };
                char[] charsToTrim1 = { '*', ' ', '\'', ':' };    
                nombre = nombre.Trim(charsToTrim1);  

                Response.Redirect("DetalleConsultar.aspx?nombre=" + nombre + "&estatus=" + estatus + "&id=" + id);

            }


        }

        protected void botonBuscarClase_Click(object sender, EventArgs e)
        {
            switch (seleccionCheck)
            {
                case 1: 
                    
                GridConsultar.DataSource = logicaClase.ConsultarClase();
                GridConsultar.DataBind();

                break;
            }


        }

        protected void consultaClasePorNombres_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void consultaClasePorEstatus_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButtonConsultaCompleta_CheckedChanged1(object sender, EventArgs e)
        {
            seleccionCheck = 1;
        }      
    }
}