using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.LogicaDeNegocios.Instructor;
using PuiPui_BackOffice.Entidades.Instructor;
using PuiPui_BackOffice.Entidades;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Instructores
{
    public partial class Modificar : System.Web.UI.Page
    {



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl_Cargar();
                LogicaInstructor objetoLogica = new LogicaInstructor();
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
                    lexito.Visible = true;
                }

               
            }
        }






        protected void ddl_Cargar()
        {
            DateTime hora = new DateTime(2013, 11, 10, 6, 0, 0);
            for (int i = 0; i <= 36; i++)
            {
                hora = hora.AddMinutes(30);

                string a = hora.ToShortTimeString();
                dp1.Items.Insert(i, a);
                dp2.Items.Insert(i, a);
                dp5.Items.Insert(i, a);
                dp6.Items.Insert(i, a);
                dp9.Items.Insert(i, a);
                dp10.Items.Insert(i, a);
                dp13.Items.Insert(i, a);
                dp14.Items.Insert(i, a);
                dp17.Items.Insert(i, a);
                dp18.Items.Insert(i, a);
                dp1.Enabled = false;
                dp2.Enabled = false;
                dp3.Enabled = false;
                dp4.Enabled = false;
                dp5.Enabled = false;
                dp6.Enabled = false;
                dp7.Enabled = false;
                dp8.Enabled = false;
                dp9.Enabled = false;
                dp10.Enabled = false;
                dp11.Enabled = false;
                dp12.Enabled = false;
                dp13.Enabled = false;
                dp14.Enabled = false;
                dp15.Enabled = false;
                dp16.Enabled = false;
                dp17.Enabled = false;
                dp18.Enabled = false;
                dp19.Enabled = false;
                dp20.Enabled = false;

            }

        }










        protected void ddlInstructores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlInstructores.SelectedIndex > 0)
            {
                string[] words = ddlInstructores.SelectedValue.Split(' ');

                LogicaInstructor objetoLogica = new LogicaInstructor();
                Instructor instructor = objetoLogica.ConsultarInstructor(words[1]);
                
                if (instructor != null)
                {
                    CIinicio.Text = instructor.CedulaPersona.ToString();
                    estadoini.Text= instructor.EstadoPersona.ToString();

                    cedula.Text = instructor.CedulaPersona.ToString();
                    nombre1.Text = instructor.NombrePersona1;
                    apellido1.Text = instructor.ApellidoPersona1;
                    tlflocal.Text = "0" + instructor.TelefonoLocalPersona;
                    ciudad.Text = instructor.CiudadPersona;
                    string[] fechaNAC = Convert.ToString(instructor.FechaNacimientoPersona).Split(' ');
                    fechanac.Text = fechaNAC[0];                    
                    genero.Text = instructor.GeneroPersona;
                    nombre2.Text = instructor.NombrePersona2;
                    apellido2.Text = instructor.ApellidoPersona2;
                    tlfcel.Text = "0" + instructor.TelefonoCelularPersona;
                    direccion.Text = instructor.DireccionPersona;
                    mail.Text = instructor.CorreoPersona;
                    estado.Text = instructor.EstadoPersona;
                    contacto.Text = instructor.ContactoNombrePersona;
                    tlfcontacto.Text = "0" + instructor.ContactoTelefonoPersona;

                    if (instructor.Horario != null)
                    {
                        List<Horario> horarios = instructor.Horario;
                        int turno = 1;
                        foreach (Horario horario in horarios)
                        {
                            if (horario.dia.TrimEnd() == "lunes")
                            {
                                if (turno == 1)
                                {
                                    lunes1.Text = horario.horaini.ToShortTimeString();
                                    lunes2.Text = horario.horafin.ToShortTimeString();                                    
                                    turno++;
                                }
                                else
                                {
                                    lunes3.Text = horario.horaini.ToShortTimeString();
                                    lunes4.Text = horario.horafin.ToShortTimeString();  
                                }
                            }
                        }
                        turno = 1;
                        foreach (Horario horario in horarios)
                        {
                            if (horario.dia.TrimEnd() == "martes")
                            {
                                if (turno == 1)
                                {
                                    martes1.Text = horario.horaini.ToShortTimeString();
                                    martes2.Text = horario.horafin.ToShortTimeString();
                                    turno++;
                                }
                                else
                                {
                                    martes3.Text = horario.horaini.ToShortTimeString();
                                    martes4.Text = horario.horafin.ToShortTimeString();  
                                }
                            }
                        }
                        turno = 1;
                        foreach (Horario horario in horarios)
                        {
                            if (horario.dia.TrimEnd() == "miercoles")
                            {
                                if (turno == 1)
                                {
                                    miercoles1.Text = horario.horaini.ToShortTimeString();
                                    miercoles2.Text = horario.horafin.ToShortTimeString();
                                    turno++;
                                }
                                else
                                {
                                    miercoles3.Text = horario.horaini.ToShortTimeString();
                                    miercoles4.Text = horario.horafin.ToShortTimeString();  
                                }
                            }
                        }
                        turno = 1;
                        foreach (Horario horario in horarios)
                        {
                            if (horario.dia.TrimEnd() == "jueves")
                            {
                                if (turno == 1)
                                {
                                    jueves1.Text = horario.horaini.ToShortTimeString();
                                    jueves2.Text = horario.horafin.ToShortTimeString();
                                    turno++;
                                }
                                else
                                {
                                    jueves3.Text = horario.horaini.ToShortTimeString();
                                    jueves4.Text = horario.horafin.ToShortTimeString();  
                                }
                            }
                        }
                        turno = 1;
                        foreach (Horario horario in horarios)
                        {
                            if (horario.dia.TrimEnd() == "viernes")
                            {
                                if (turno == 1)
                                {
                                    viernes1.Text = horario.horaini.ToShortTimeString();
                                    viernes2.Text = horario.horafin.ToShortTimeString();
                                    turno++;
                                }
                                else
                                {
                                    viernes3.Text = horario.horaini.ToShortTimeString();
                                    viernes4.Text = horario.horafin.ToShortTimeString();  
                                }
                            }
                        }
                    }
                }

            }
        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor();

            instructor.CedulaPersona = Convert.ToInt32(cedula.Text);
            instructor.NombrePersona1 = nombre1.Text;
            instructor.NombrePersona2 = nombre2.Text;
            instructor.ApellidoPersona1 = apellido1.Text;
            instructor.ApellidoPersona2 = apellido2.Text;
            instructor.GeneroPersona = genero.Text;
            instructor.FechaNacimientoPersona = DateTime.Parse(fechanac.Text);
            instructor.CiudadPersona = ciudad.Text;
            instructor.DireccionPersona = direccion.Text;
            instructor.TelefonoLocalPersona = tlflocal.Text;
            instructor.TelefonoCelularPersona = tlfcel.Text;
            instructor.CorreoPersona = mail.Text;
            instructor.ContactoNombrePersona = contacto.Text;
            instructor.ContactoTelefonoPersona = tlfcontacto.Text;
            instructor.EstadoPersona = estado.Text;
            

            if (cb6.Checked == true)
            {
                Horario horario = new Horario();
                horario.dia = "lunes";
                horario.horaini = Convert.ToDateTime(dp1.Text);
                horario.horafin = Convert.ToDateTime(dp2.Text);
                LogicaHorario logica = new LogicaHorario();
                logica.ActualizarHorario(horario, CIinicio.Text);
            }

            if (cb11.Checked == true)
            {
                Horario horario = new Horario();
                horario.dia = "lunes";
                horario.horaini = Convert.ToDateTime(dp3.Text);
                horario.horafin = Convert.ToDateTime(dp4.Text);
                LogicaHorario logica = new LogicaHorario();
                logica.ActualizarHorario(horario, CIinicio.Text);
            }

            if (cb7.Checked == true)
            {
                Horario horario = new Horario();
                horario.dia = "martes";
                horario.horaini = Convert.ToDateTime(dp5.Text);
                horario.horafin = Convert.ToDateTime(dp6.Text);
                LogicaHorario logica = new LogicaHorario();
                logica.ActualizarHorario(horario, CIinicio.Text);
            }

            if (cb12.Checked == true)
            {
                Horario horario = new Horario();
                horario.dia = "martes";
                horario.horaini = Convert.ToDateTime(dp7.Text);
                horario.horafin = Convert.ToDateTime(dp8.Text);
                LogicaHorario logica = new LogicaHorario();
                logica.ActualizarHorario(horario, CIinicio.Text);
            }

            if (cb8.Checked == true)
            {
                Horario horario = new Horario();
                horario.dia = "miercoles";
                horario.horaini = Convert.ToDateTime(dp9.Text);
                horario.horafin = Convert.ToDateTime(dp10.Text);
                LogicaHorario logica = new LogicaHorario();
                logica.ActualizarHorario(horario, CIinicio.Text);
            }

            if (cb13.Checked == true)
            {
                Horario horario = new Horario();
                horario.dia = "miercoles";
                horario.horaini = Convert.ToDateTime(dp11.Text);
                horario.horafin = Convert.ToDateTime(dp12.Text);
                LogicaHorario logica = new LogicaHorario();
                logica.ActualizarHorario(horario, CIinicio.Text);
            }

            if (cb9.Checked == true)
            {
                Horario horario = new Horario();
                horario.dia = "jueves";
                horario.horaini = Convert.ToDateTime(dp13.Text);
                horario.horafin = Convert.ToDateTime(dp14.Text);
                LogicaHorario logica = new LogicaHorario();
                logica.ActualizarHorario(horario, CIinicio.Text);
            }

            if (cb14.Checked == true)
            {
                Horario horario = new Horario();
                horario.dia = "jueves";
                horario.horaini = Convert.ToDateTime(dp15.Text);
                horario.horafin = Convert.ToDateTime(dp16.Text);
                LogicaHorario logica = new LogicaHorario();
                logica.ActualizarHorario(horario, CIinicio.Text);
            }

            if (cb10.Checked == true)
            {
                Horario horario = new Horario();
                horario.dia = "viernes";
                horario.horaini = Convert.ToDateTime(dp17.Text);
                horario.horafin = Convert.ToDateTime(dp18.Text);
                LogicaHorario logica = new LogicaHorario();
                logica.ActualizarHorario(horario, CIinicio.Text);
            }
            if (cb15.Checked == true)
            {
                Horario horario = new Horario();
                horario.dia = "viernes";
                horario.horaini = Convert.ToDateTime(dp19.Text);
                horario.horafin = Convert.ToDateTime(dp20.Text);
                LogicaHorario logica = new LogicaHorario();
                logica.ActualizarHorario(horario, CIinicio.Text);
            }

            

            LogicaInstructor objetoLogica = new LogicaInstructor();
            if (objetoLogica.ActualizarInstructor(instructor, CIinicio.Text))
            {
                lexito.Text = "Se ha modificado exitosamente.";
                lexito.ForeColor = System.Drawing.Color.Blue;
                lexito.Visible = true;
            }
            else
            {
                lexito.Text = "No se pudo modificar el instructor, los campos no estan conrrectos.";
                lexito.ForeColor = System.Drawing.Color.Red;
                lexito.Visible = true;

            }            
        }





        protected void masculino_CheckedChanged(object sender, EventArgs e)
        {
            genero.Text = "m";
            femenino.Checked = false; 
        }
        
        protected void femenino_CheckedChanged(object sender, EventArgs e)
        {
            genero.Text = "f";
            masculino.Checked = false; 
        }
        


        protected void activar_CheckedChanged(object sender, EventArgs e)
        {
            estado.Text = "activo";
            inactivar.Checked = false;
        }

        protected void inactivar_CheckedChanged(object sender, EventArgs e)
        {
            estado.Text = estadoini.Text;
            activar.Checked = false; 
        }



        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            fechanac.Text = Calendar.SelectedDate.ToShortDateString();
        }


        
        protected void cb6_CheckedChanged(object sender, EventArgs e)
        {
            dp1.Enabled = true;
            dp2.Enabled = true;
        }

        protected void cb7_CheckedChanged(object sender, EventArgs e)
        {
            dp5.Enabled = true;
            dp6.Enabled = true;
        }

        protected void cb8_CheckedChanged(object sender, EventArgs e)
        {
            dp9.Enabled = true;
            dp10.Enabled = true;
        }

        protected void cb9_CheckedChanged(object sender, EventArgs e)
        {
            dp13.Enabled = true;
            dp14.Enabled = true;
        }

        protected void cb10_CheckedChanged(object sender, EventArgs e)
        {
            dp17.Enabled = true;
            dp18.Enabled = true;
        }

        protected void cb11_CheckedChanged(object sender, EventArgs e)
        {
            dp3.Enabled = true;
            dp4.Enabled = true;
        }

        protected void cb12_CheckedChanged(object sender, EventArgs e)
        {
            dp7.Enabled = true;
            dp8.Enabled = true;
        }

        protected void cb13_CheckedChanged(object sender, EventArgs e)
        {
            dp11.Enabled = true;
            dp12.Enabled = true;
        }

        protected void cb14_CheckedChanged(object sender, EventArgs e)
        {
            dp15.Enabled = true;
            dp16.Enabled = true;
        }

        protected void cb15_CheckedChanged(object sender, EventArgs e)
        {
            dp19.Enabled = true;
            dp20.Enabled = true;
        }

        protected void dp18_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime hora;
            String hora2 = dp18.SelectedValue;
            hora = Convert.ToDateTime(hora2);

            DateTime horafin = new DateTime(2013, 11, 10, 23, 0, 0);
            dp19.Items.Clear();
            dp20.Items.Clear();

            while (hora.Hour < horafin.Hour)
            {

                hora = hora.AddMinutes(30);
                string a = hora.ToShortTimeString();
                dp19.Items.Add(a);
                dp20.Items.Add(a);

                dp19.Enabled = false;
                dp20.Enabled = false;
            }

        }

        protected void dp14_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                DateTime hora;
                String hora2 = dp14.SelectedValue;
                hora = Convert.ToDateTime(hora2);

                DateTime horafin = new DateTime(2013, 11, 10, 23, 0, 0);
                dp15.Items.Clear();
                dp16.Items.Clear();

                while (hora.Hour < horafin.Hour)
                {

                    hora = hora.AddMinutes(30);
                    string a = hora.ToShortTimeString();
                    dp15.Items.Add(a);
                    dp16.Items.Add(a);

                    dp15.Enabled = false;
                    dp16.Enabled = false;


                

            }

        }

        protected void dp10_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime hora;
            String hora2 = dp10.SelectedValue;
            hora = Convert.ToDateTime(hora2);

            DateTime horafin = new DateTime(2013, 11, 10, 23, 0, 0);
            dp11.Items.Clear();
            dp12.Items.Clear();

            while (hora.Hour < horafin.Hour)
            {

                hora = hora.AddMinutes(30);
                string a = hora.ToShortTimeString();
                dp11.Items.Add(a);
                dp12.Items.Add(a);
                dp11.Enabled = false;
                dp12.Enabled = false;

            }
        }

        protected void dp6_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime hora;
            String hora2 = dp6.SelectedValue;
            hora = Convert.ToDateTime(hora2);

            DateTime horafin = new DateTime(2013, 11, 10, 23, 0, 0);
            dp7.Items.Clear();
            dp8.Items.Clear();

            while (hora.Hour < horafin.Hour)
            {

                hora = hora.AddMinutes(30);
                string a = hora.ToShortTimeString();
                dp7.Items.Add(a);
                dp8.Items.Add(a);
                dp7.Enabled = false;
                dp8.Enabled = false;

            }
        }

        protected void dp2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime hora;
            String hora2 = dp2.SelectedValue;
            hora = Convert.ToDateTime(hora2);

            DateTime horafin = new DateTime(2013, 11, 10, 23, 0, 0);
            dp3.Items.Clear();

            while (hora.Hour < horafin.Hour)
            {

                hora = hora.AddMinutes(30);
                string a = hora.ToShortTimeString();
                dp3.Items.Add(a);
                dp4.Items.Add(a);
                dp3.Enabled = false;
                dp4.Enabled = false;

            }
        }


    }
}