using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuiPuiCapaDeInterfazBackOffice.Vistas.VSalon
{
    public partial class DetalleConsultaSalon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String _id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            String _codigo = Convert.ToString((Request.QueryString["codigo"] != null) ? Request.QueryString["codigo"] : "");
            String _ubicacion = Convert.ToString((Request.QueryString["ubicacion"] != null) ? Request.QueryString["ubicacion"] : "");
            String _capacidad = Convert.ToString((Request.QueryString["capacidad"] != null) ? Request.QueryString["capacidad"] : "");
            String _status = Convert.ToString((Request.QueryString["status"] != null) ? Request.QueryString["status"] : "");
            TextBoxCapacidad.Text = _capacidad;
            TextBoxCodigo.Text = _codigo;
            TextBoxStatus.Text = _status;
            TextBoxUbicacion.Text = _ubicacion;
        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            String _id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            String _codigo = Convert.ToString((Request.QueryString["codigo"] != null) ? Request.QueryString["codigo"] : "");
            String _ubicacion = Convert.ToString((Request.QueryString["ubicacion"] != null) ? Request.QueryString["ubicacion"] : "");
            String _capacidad = Convert.ToString((Request.QueryString["capacidad"] != null) ? Request.QueryString["capacidad"] : "");
            String _status = Convert.ToString((Request.QueryString["status"] != null) ? Request.QueryString["status"] : "");
            Response.Redirect("DetalleConsultaClase.aspx?ubicacion=" + _ubicacion + "&status=" + _status + "&id=" + _id + "&capacidad=" + _capacidad + "&codigo=" + _codigo);
        }

        protected void Regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarSalon.aspx");
        }
    }
}