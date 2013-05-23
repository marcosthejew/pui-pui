using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.Entidades.Salon;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Geestion_de_Salones
{
    public partial class Modificar : System.Web.UI.Page
    {
        private LogicaSalon  _objetoLogica = new LogicaSalon();
        private Salon _objetoSalon;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            String _id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            String _ubicacion = Convert.ToString((Request.QueryString["ubicacion"] != null) ? Request.QueryString["ubicacion"] : "");
            String _capacidad = Convert.ToString((Request.QueryString["capacidad"] != null) ? Request.QueryString["capacidad"] : "");
            String _status = Convert.ToString((Request.QueryString["status"] != null) ? Request.QueryString["status"] : "");

            _objetoSalon = new Salon(Convert.ToInt32(_id));

            if (!IsPostBack)
            {

                if (_status.Equals("Activo"))
                {
                    Activo.Checked = true;
                }
                if (_status.Equals("Inactivo"))
                {
                    Inactivo.Checked = true;
                }
                TextBoxUbicacion.Text = _ubicacion;
                TextBoxCapacidad.Text = _capacidad;

            }

        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Presentacion/Vista/Modulo2/Geestion%20de%20Salones/Consultar.aspx");
        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {
            //nombreClaseAModificar.Text, TextArea.Text
            _objetoSalon.Ubicacion = TextBoxUbicacion.Text;
            _objetoSalon.Capacidad = Convert.ToInt32(TextBoxCapacidad.Text);
            if (Activo.Checked)
            {
                _objetoSalon.Status = 1;
            }
            if (Inactivo.Checked)
            {
                _objetoSalon.Status = 0;
            }

            bool _resultado = _objetoLogica.ModificarSalones(_objetoSalon);

            if (_resultado != false)
            {
                Exito.Visible = true;
            }
            else
            {
                falla.Visible = true;
            }
        }
    }
}