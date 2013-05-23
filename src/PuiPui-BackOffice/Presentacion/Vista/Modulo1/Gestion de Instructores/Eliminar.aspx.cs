using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.LogicaDeNegocios.Instructor;
using PuiPui_BackOffice.Entidades.Instructor;
using PuiPui_BackOffice.LogicaDeNegocios.Excepciones;
namespace PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Instructores
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ddl_Cargar();
        }

        protected void ddl_Cargar()
        {
            dp1.Items.Clear();
            LogicaInstructor objetoLogica = new LogicaInstructor();
            if (objetoLogica.ConsultarTodosInstructoresActivos() != null)
            {
                dp1.Items.Insert(0, new ListItem("Seleccione", "0"));
                List<Instructor> instructores = objetoLogica.ConsultarTodosInstructoresActivos();
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
            try
            {
                if (obj.EliminarInstructor(cedula[1]))
                {
                    lExito.Text = "El instructor ha sido inactivado";
                    lExito.ForeColor = System.Drawing.Color.Blue;
                    lExito.Visible = true;
                    ddl_Cargar();

                }
                else
                {
                    lExito.Visible = true;
                    lExito.ForeColor = System.Drawing.Color.Red;
                    lExito.Text = "El instructor tiene reservaciones pendientes.";
                }
            }
            catch (InstructorException error)
            {
                lExito.Text = error.Message;
                lExito.ForeColor = System.Drawing.Color.Red;
                lExito.Visible = true;
            }
        }
    }
}