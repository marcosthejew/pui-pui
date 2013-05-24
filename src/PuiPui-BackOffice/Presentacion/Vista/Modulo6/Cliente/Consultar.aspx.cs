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
        Acceso acceso;
        string loginPersona;
        List<Persona> listaPersona;
        LogicaPersona miListaPersona = new LogicaPersona();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                acceso = (Acceso)Session["loginPersona"];
                loginPersona = acceso.Login;
                listaPersona = miListaPersona.ConsultarPersona();

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
                    GridConsultar.Visible = true;

            }
            catch (NullReferenceException)
            {

                Response.Redirect("../../Home/Login.aspx");
            }
        
        }

        #region Buscar por Cedula o Nombre
        protected void buscarCiCargoButton_Click(object sender, EventArgs e)
        {
            if (cedulaRadioButton.Checked && !CiConsTextBox.Text.Equals(""))
            {
                LogicaPersona logicaPersona = new LogicaPersona();
                GridConsultar.DataSource = logicaPersona.ConsultarPorCedula(CiConsTextBox.Text.TrimEnd());
                GridConsultar.DataBind();
            }
            if (cargoRadioButton.Checked && !NombreTextBox.Text.Equals(""))
            {
                LogicaPersona logicaPersona = new LogicaPersona();
                if (!NombreTextBox.Text.ToString().Contains("Elija un Cargo"))
                {
                    GridConsultar.DataSource = logicaPersona.ConsultarPorNombre(NombreTextBox.Text.TrimEnd());
                    GridConsultar.DataBind();
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
            table.Columns.Add("cedulaPersona", typeof(string));
            table.Columns.Add("nombrePersona1", typeof(string));
            table.Columns.Add("apellidoPersona1", typeof(string));
            table.Columns.Add("fechaIngresoPersona", typeof(string));

            foreach (Persona persona in listaPersona)
            {
                table.Rows.Add(persona.IdPersona,persona.CedulaPersona, persona.NombrePersona1,
                persona.ApellidoPersona1, persona.FechaIngresoPersona.ToString("dd-MM-yyyy"));
            }

            GridConsultar.DataSource = table;
            GridConsultar.DataBind();
        }
    }
}