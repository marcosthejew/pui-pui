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
    public partial class EliminarEjercicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlEjercicios_Cargar();
                bEliminar.Enabled = false;
            }    
        }     
        protected void ddlEjercicios_Cargar()
        {
            LogicaEjercicio objetoLogica = new LogicaEjercicio();
            if (objetoLogica.ConsultarTodosEjercicios() != null)
            {
                ddlEjercicios.Items.Insert(0, new ListItem("Seleccione", "0"));
                List<Ejercicio> ejercicios = objetoLogica.ConsultarTodosEjercicios();
                int i = 1;
                foreach (Ejercicio ejercicio in ejercicios)
                {
                    ddlEjercicios.DataTextField = ejercicio.Nombre;
                    ddlEjercicios.DataValueField = ejercicio.Id.ToString();
                    ddlEjercicios.Items.Insert(i, ejercicio.Nombre);
                    i++;
                }
            }
            else
            {
                ddlEjercicios.Enabled = false;
                lExito.Visible = true;
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
                    tbNombre.Text = ejercicio.Nombre;
                    tbMusculo.Text = ejercicio.Musculo.NombreMusculo;
                    tbDescripcion.Text = ejercicio.Descripcion;
                    bEliminar.Enabled = true;
                }
                else
                {
                    tbInit();
                    bEliminar.Enabled = false;
                }

            }
            else
            {
                tbInit();
                bEliminar.Enabled = false;
            }

        }
        protected void tbInit()
        {
            tbNombre.Text = "";
            tbMusculo.Text = "";
            tbDescripcion.Text = "";
        }
        protected void bEliminar_Click(object sender, EventArgs e)
        {
            LogicaEjercicio objetoLogica = new LogicaEjercicio();
            if (objetoLogica.EliminarEjercicio(tbNombre.Text))
            {
                lExito.Text = "Se elimino satisfactoriamente.";
                lExito.ForeColor = System.Drawing.Color.Blue;
                lExito.Visible = true;

                tbInit();
                ddlEjercicios.Items.Clear();

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
                }
                else
                {
                    lExito.Text = "No hay ejercicios.";
                    lExito.ForeColor = System.Drawing.Color.Red;
                    ddlEjercicios.Enabled = false;
                    lExito.Visible = true;
                }
                
            }

        }
    }
}