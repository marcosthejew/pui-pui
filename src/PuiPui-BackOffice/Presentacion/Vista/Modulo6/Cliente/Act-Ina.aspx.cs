using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.Entidades.Cliente;
using PuiPui_BackOffice.PruebasUnitarias.Cliente;
using PuiPui_BackOffice.LogicaDeNegocios.Cliente;
using System.Data;


namespace PuiPui_BackOffice.Presentacion.Vista.Modulo6.Cliente
{
    public partial class Act_Ina : System.Web.UI.Page
    {

        List<Persona> listaPersona;
        LogicaPersona miPersona = new LogicaPersona();

        protected void Page_Load(object sender, EventArgs e)
        {
            listaPersona = miPersona.ConsultarActivarDesactivarPersona();

            if (!IsPostBack)
            {
                cargarTabla();
            }
            else
                //Exito.Visible = false;

                GridActivarDesactivar.Visible = true;
        }

        public void cargarTabla()
        {

            DataTable table = new DataTable();
            table.Columns.Add("idPersona", typeof(string));
            table.Columns.Add("PrimerNombre", typeof(string));
            table.Columns.Add("PrimerApellido", typeof(string));
            table.Columns.Add("estadoPersona", typeof(string));

            foreach (Persona persona in listaPersona)
            {
                table.Rows.Add(persona.IdPersona, persona.NombrePersona1,
                persona.ApellidoPersona1, persona.EstadoPersona);
            }

            GridActivarDesactivar.DataSource = table;
            GridActivarDesactivar.DataBind();
        }
        protected void GridActivarDesactivar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = GridActivarDesactivar.SelectedIndex;
            LogicaPersona lpersona = new LogicaPersona();
            Persona persona = listaPersona[seleccion];
            lpersona.CambiarEstado(persona);
            Response.Redirect("Act-Ina.aspx");
        }


        protected void GridActivarDesactivar_RowCommand(Object sender, GridViewCommandEventArgs e)
        {


        }

        protected void GridActivarDesactivar_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridActivarDesactivar.PageIndex = e.NewPageIndex;
            cargarTabla();

        }

    }
}