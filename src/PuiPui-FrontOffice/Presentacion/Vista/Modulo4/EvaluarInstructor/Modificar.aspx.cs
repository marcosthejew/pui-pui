using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_FrontOffice.LogicaDeNegocios.EvaluacionInstructor;
using PuiPui_FrontOffice.Entidades.EEvaluacionInstructor;

namespace PuiPui_FrontOffice.Presentacion.Vista.Modulo4.EvaluarInstructor
{
    public partial class Modificar : System.Web.UI.Page
    {

        LogicaEvaluacionInstructor _logicaEvaluacion = new LogicaEvaluacionInstructor();
        EEvaluacionInstructor _evaluacion = new EEvaluacionInstructor();


        protected void Page_Load(object sender, EventArgs e)
        {
            _evaluacion = (EEvaluacionInstructor)Session["idEvaluacion"];
            if (!IsPostBack)
            {
                exito.Visible = false;
                falla.Visible = false;
                string nombre = _evaluacion.Instructor.NombrePersona1 + " " + _evaluacion.Instructor.ApellidoPersona1;
                
                Instructores.Items.Insert(0,new ListItem(nombre,"Instructor"));
                Instructores.Enabled = false;

                CalificacionDropDown.SelectedValue = _evaluacion.Calificacion.ToString();
            }
        }

        protected void ButtonModificar_Click(object sender, EventArgs e)
        {
            _logicaEvaluacion.ModificarEvaluacion(_evaluacion);
        }

        protected void CalificacionDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            _evaluacion.Calificacion = Convert.ToInt32(CalificacionDropDown.SelectedValue);
        }
    }
}