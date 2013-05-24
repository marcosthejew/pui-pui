using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using PuiPui_FrontOffice.LogicaDeNegocios.EvaluacionInstructor;
using PuiPui_FrontOffice.LogicaDeNegocios.Instructor;
using PuiPui_FrontOffice.Entidades.Instructor;

namespace PuiPui_FrontOffice.Presentacion.Vista.Modulo4.EvaluarInstructor
{
    public partial class Agregar : System.Web.UI.Page
    {

        LogicaEvaluacionInstructor _evaluacion = new LogicaEvaluacionInstructor();

        List<Instructor> _listaInstructores;

        protected void Page_Load(object sender, EventArgs e)
        {

            LogicaInstructor instructor = new LogicaInstructor();
            _listaInstructores = instructor.ConsultarTodosInstructores();

            if (!IsPostBack)
            {
                exito.Visible = false;
                falla.Visible = false;
                cargarInstructores();
            }

        }

        #region Llenar DropDownList Instructores
        protected void cargarInstructores()
        {

            LogicaInstructor instructores = new LogicaInstructor();
            Instructores.DataSource = _listaInstructores;
            Instructores.DataTextField = "NombreCompleto";
            Instructores.DataValueField = "IdPersona";
            Instructores.DataBind();

        }
        #endregion

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