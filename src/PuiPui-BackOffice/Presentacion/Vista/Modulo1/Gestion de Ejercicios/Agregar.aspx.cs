using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.LogicaDeNegocios.Ejercicio;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Ejercicios
{
    public partial class Agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "")
            {
                // Mostrar que los campos estan vacios.
                lExito.Text = "Los campos no pueden estar vacios.";
                lExito.Visible = true;
            }
            else
            {
                // Valido contra base de datos 
                LogicaMusculo lMusculo = new LogicaMusculo();
                if (lMusculo.AgregarMusculo(tbNombre.Text))
                {
                    lExito.Text = "Ya existe el musculo.";
                    lExito.Visible = true;
                }
                else
                {
                    lExito.Text = "Se agrego exitosamente el musculo.";
                    lExito.Visible = true;
                }

            }
           
        }
    }
}