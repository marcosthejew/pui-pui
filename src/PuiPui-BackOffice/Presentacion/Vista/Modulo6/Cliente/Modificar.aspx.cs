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

                //Habilito si quiero buscar por ci o nombre, pero no ambos a la vez
                if (cedulaRadioButton.Checked == true)
                {
                    NombreTextBox.Enabled = false;
                    CiConsTextBox.Enabled = true;
                }
                if (cargoRadioButton.Checked == true)
                {
                    CiConsTextBox.Enabled = false;
                    NombreTextBox.Enabled = true;
                }
            }
            else
                //Exito.Visible = false;
                GridModificar.Visible = true;
        }

        #region Buscar por Cedula o Cargo
        protected void buscarCiCargoButton_Click(object sender, EventArgs e)
        {
            if (cedulaRadioButton.Checked && !CiConsTextBox.Text.Equals(""))
            {
                LogicaPersona logicaPersona = new LogicaPersona();
                GridModificar.DataSource = logicaPersona.ConsultarPorCedula(CiConsTextBox.Text);
                GridModificar.DataBind();
            }
            if (cargoRadioButton.Checked && !NombreTextBox.Text.Equals(""))
            {
                LogicaPersona logicaPersona = new LogicaPersona();
                if (!NombreTextBox.Text.ToString().Contains("Elija un Cargo"))
                {
                    GridModificar.DataSource = logicaPersona.ConsultarPorNombre(NombreTextBox.Text);
                    GridModificar.DataBind();
                }
                else
                    cargarTabla();
            }
        }
        #endregion Buscar por Cedula o Cargo

        protected void cedulaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!cedulaRadioButton.Checked)
            {
                CiConsTextBox.Enabled = false;
                NombreTextBox.Enabled = true;
                CiConsTextBox.Text = "";
            }
            else if (cedulaRadioButton.Checked)
            {
                CiConsTextBox.Enabled = true;
                NombreTextBox.Enabled = false;
            }
        }

        protected void cargoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cargoRadioButton.Checked)
            {
                NombreTextBox.Enabled = true;
                CiConsTextBox.Enabled = false;
                CiConsTextBox.Text = "";
            }
            else if (!cargoRadioButton.Checked)
            {
                NombreTextBox.Enabled = false;
                CiConsTextBox.Enabled = true;
                //prueba
            }
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
            table.Columns.Add("cedulaPersona", typeof(string));
            table.Columns.Add("nombrePersona1", typeof(string));
            table.Columns.Add("apellidoPersona1", typeof(string));
            table.Columns.Add("fechaIngresoPersona", typeof(string));

            foreach (Persona persona in listaPersona)
            {
                table.Rows.Add(persona.IdPersona, persona.CedulaPersona, persona.NombrePersona1,
               persona.ApellidoPersona1, persona.FechaIngresoPersona.ToString("dd-MM-yyyy"));
            }

            GridModificar.DataSource = table;
            GridModificar.DataBind();
        }
    }
}