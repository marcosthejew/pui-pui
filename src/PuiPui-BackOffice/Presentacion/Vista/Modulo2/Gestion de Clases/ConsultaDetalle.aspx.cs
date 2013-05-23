using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;


namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_de_Clases
{
    public partial class ConsultaDetalle : System.Web.UI.Page
    {
        private String Desc;

        protected void Page_Load(object sender, EventArgs e)
        {
            String id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            String nombre = Convert.ToString((Request.QueryString["nombre"] != null) ? Request.QueryString["nombre"] : "");
            String estatus = Convert.ToString((Request.QueryString["estatus"] != null) ? Request.QueryString["estatus"] : "");

            LogicaClase objetoLogico = new LogicaClase();

            nombreClaseActual.Text = nombre;
            EstatusActual.Text = estatus;
            Desc= objetoLogico.ObtenerDetalleClases(Convert.ToInt32(id)).Descripcion;
            TextArea.Text = Desc;
           
        }

        protected void botonAceptar_Click(object sender, EventArgs e)
        {
            String id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            String nombre = Convert.ToString((Request.QueryString["nombre"] != null) ? Request.QueryString["nombre"] : "");
            String estatus = Convert.ToString((Request.QueryString["estatus"] != null) ? Request.QueryString["estatus"] : "");
            
            Response.Redirect("Modificar.aspx?nombre=" + nombre + "&estatus=" + estatus + "&id=" + id + "&Desc=" + Desc);
        }

        protected void botonRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../GestiondeClases/Consultar.aspx");
        }
    }
}