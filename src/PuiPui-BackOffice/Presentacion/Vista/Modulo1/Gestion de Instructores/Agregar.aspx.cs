using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.LogicaDeNegocios.Instructor;
using System.Drawing;
using PuiPui_BackOffice.Entidades;


namespace PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Instructores
{
    public partial class Agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //dp1.Enabled=false;
            DateTime hora = new DateTime(2013, 11, 10, 6, 0, 0);
            if (!IsPostBack)
            {
                for (int i = 0; i <= 36; i++)
                {
                    hora = hora.AddMinutes(30);            

                    string a = hora.ToShortTimeString();
                    dp1.Items.Insert(i,a);
                    dp2.Items.Insert(i,a);
                    dp5.Items.Insert(i,a);
                    dp6.Items.Insert(i,a);
                    dp9.Items.Insert(i,a);
                    dp10.Items.Insert(i,a);
                    dp13.Items.Insert(i,a);
                    dp14.Items.Insert(i,a);
                    dp17.Items.Insert(i,a);
                    dp18.Items.Insert(i,a);
                    dp1.Enabled= false;
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


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "" || tb2.Text == "" || tb3.Text == "" || tb4.Text == "" || tb5.Text == "" || tb6.Text == "" || tb7.Text == "" || tb7.Text == "" || tb8.Text == "" || tb9.Text == "" || tb10.Text == "" || tb11.Text == "" || tb12.Text == "")
            {
                // Mostrar que los campos estan vacios.
                lexito.Text = "Los campos no pueden estar vacios.";
                lexito.Visible = true;
                
            }

            else
            {
                // Valido contra base de datos 
                LogicaInstructor linstructor = new LogicaInstructor();
                if (cb1.Checked == true || cb2.Checked == true || cb2.Checked == false || cb1.Checked == false)
                {

                    try
                    {
                        int.Parse(tb4.Text);
                        int.Parse(tb8.Text);
                        int.Parse(tb12.Text);



                        
                        if (cb1.Checked == true && cb2.Checked == false)
                        {
                            char cb0 = 'M';
                            if (linstructor.AgregarInstructor(tb1.Text, tb2.Text, tb3.Text, int.Parse(tb4.Text), tb5.Text, tb6.Text, tb7.Text, int.Parse(tb8.Text), tb9.Text, tb10.Text, tb11.Text, int.Parse(tb12.Text), Calendar.SelectedDate, cb0.ToString()))
                            {
                                lexito.Text = "Ya existe el instructor.";
                                lexito.Visible = true;
                            }
                            else
                            {
                                lexito.Text = "Se agrego exitosamente el instructor.";
                                lexito.Visible = true;

                            }
                        }

                        if (cb2.Checked == true && cb1.Checked == false)
                        {
                            char cb0 = 'F';
                            if (linstructor.AgregarInstructor(tb1.Text, tb2.Text, tb3.Text, int.Parse(tb4.Text), tb5.Text, tb6.Text, tb7.Text, int.Parse(tb8.Text), tb9.Text, tb10.Text, tb11.Text, int.Parse(tb12.Text), Calendar.SelectedDate, cb0.ToString()))
                            {
                                lexito.Text = "Ya existe el instructor.";
                                lexito.Visible = true;
                            }
                            else
                            {
                                lexito.Text = "Se agrego exitosamente el instructor.";
                                lexito.Visible = true;
                            }
                        }

                        if (cb2.Checked == true && cb1.Checked == true)
                        {

                            lexito.Visible = true;
                            lexito.Text = "Seleccion solo uno de los dos Sexos";
                            cb1.BorderColor = Color.Red;
                            cb2.BorderColor = Color.Red;

                        }

                        if (cb2.Checked == false && cb1.Checked == false)
                        {

                            lexito.Visible = true;
                            lexito.Text = "Seleccion Alguno de los dos Sexos";
                            cb1.BorderColor = Color.Red;
                            cb2.BorderColor = Color.Red;
                        }





                        if (cb6.Checked == true) 
                        {
                            Horario horario = new Horario();
                            horario.dia = "lunes";
                            horario.horaini = Convert.ToDateTime(dp1.Text);
                            horario.horafin = Convert.ToDateTime(dp2.Text);
                            LogicaHorario logica = new LogicaHorario();
                            logica.agregarHorario(horario, tb1.Text);
                        }

                        if (cb11.Checked == true)
                        {
                            Horario horario = new Horario();
                            horario.dia = "lunes";
                            horario.horaini = Convert.ToDateTime(dp3.Text);
                            horario.horafin = Convert.ToDateTime(dp4.Text);
                            LogicaHorario logica = new LogicaHorario();
                            logica.agregarHorario(horario, tb1.Text);
                        }

                        if (cb7.Checked == true)
                        {
                            Horario horario = new Horario();
                            horario.dia = "martes";
                            horario.horaini = Convert.ToDateTime(dp5.Text);
                            horario.horafin = Convert.ToDateTime(dp6.Text);
                            LogicaHorario logica = new LogicaHorario();
                            logica.agregarHorario(horario, tb1.Text);
                        }

                        if (cb12.Checked == true)
                        {
                            Horario horario = new Horario();
                            horario.dia = "martes";
                            horario.horaini = Convert.ToDateTime(dp7.Text);
                            horario.horafin = Convert.ToDateTime(dp8.Text);
                            LogicaHorario logica = new LogicaHorario();
                            logica.agregarHorario(horario, tb1.Text);
                        }

                        if (cb8.Checked == true)
                        {
                            Horario horario = new Horario();
                            horario.dia = "miercoles";
                            horario.horaini = Convert.ToDateTime(dp9.Text);
                            horario.horafin = Convert.ToDateTime(dp10.Text);
                            LogicaHorario logica = new LogicaHorario();
                            logica.agregarHorario(horario, tb1.Text);
                        }

                        if (cb13.Checked == true)
                        {
                            Horario horario = new Horario();
                            horario.dia = "miercoles";
                            horario.horaini = Convert.ToDateTime(dp11.Text);
                            horario.horafin = Convert.ToDateTime(dp12.Text);
                            LogicaHorario logica = new LogicaHorario();
                            logica.agregarHorario(horario, tb1.Text);
                        }

                        if (cb9.Checked == true)
                        {
                            Horario horario = new Horario();
                            horario.dia = "jueves";
                            horario.horaini = Convert.ToDateTime(dp13.Text);
                            horario.horafin = Convert.ToDateTime(dp14.Text);
                            LogicaHorario logica = new LogicaHorario();
                            logica.agregarHorario(horario, tb1.Text);
                        }

                        if (cb14.Checked == true)
                        {
                            Horario horario = new Horario();
                            horario.dia = "jueves";
                            horario.horaini = Convert.ToDateTime(dp15.Text);
                            horario.horafin = Convert.ToDateTime(dp16.Text);
                            LogicaHorario logica = new LogicaHorario();
                            logica.agregarHorario(horario, tb1.Text);
                        }

                        if (cb10.Checked == true)
                        {
                            Horario horario = new Horario();
                            horario.dia = "viernes";
                            horario.horaini = Convert.ToDateTime(dp17.Text);
                            horario.horafin = Convert.ToDateTime(dp18.Text);
                            LogicaHorario logica = new LogicaHorario();
                            logica.agregarHorario(horario, tb1.Text);
                        }
                        if (cb15.Checked == true)
                        {
                            Horario horario = new Horario();
                            horario.dia = "viernes";
                            horario.horaini = Convert.ToDateTime(dp19.Text);
                            horario.horafin = Convert.ToDateTime(dp20.Text);
                            LogicaHorario logica = new LogicaHorario();
                            logica.agregarHorario(horario, tb1.Text);
                        }

                    }


                    catch (Exception ex)
                    {
                        lexito.Visible = true;
                        lexito.Text = "Los Campos De Telefono deben ser estrictamente numericos";
                        tb4.BorderColor = Color.Red;
                        tb8.BorderColor = Color.Red;
                        tb12.BorderColor = Color.Red;
                    }



                }
            }
        }

        protected void cb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void tb4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tb8_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tb12_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList11_SelectedIndexChanged(object sender, EventArgs e)
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

        protected void DropDownList12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList19_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        protected void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            dp1.Enabled = true;
            dp2.Enabled = true;
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            dp5.Enabled = true;
            dp6.Enabled = true;
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            dp9.Enabled = true;
            dp10.Enabled = true;
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            dp13.Enabled = true;
            dp14.Enabled = true;
        }

        protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            dp17.Enabled = true;
            dp18.Enabled = true;
        }

        protected void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            dp3.Enabled = true;
            dp4.Enabled = true;
        }

        protected void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            dp7.Enabled = true;
            dp8.Enabled = true;
        }

        protected void CheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            dp11.Enabled = true;
            dp12.Enabled = true;
        }

        protected void CheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            dp15.Enabled = true;
            dp16.Enabled = true;
        }

        protected void CheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            dp19.Enabled = true;
            dp20.Enabled = true;
        }

        protected void dp7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        
    }
}