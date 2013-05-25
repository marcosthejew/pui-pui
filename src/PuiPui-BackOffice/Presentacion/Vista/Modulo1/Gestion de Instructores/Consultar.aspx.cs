using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.LogicaDeNegocios.Instructor;
using PuiPui_BackOffice.Entidades.Instructor;
using PuiPui_BackOffice.Entidades;
using PuiPui_BackOffice.LogicaDeNegocios.Excepciones;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Instructores
{
    public partial class Consultar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Init();
                ddlInstructores_Cargar();
            }
        }


        protected void ddlInstructores_Cargar()
        {
            LogicaInstructor objetoLogica = new LogicaInstructor();
            ddlInstructores.Items.Clear();
            try
            {
                if (objetoLogica.ConsultarTodosInstructores() != null)
                {
                    ddlInstructores.Items.Insert(0, new ListItem("Seleccione", "0"));
                    List<Instructor> instructores = objetoLogica.ConsultarTodosInstructores();
                    int i = 1;
                    foreach (Instructor instructor in instructores)
                    {
                        ddlInstructores.Items.Insert(i, "CI: " + instructor.CedulaPersona.ToString() + " " + instructor.NombrePersona1 + " " + instructor.ApellidoPersona1);
                        i++;
                    }
                }
                else
                {
                    ddlInstructores.Enabled = false;
                    lExito.Visible = true;
                }
            }
            catch (InstructorException error)
            {
                lExito.Text = error.Message;
                lExito.ForeColor = System.Drawing.Color.Red;
                lExito.Visible = true;
                ddlInstructores.Enabled = false;
            }
        }




        protected void ddlInstructores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlInstructores.SelectedIndex > 0)
                {
                    label_Init();
                    string[] words = ddlInstructores.SelectedValue.Split(' ');
                    foreach (string word in words)
                    {
                        Console.WriteLine(word);
                    }
                    LogicaInstructor objetoLogica = new LogicaInstructor();
                    Instructor instructor = objetoLogica.ConsultarInstructor(words[1]);
                    Cargar_Instructor(instructor);
                }
                else
                    Init();
            }
            catch (HorarioException error)
            {
                lExito.Text = error.Message;
                lExito.ForeColor = System.Drawing.Color.Red;
                lExito.Visible = true;
            }
            catch (InstructorException error)
            {
                lExito.Text = error.Message;
                lExito.ForeColor = System.Drawing.Color.Red;
                lExito.Visible = true;
            }
        }




        protected void Init()
        {
            tb_Init();
            label_Init();
        }


        protected void tb_Init()
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
            label_Init();
        }


        protected void label_Init()
        {
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            Label5.Text = "";
            Label6.Text = "";
            Label7.Text = "";
            Label8.Text = "";
            Label9.Text = "";
            Label10.Text = "";
            Label11.Text = "";
            Label12.Text = "";
            Label13.Text = "";
            Label14.Text = "";
            Label15.Text = "";
        }


        protected void Cargar_Instructor(Instructor instructor)
        {
            if (instructor != null)
            {
                lbCedula.Text = instructor.CedulaPersona.ToString();
                lbNombre1.Text = instructor.NombrePersona1;
                lbApellido1.Text = instructor.ApellidoPersona1;
                lbTlfLocal.Text = "0" + instructor.TelefonoLocalPersona;
                lbCiudad.Text = instructor.CiudadPersona;

                string[] fechaNAC = Convert.ToString(instructor.FechaNacimientoPersona).Split(' ');
                lbFechaNac.Text = fechaNAC[0];

                string[] fechaRES = Convert.ToString(instructor.FechaIngresoPersona).Split(' ');
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

                Cargar_Horario(instructor);
            }
            else
                Init();
        }



        protected void Cargar_Horario(Instructor instructor)
        {
            if (instructor.Horario != null)
            {
                List<Horario> horarios = instructor.Horario;

                Cargar_Horario_lunes(horarios);
                Cargar_Horario_martes(horarios);
                Cargar_Horario_miercoles(horarios);
                Cargar_Horario_jueves(horarios);
                Cargar_Horario_viernes(horarios);
            }

        }



        public void Cargar_Horario_lunes(List<Horario> horarios)
        {
            int turno = 1;
            foreach (Horario horario in horarios)
            {
                if (horario.dia.TrimEnd() == "lunes")
                {
                    if (turno == 1)
                    {
                        Label1.Text = horario.dia;
                        Label2.Text = horario.horaini.ToShortTimeString() + " - " + horario.horafin.ToShortTimeString();
                        Label1.Visible = true;
                        Label2.Visible = true;
                        turno++;
                    }
                    else
                    {
                        Label3.Text = horario.horaini.ToShortTimeString() + " - " + horario.horafin.ToShortTimeString();
                        Label3.Visible = true;
                    }
                }
            }
        }

        public void Cargar_Horario_martes(List<Horario> horarios)
        {
            int turno = 1;
            foreach (Horario horario in horarios)
            {
                if (horario.dia.TrimEnd() == "martes")
                {
                    if (turno == 1)
                    {
                        Label4.Text = horario.dia;
                        Label5.Text = horario.horaini.ToShortTimeString() + " - " + horario.horafin.ToShortTimeString();
                        Label4.Visible = true;
                        Label5.Visible = true;
                        turno++;
                    }
                    else
                    {
                        Label6.Text = horario.horaini.ToShortTimeString() + " - " + horario.horafin.ToShortTimeString();
                        Label6.Visible = true;
                    }
                }
            }
        }

        public void Cargar_Horario_miercoles(List<Horario> horarios)
        {
            int turno = 1;
            foreach (Horario horario in horarios)
            {
                if (horario.dia.TrimEnd() == "miercoles")
                {
                    if (turno == 1)
                    {
                        Label7.Text = horario.dia;
                        Label8.Text = horario.horaini.ToShortTimeString() + " - " + horario.horafin.ToShortTimeString();
                        Label7.Visible = true;
                        Label8.Visible = true;
                        turno++;
                    }
                    else
                    {
                        Label9.Text = horario.horaini.ToShortTimeString() + " - " + horario.horafin.ToShortTimeString();
                        Label9.Visible = true;
                    }
                }
            }
        }

        public void Cargar_Horario_jueves(List<Horario> horarios)
        {
            int turno = 1;
            foreach (Horario horario in horarios)
            {
                if (horario.dia.TrimEnd() == "jueves")
                {
                    if (turno == 1)
                    {
                        Label10.Text = horario.dia;
                        Label11.Text = horario.horaini.ToShortTimeString() + " - " + horario.horafin.ToShortTimeString();
                        Label10.Visible = true;
                        Label11.Visible = true;
                        turno++;
                    }
                    else
                    {
                        Label12.Text = horario.horaini.ToShortTimeString() + " - " + horario.horafin.ToShortTimeString();
                        Label12.Visible = true;
                    }
                }
            }
        }

        public void Cargar_Horario_viernes(List<Horario> horarios)
        {
            int turno = 1;
            foreach (Horario horario in horarios)
            {
                if (horario.dia.TrimEnd() == "viernes")
                {
                    if (turno == 1)
                    {
                        Label13.Text = horario.dia;
                        Label14.Text = horario.horaini.ToShortTimeString() + " - " + horario.horafin.ToShortTimeString();
                        Label13.Visible = true;
                        Label14.Visible = true;
                        turno++;
                    }
                    else
                    {
                        Label5.Text = horario.horaini.ToShortTimeString() + " - " + horario.horafin.ToShortTimeString();
                        Label5.Visible = true;
                    }
                }
            }
        }



        

    }
}