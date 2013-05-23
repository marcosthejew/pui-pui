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
    public partial class Consultar : System.Web.UI.Page
    {

        List<EEvaluacionInstructor> _listaEvaluacion;

        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {
            LogicaEvaluacionInstructor evaluacion = new LogicaEvaluacionInstructor();
            _listaEvaluacion = evaluacion.ConsultarEvaluacion();

            if (!IsPostBack)
            {
                llenarGridViewEvaluaciones();
            }

        }
        #endregion

        #region Llenar GridView Evaluaciones
        protected void llenarGridViewEvaluaciones()
        {

            LogicaEvaluacionInstructor evaluaciones = new LogicaEvaluacionInstructor();
            EvaluacionesTodasGrid.DataSource = evaluaciones.ConsultarEvaluacion();
            EvaluacionesTodasGrid.DataBind();

        }
        #endregion

        protected void EvaluacionesTodasGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = EvaluacionesTodasGrid.SelectedIndex;
            EEvaluacionInstructor _evaluacion = _listaEvaluacion[seleccion];
            Session["idEvaluacion"] = _evaluacion;

            Response.Redirect("Modificar.aspx");
        }

        protected void EvaluacionesTodasGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            EvaluacionesTodasGrid.PageIndex = e.NewPageIndex;
            llenarGridViewEvaluaciones();
        }

    }
}