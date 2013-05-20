using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.LogicaDeNegocios.Instructor;
using System.Drawing;


namespace PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Instructores
{
    public partial class Agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        
        
    }
}