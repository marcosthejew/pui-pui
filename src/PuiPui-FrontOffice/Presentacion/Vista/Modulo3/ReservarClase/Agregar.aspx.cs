using PuiPui_FrontOffice.Entidades.ClaseSalon;
//using PuiPui_FrontOffice.LogicaDeNegocios.EvaluacionClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuiPui_FrontOffice.Presentacion.Vista.Modulo3.ReservarClase
{
    public partial class Agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
  //          Panel1.Visible = false;
    //        EvaluacionClase evaluacionClase = new EvaluacionClase();
      //      List<ClaseSalon> listaClases =  evaluacionClase.consultarEvaluacionClases();

        //    foreach (ClaseSalon objetoC in listaClases)
          //  {
            //    DropDownListClases.Items.Add("Clase: "+objetoC.FkIdClase.Nombre + " del Instructor: " + objetoC.FkIdInstructor.NombrePersona1 + " " + objetoC.FkIdInstructor.ApellidoPersona1);
            //}
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DropDownListClases.Visible = false;
            ButtonEvaluar.Visible = false;
            Label1.Text = "Por favor llenar la plantilla de evaluacion";
            Panel1.Visible = true;

            
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int text1 = Convert.ToInt16(TextBox2.Text.ToString());
            int text2 = Convert.ToInt16(TextBox2.Text.ToString());
            int text3 = Convert.ToInt16(TextBox3.Text.ToString());
            int text4 = Convert.ToInt16(TextBox4.Text.ToString());
            int text5 = Convert.ToInt16(TextBox5.Text.ToString());

            int suma = (text1 + text2 + text3 + text4 + text5)/5;

            String obs = TextBox6.Text.ToString();

            Label1.Text = "Su evaluacion promedio fue de :" + suma.ToString() + "con las siguientes observaciones: " + obs;

        }
    }
}