using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.LogicaDeNegocios.Ejercicio;
using PuiPui_BackOffice.Entidades.Ejercicio;
using PuiPui_BackOffice.LogicaDeNegocios.Excepciones;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Ejercicios
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ddlMusculo_Cargar();

        }

        protected void ddlMusculo_Cargar()
        {
            ddlMusculo.Items.Clear();
            LogicaMusculo objetoLogica = new LogicaMusculo();
            try
            {
                if (objetoLogica.ConsultarTodosMusculos() != null)
                {
                    ddlMusculo.Items.Insert(0, new ListItem("Seleccione", "0"));
                    List<Musculo> musculos = objetoLogica.ConsultarTodosMusculos();
                    int i = 1;
                    foreach (Musculo musculo in musculos)
                    {
                        ddlMusculo.DataTextField = musculo.NombreMusculo;
                        ddlMusculo.DataValueField = musculo.IdMusculo.ToString();
                        ddlMusculo.Items.Insert(i, musculo.NombreMusculo);
                        i++;
                    }
                }
                else
                {
                    ddlMusculo.Enabled = false;
                    lExito.Visible = true;
                }
            }
            catch (MusculoException error)
            {
                lExito.Text = error.Message;
                lExito.ForeColor = System.Drawing.Color.Red;
                lExito.Visible = true;
            }

        }

        protected void bEliminar_Click(object sender, EventArgs e)
        {
            LogicaMusculo objetoLogica = new LogicaMusculo();
            try
            {
                if (objetoLogica.EliminarMusculo(ddlMusculo.SelectedValue))
                {
                    lExito.Text = "Se elimino satisfactoriamente el musculo.";
                    lExito.ForeColor = System.Drawing.Color.Blue;
                }
                else
                {
                    lExito.Text = "Hay ejercicios que usan del musculo.";
                    lExito.ForeColor = System.Drawing.Color.Red;
                }
                ddlMusculo_Cargar();
                lExito.Visible = true;
            }
            catch (MusculoException error)
            {
                lExito.Text = error.Message;
                lExito.ForeColor = System.Drawing.Color.Red;
                lExito.Visible = true;
            }
        }

    }
}