using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_FrontOffice.LogicaDeNegocios.EvaluacionInstructor;
using PuiPui_FrontOffice.Entidades.EEvaluacionInstructor;
using PuiPui_FrontOffice.Entidades.Cliente;
using PuiPui_FrontOffice.LogicaDeNegocios.Cliente;

namespace PuiPui_FrontOffice.Presentacion.Vista.Modulo4.EvaluarInstructor
{
    public partial class Consultar : System.Web.UI.Page
    {

        Persona persona;
        LogicaPersona cliente;
        Acceso acceso;
        string loginPersona;

        List<EEvaluacionInstructor> _listaEvaluacion;

        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                acceso = (Acceso)Session["loginPersona"];//recibo a través del SESSION el objeto "acceso" que esta compuesto por el login y el password de la persona que inicio sesión
                loginPersona = acceso.Login; //le asigno a la variable loginPersona el login de la persona que acaba de iniciar sesión, si nadie ha iniciado sesión esto se va al catch y te redirige al login, si la persona inicio sesión ya tengo su login y se quien es con esto puedo ir a la bd y ver que persona es para hacer las operaciones necesarias


            LogicaEvaluacionInstructor evaluacion = new LogicaEvaluacionInstructor();
            _listaEvaluacion = evaluacion.ConsultarEvaluacion();

            if (!IsPostBack)
            {
                llenarGridViewEvaluaciones();

                persona = cliente.ConsultarPersonaPorLogin(acceso.Login);
                //persona.LoginPersona = acceso.Login;
            }

            }
            catch (NullReferenceException) //si la persona no ha iniciado sesión y simplemente pegó el URL en el navegador va a caer en esta excepción
            {

                Response.Redirect("../../Home/Login.aspx"); //lo redirigimos al LOGIN para que a juro se tenga que autenticar
            }

        }
        #endregion

        #region Llenar GridView Evaluaciones
        protected void llenarGridViewEvaluaciones()
        {

            LogicaEvaluacionInstructor evaluaciones = new LogicaEvaluacionInstructor();
            EvaluacionesTodasGrid.DataSource = evaluaciones.ConsultarEvaluacion(persona);
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