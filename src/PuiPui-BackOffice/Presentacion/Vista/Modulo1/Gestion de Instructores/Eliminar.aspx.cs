using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.LogicaDeNegocios.Instructor;
using PuiPui_BackOffice.Entidades.Instructor;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Instructores
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LogicaInstructor objetoLogica = new LogicaInstructor();
            if (objetoLogica.ConsultarTodosInstructores() != null)
            {
                dp1.Items.Insert(0, new ListItem("Seleccione", "0"));
                List<Instructor> instructores = objetoLogica.ConsultarTodosInstructores();
                int i = 1;
                foreach (Instructor instructor in instructores)
                {
                    dp1.Items.Insert(i, "CI: " + instructor.CedulaPersona.ToString() + " " + instructor.NombrePersona1 + " " + instructor.ApellidoPersona1);
                    i++;
                }
            }
            else
            {
                dp1.Enabled = false;
                lExito.Visible = true;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LogicaInstructor obj = new LogicaInstructor();
            string a=dp1.SelectedValue;
            string[] cedula=a.Split(' ');

            if (obj.eliminarInstructor(cedula[1]) == true)
            {
                lExito.Text = "El instructor ha sido cambiado a inactivo";
                lExito.Visible = true;
               
            }
            else
            {
                lExito.Visible = true;
                lExito.Text = "No se pudo Eliminar ";
            }
        }
    }
}