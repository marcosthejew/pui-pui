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
    public partial class Modificar : System.Web.UI.Page
    {

        List<Persona> listaPersona;
        LogicaPersona miHistoriaClinica = new LogicaPersona();

        protected void Page_Load(object sender, EventArgs e)
        {
            listaPersona = miHistoriaClinica.ConsultarPersona();

            if (!IsPostBack)
            {
                cargarTabla();
            }
            else
                //Exito.Visible = false;
                GridModificar.Visible = true;
        }

        protected void GridModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = GridModificar.SelectedIndex;
            Persona persona = listaPersona[seleccion];
            Session["idPersona"] = persona;
            Response.Redirect("Modificar1.aspx");
        }

        protected void GridModificar_RowCommand(Object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridModificar_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridModificar.PageIndex = e.NewPageIndex;
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

            GridModificar.DataSource = table;
            GridModificar.DataBind();
        }
    }
}