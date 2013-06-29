using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuiPuiCapaDeInterfazBackOffice.Vistas.VClase
{
    public partial class DetalleConsultaClase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String _id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            String _clase = Convert.ToString((Request.QueryString["nombre"] != null) ? Request.QueryString["nombre"] : "");
            String _descripcion = Convert.ToString((Request.QueryString["descripcion"] != null) ? Request.QueryString["descripcion"] : "");
            String _status = Convert.ToString((Request.QueryString["status"] != null) ? Request.QueryString["status"] : "");
            nombreClaseActual.Text = _clase;
            TextArea.Text = _descripcion;
            EstatusActual.Text = _status;
            
     
        }

        protected void botonModificar_Click(object sender, EventArgs e)
        {
            String _id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            String _clase = Convert.ToString((Request.QueryString["nombre"] != null) ? Request.QueryString["nombre"] : "");
            String _descripcion = Convert.ToString((Request.QueryString["descripcion"] != null) ? Request.QueryString["descripcion"] : "");
            String _status = Convert.ToString((Request.QueryString["status"] != null) ? Request.QueryString["status"] : "");
            Response.Redirect("ModificarClase.aspx?nombre=" + _clase + "&status=" + _status + "&id=" + _id + "&descripcion=" + _descripcion);

        }

        protected void botonRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarClases.aspx");
        }
    }
}