using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.Entidades.Cliente;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Geestion_de_Salones
{
    public partial class Agregar : System.Web.UI.Page
    {
        private LogicaSalon _objetoLogica;
        Acceso acceso;
        string loginPersona;

        public Agregar() 
        { 
            this._objetoLogica = new LogicaSalon();
        
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                acceso = (Acceso)Session["loginPersona"];//recibo a través del SESSION el objeto "acceso" que esta compuesto por el login y el password de la persona que inicio sesión
                loginPersona = acceso.Login; //le asigno a la variable loginPersona el login de la persona que acaba de iniciar sesión, si nadie ha iniciado sesión esto se va al catch y te redirige al login, si la persona inicio sesión ya tengo su login y se quien es con esto puedo ir a la bd y ver que persona es para hacer las operaciones necesarias
                if (!IsPostBack)
                { Exito.Visible = false; }
                
            }
            catch (NullReferenceException) //si la persona no ha iniciado sesión y simplemente pegó el URL en el navegador va a caer en esta excepción
            {

                Response.Redirect("../../Home/Login.aspx"); //lo redirigimos al LOGIN para que a juro se tenga que autenticar
            }
        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {
            
            
            if ((TextBoxUbicacion.Text.Equals(""))||(TextBoxCapacidad.Text.Equals("")))
            {
                NClase.Visible = true;
            }
            else
            {
                bool _resultado = _objetoLogica.AgregarSalones(TextBoxUbicacion.Text, Convert.ToInt32(TextBoxCapacidad.Text));
                NClase.Visible = false;
           
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

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Home/Home.aspx");
        }
    }
}