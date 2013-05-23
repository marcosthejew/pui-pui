using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.Entidades.Salon;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon;
using PuiPui_BackOffice.Entidades.Cliente;
using PuiPui_BackOffice.LogicaDeNegocios.Excepciones;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Geestion_de_Salones
{
    public partial class Modificar : System.Web.UI.Page
    {
        #region Atributos

        private LogicaSalon  _objetoLogica = new LogicaSalon();
        private Salon _objetoSalon;
        Persona persona;
        Acceso acceso;
        string loginPersona;

        #endregion

        #region Metodos

        protected void Page_Load(object sender, EventArgs e)
        {
            String _id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            String _ubicacion = Convert.ToString((Request.QueryString["ubicacion"] != null) ? Request.QueryString["ubicacion"] : "");
            String _capacidad = Convert.ToString((Request.QueryString["capacidad"] != null) ? Request.QueryString["capacidad"] : "");
            String _status = Convert.ToString((Request.QueryString["status"] != null) ? Request.QueryString["status"] : "");

            _objetoSalon = new Salon(Convert.ToInt32(_id));

            try
            {
                acceso = (Acceso)Session["loginPersona"];
                loginPersona = acceso.Login;

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
            catch (NullReferenceException)
            {

                Response.Redirect("../../Home/Login.aspx");
            }

        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Modulo2/Geestion de Salones/VerDetalle.aspx");
        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {
            //nombreClaseAModificar.Text, TextArea.Text
            if (TextBoxUbicacion.Text.Equals(""))
            {
                falla.Visible = true;
            }
            else 
            {
                _objetoSalon.Ubicacion = TextBoxUbicacion.Text;           
            }
            if (TextBoxCapacidad.Text.Equals(""))
            {
                falla.Visible = true;
            }
            else 
            {
                _objetoSalon.Capacidad = Convert.ToInt32(TextBoxCapacidad.Text);            
            }
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
        #endregion

        protected void TextBoxUbicacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}