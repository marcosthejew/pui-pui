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
    public partial class Consultar : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbCedula.Text = "";
                lbNombre1.Text = "";
                lbApellido1.Text = "";
                lbTlfLocal.Text = "";
                lbCiudad.Text = "";
                lbFechaNac.Text = "";
                lbFechaRes.Text = "";
                lbGenero.Text = "";
                lbNombre2.Text = "";
                lbApellido2.Text = "";
                lbTlfCel.Text = "";
                lbDireccion.Text = "";
                lbMail.Text = "";
                lbStatus.Text = "";
                lbNomContacto.Text = "";
                lbTLfContacto.Text = "";

                LogicaInstructor objetoLogica = new LogicaInstructor();
                if (objetoLogica.ConsultarTodosInstructores() != null)
                {
                    ddlInstructores.Items.Insert(0, new ListItem("Seleccione", "0"));
                    List<Instructor> instructores = objetoLogica.ConsultarTodosInstructores();
                    int i = 1;
                    foreach (Instructor instructor in instructores)
                    {
                        ddlInstructores.Items.Insert(i,  "CI: " + instructor.CedulaPersona.ToString()+" "+instructor.NombrePersona1 + " " + instructor.ApellidoPersona1);
                        i++;
                    }
                }
                else
                {
                    ddlInstructores.Enabled = false;
                    lExito.Visible = true;
                }
            }

        }



        protected void ddlInstructores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlInstructores.SelectedIndex > 0)
            {

                string[] words = ddlInstructores.SelectedValue.Split(' ');
                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }


                LogicaInstructor objetoLogica = new LogicaInstructor();
                Instructor instructor = objetoLogica.ConsultarInstructor(words[1]);
                if (instructor != null)
                {
                     lbCedula.Text = instructor.CedulaPersona.ToString();
                     lbNombre1.Text = instructor.NombrePersona1;
                     lbApellido1.Text = instructor.ApellidoPersona1;
                     lbTlfLocal.Text = "0"+instructor.TelefonoLocalPersona;
                     lbCiudad.Text = instructor.CiudadPersona;

                     string[] fechaNAC = Convert.ToString(instructor.FechaNacimientoPersona).Split(' ');
                     foreach (string fechaN in fechaNAC)
                     {
                         Console.WriteLine(fechaN);
                     }

                     lbFechaNac.Text = fechaNAC[0];

                     string[] fechaRES = Convert.ToString(instructor.FechaIngresoPersona).Split(' ');
                     foreach (string fechaR in fechaRES)
                     {
                         Console.WriteLine(fechaR);
                     }
                     
                     lbFechaRes.Text = fechaRES[0];

                     lbGenero.Text = instructor.GeneroPersona;
                     lbNombre2.Text = instructor.NombrePersona2;
                     lbApellido2.Text = instructor.ApellidoPersona2;
                     lbTlfCel.Text = "0" + instructor.TelefonoCelularPersona;
                     lbDireccion.Text = instructor.DireccionPersona;
                     lbMail.Text = instructor.CorreoPersona;
                     lbStatus.Text = instructor.EstadoPersona;
                     lbNomContacto.Text = instructor.ContactoNombrePersona;
                     lbTLfContacto.Text = "0" + instructor.ContactoTelefonoPersona;
           

                   
                }
                else
                {
                     lbCedula.Text ="";
                     lbNombre1.Text = "";
                     lbApellido1.Text = "";
                     lbTlfLocal.Text = "";
                     lbCiudad.Text = "";
                     lbFechaNac.Text = "";
                     lbFechaRes.Text = "";
                     lbGenero.Text = "";
                     lbNombre2.Text = "";
                     lbApellido2.Text = "";
                     lbTlfCel.Text = "";
                     lbDireccion.Text = "";
                     lbMail.Text = "";
                     lbStatus.Text = "";
                     lbNomContacto.Text = "";
                     lbTLfContacto.Text = "";

                }

            }
            else
            {
                lbCedula.Text = "";
                lbNombre1.Text = "";
                lbApellido1.Text = "";
                lbTlfLocal.Text = "";
                lbCiudad.Text = "";
                lbFechaNac.Text = "";
                lbFechaRes.Text = "";
                lbGenero.Text = "";
                lbNombre2.Text = "";
                lbApellido2.Text = "";
                lbTlfCel.Text = "";
                lbDireccion.Text = "";
                lbMail.Text = "";
                lbStatus.Text = "";
                lbNomContacto.Text = "";
                lbTLfContacto.Text = "";
            }
        }





    }
}