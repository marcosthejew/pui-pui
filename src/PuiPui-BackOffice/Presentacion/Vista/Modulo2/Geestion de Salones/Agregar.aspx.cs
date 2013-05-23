using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon;
using PuiPui_BackOffice.Entidades.Cliente;
using PuiPui_BackOffice.LogicaDeNegocios.Excepciones;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Geestion_de_Salones
{
    public partial class Agregar : System.Web.UI.Page
    {
        #region Atributos

        private LogicaSalon _objetoLogica;
        Persona persona;
        Acceso acceso;
        string loginPersona;

        #endregion Atributos

        #region Constructor

        public Agregar() 
        { 
            this._objetoLogica = new LogicaSalon();
        }

        #endregion Constructor

        #region Metodos

        protected void Page_Load(object sender, EventArgs e)
        {         
            try
            {
                acceso = (Acceso)Session["loginPersona"];
                loginPersona = acceso.Login;

            }
            catch (NullReferenceException)
            {

                Response.Redirect("../../Home/Login.aspx");
            }
        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {
            if (TextBoxUbicacion.Text.Equals(""))
            {
                falla.Visible = true;
            }
            else 
            {
                if (TextBoxCapacidad.Text.Equals(""))
                {
                    falla.Visible = true;
                }
                else 
                {
                    bool _resultado = _objetoLogica.AgregarSalones(TextBoxUbicacion.Text, Convert.ToInt32(TextBoxCapacidad.Text));
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

        protected void Cancelar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("../../Home/Home.aspx");
        }
        
        #endregion Metodos
    }
}