using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon;
using PuiPui_BackOffice.Entidades.Cliente;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Geestion_de_Salones
{
    public partial class Eliminar : System.Web.UI.Page
    {
        Acceso acceso;
        string loginPersona;

        protected void Page_Load(object sender, EventArgs e)
        {
            String _id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            String _ubicacion = Convert.ToString((Request.QueryString["ubicacion"] != null) ? Request.QueryString["ubicacion"] : "");
            String _capacidad = Convert.ToString((Request.QueryString["capacidad"] != null) ? Request.QueryString["capacidad"] : "");
            String _status = Convert.ToString((Request.QueryString["status"] != null) ? Request.QueryString["status"] : "");
            LogicaSalon _objetoLogica = new LogicaSalon();
            TextBoxUbicacion.Text = _ubicacion;
            TextBoxCapacidad.Text = _capacidad;
            TextBoxStatus.Text = _status;

            try
            {
                acceso = (Acceso)Session["loginPersona"];//recibo a través del SESSION el objeto "acceso" que esta compuesto por el login y el password de la persona que inicio sesión
                loginPersona = acceso.Login; //le asigno a la variable loginPersona el login de la persona que acaba de iniciar sesión, si nadie ha iniciado sesión esto se va al catch y te redirige al login, si la persona inicio sesión ya tengo su login y se quien es con esto puedo ir a la bd y ver que persona es para hacer las operaciones necesarias
                               
            }
            catch (NullReferenceException) //si la persona no ha iniciado sesión y simplemente pegó el URL en el navegador va a caer en esta excepción
            {

                Response.Redirect("../../Home/Login.aspx"); //lo redirigimos al LOGIN para que a juro se tenga que autenticar
            }

        }

        protected void Regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Modulo2/Gestion de Salones/Consultar.aspx");
        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            String _id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            String _ubicacion = Convert.ToString((Request.QueryString["ubicacion"] != null) ? Request.QueryString["ubicacion"] : "");
            String _capacidad = Convert.ToString((Request.QueryString["capacidad"] != null) ? Request.QueryString["capacidad"] : "");
            String _status = Convert.ToString((Request.QueryString["status"] != null) ? Request.QueryString["status"] : "");

            Response.Redirect("Modificar.aspx?ubicacion=" + _ubicacion + "&status=" + _status + "&id=" + _id + "&capacidad=" + _capacidad);
            
        }
    }
}