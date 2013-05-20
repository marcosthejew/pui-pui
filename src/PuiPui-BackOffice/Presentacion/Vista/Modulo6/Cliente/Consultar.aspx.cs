using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using PuiPui_BackOffice.Entidades.Cliente;
using PuiPui_BackOffice.PruebasUnitarias.Cliente;
using PuiPui_BackOffice.LogicaDeNegocios.Cliente;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo6.Cliente
{
    public partial class Consultar : System.Web.UI.Page
    {

        List<Persona> listaPersona;
        LogicaPersona miListaPersona = new LogicaPersona();

        protected void Page_Load(object sender, EventArgs e)
        {
            listaPersona = miListaPersona.ConsultarPersona();

            if (!IsPostBack)
            {
                cargarTabla();
            }
            else
                //Exito.Visible = false;
                GridConsultar.Visible = true;
        }

        protected void GridConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = GridConsultar.SelectedIndex;
            Persona persona = listaPersona[seleccion];
            Session["idPersona"] = persona;
            Response.Redirect("ConsultarDetalle.aspx");
        }

        protected void GridConsultar_RowCommand(Object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridConsultar_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridConsultar.PageIndex = e.NewPageIndex;
            cargarTabla();
        }

        public void cargarTabla()
        {

            DataTable table = new DataTable();
            table.Columns.Add("idPersona", typeof(string));
            table.Columns.Add("PrimerNombre", typeof(string));
            table.Columns.Add("PrimerApellido", typeof(string));
            table.Columns.Add("FechaRegistro", typeof(string));

            foreach (Persona persona in listaPersona)
            {
                table.Rows.Add(persona.IdPersona, persona.NombrePersona1,
                persona.ApellidoPersona1, persona.FechaIngresoPersona.ToString("dd-MM-yyyy"));
            }

            GridConsultar.DataSource = table;
            GridConsultar.DataBind();
        }
    }
}