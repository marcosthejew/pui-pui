using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_FrontOffice.LogicaDeNegocios.EvaluacionInstructor;

namespace PuiPui_FrontOffice.Presentacion.Vista.Modulo4.EvaluarInstructor
{
    public partial class Agregar : System.Web.UI.Page
    {

        LogicaEvaluacionInstructor _evaluacion = new LogicaEvaluacionInstructor();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                exito.Visible = false;
                falla.Visible = false;
                cargarInstructores();
            }

        }

        protected void cargarInstructores()
        {
            Instructores.Items.Add("Seleccione un Instructor");
            Instructores.Items.Add("Instructor1 Prueba");
            Instructores.Items.Add("Instructor2 Prueba");
            Instructores.Items.Add("Instructor2 Prueba");
            Instructores.DataBind();

        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            if (_evaluacion.AgregarEvaluacion(_evaluacion.ObtenerEvaluacion(DateTime.Now, Convert.ToInt32(CalificacionDropDown.SelectedValue), 0, Convert.ToInt32(Instructores.SelectedIndex))))
            {
                Instructores.SelectedIndex = 0;
                CalificacionDropDown.SelectedIndex = 0;
                exito.Visible = true;
            }
        }

    }
}