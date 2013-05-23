using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Geestion_de_Salones
{
    public partial class Eliminar : System.Web.UI.Page
    {
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

        }

        protected void Regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Home/Modulo2/Geestion_de_Salones/Consultar.aspx");
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