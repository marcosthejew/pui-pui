using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.LogicaDeNegocios.Ejercicio;
using PuiPui_BackOffice.Entidades.Ejercicio;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Ejercicios
{
    public partial class AgregarEjercicio : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LogicaMusculo objetoLogica = new LogicaMusculo();
                if (objetoLogica.ConsultarTodosMusculos()!= null)
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
        }



        protected void bAgregar_Click(object sender, EventArgs e)
        {
            if ( ( Nombre.Text == "") || (taDescripcion.Text=="") || (ddlMusculo.SelectedIndex == 0)) 
            {
                // Mostrar que los campos estan vacios.
                lExito.Text = "Los campos no pueden estar vacios.";
                lExito.ForeColor = System.Drawing.Color.Red;
                lExito.Visible = true;    
            }
            else
            {
                // Valido contra base de datos 
                LogicaEjercicio lEjercicio = new LogicaEjercicio();
                if (lEjercicio.AgregarEjercicio(Nombre.Text, taDescripcion.Text, ddlMusculo.SelectedIndex))
                {
                    lExito.Text = "Ya existe el ejercicio.";
                    lExito.ForeColor = System.Drawing.Color.Red;
                    lExito.Visible = true;
                }
                else
                {
                    lExito.Text = "Se agrego exitosamente el ejercicio.";
                    lExito.ForeColor = System.Drawing.Color.Blue;
                    lExito.Visible = true;
                    Nombre.Text = "";
                    taDescripcion.Text = "";
                    ddlMusculo.ClearSelection();
                }

            }
   

        }
    }
}