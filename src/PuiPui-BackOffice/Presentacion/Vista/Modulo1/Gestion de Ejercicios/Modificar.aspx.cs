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
    
    public partial class Modificar : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlEjercicio_Cargar();
                tbInit();
                ddlMusculo_Cargar(false);
                bModificar.Enabled = false;
            }
        }

        protected void ddlEjercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlEjercicios.SelectedIndex > 0)
            {
                LogicaEjercicio objetoLogica = new LogicaEjercicio();

                Ejercicio ejercicio = objetoLogica.ConsultarEjercicio(ddlEjercicios.SelectedValue);
                if (ejercicio != null)
                {
                    hfEjercicio.Value = ejercicio.Nombre;
                    tbNombre.Text = ejercicio.Nombre;                    
                    tbDescripcion.Text = ejercicio.Descripcion;
                    ddlMusculo_Cargar(true);
                    ddlMusculo.SelectedValue = ejercicio.Musculo.NombreMusculo;
                    bModificar.Enabled = true;
                }
            }
            else
            {
                tbInit();
                ddlMusculo_Cargar(false);
                bModificar.Enabled = false;
            }

        }

        protected void tbInit()
        {
            tbNombre.Text = "";
            tbDescripcion.Text = "";
            lExito.Visible = false;
        }

        protected void ddlEjercicio_Cargar()
        {
            ddlEjercicios.Items.Clear();
            LogicaEjercicio objetoLogica = new LogicaEjercicio();
            if (objetoLogica.ConsultarTodosEjercicios() != null)
            {
                ddlEjercicios.Items.Insert(0, new ListItem("Seleccione", "0"));
                List<Ejercicio> ejercicios = objetoLogica.ConsultarTodosEjercicios();
                int i = 1;
                foreach (Ejercicio ejercicio in ejercicios)
                {
                    ddlEjercicios.Items.Insert(i, ejercicio.Nombre);
                    i++;
                }
                ddlEjercicios.Enabled = true;
            }
            else
            {
                lExito.Text = "No hay ejercicios.";
                lExito.Visible = true;
                lExito.ForeColor = System.Drawing.Color.Red;
                ddlEjercicios.Enabled = false;
            }

        }
        
        protected void ddlMusculo_Cargar(bool bEnabled)
        {
            ddlMusculo.Items.Clear();
            LogicaMusculo objetoLogica = new LogicaMusculo();
            if (objetoLogica.ConsultarTodosMusculos() != null)
            {
                List<Musculo> musculos = objetoLogica.ConsultarTodosMusculos();
                int i = 0;
                foreach (Musculo musculo in musculos)
                {
                    ddlMusculo.DataTextField = musculo.NombreMusculo;
                    ddlMusculo.DataValueField = musculo.IdMusculo.ToString();
                    ddlMusculo.Items.Insert(i, musculo.NombreMusculo);
                    i++;
                }
            }
            ddlMusculo.Enabled = bEnabled;
        }

        protected void bModificar_Click(object sender, EventArgs e)
        {
            if (ddlEjercicios.SelectedIndex > 0 && tbDescripcion.Text != "" && tbNombre.Text != "")
            {
                LogicaEjercicio objetoLogica = new LogicaEjercicio();
                Ejercicio ejercicio = new Ejercicio();
                ejercicio.Nombre = tbNombre.Text;
                ejercicio.Descripcion = tbDescripcion.Text;

                if (objetoLogica.ActualizarEjercicio(hfEjercicio.Value, ejercicio, ddlMusculo.SelectedValue))
                {
                    tbInit();
                    ddlEjercicio_Cargar();
                    ddlMusculo_Cargar(false);
                    lExito.Text = "Se ha modificado exitosamente.";
                    lExito.ForeColor = System.Drawing.Color.Blue;
                    lExito.Visible = true;
                }
            }
            else
            {
                lExito.Text = "No pueden haber campos vacios.";
                lExito.ForeColor = System.Drawing.Color.Red;
                lExito.Visible = true;
            }
        }
 
    }
}