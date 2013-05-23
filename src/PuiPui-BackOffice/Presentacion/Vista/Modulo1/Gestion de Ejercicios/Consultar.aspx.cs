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
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LogicaEjercicio objetoLogica = new LogicaEjercicio();
                try
                {
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
                catch (EjercicioException error)
                {
                    lExito.Text = error.Message;
                    lExito.ForeColor = System.Drawing.Color.Red;
                    lExito.Visible = true;
                }

            }
        }
        
        protected void tb_Init()
        {
            tbNombre.Text = "";
            tbMusculo.Text = "";
            tbDescripcion.Text = "";
        }

        protected void ddlEjercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlEjercicios.SelectedIndex > 0)
            {
                LogicaEjercicio objetoLogica = new LogicaEjercicio();
                try
                {
                    Ejercicio ejercicio = objetoLogica.ConsultarEjercicio(ddlEjercicios.SelectedValue);
                    if (ejercicio != null)
                    {
                        tbNombre.Text = ejercicio.Nombre;
                        tbMusculo.Text = ejercicio.Musculo.NombreMusculo;
                        tbDescripcion.Text = ejercicio.Descripcion;
                    }
                    else
                        tb_Init();
                }
                catch (EjercicioException error)
                {
                    lExito.Text = error.Message;
                    lExito.ForeColor = System.Drawing.Color.Red;
                    lExito.Visible = true;
                }
            }
            else
                tb_Init();

        }

    }
}