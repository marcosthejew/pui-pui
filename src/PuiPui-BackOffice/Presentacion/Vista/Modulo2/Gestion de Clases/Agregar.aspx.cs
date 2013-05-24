using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;
using PuiPui_BackOffice.Entidades.Cliente;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_de_Clases
{
    public partial class Agregar : System.Web.UI.Page
    {
        #region Atributos
        private LogicaClase _objLogica;
        Acceso acceso;
        string loginPersona;
        #endregion

        public Agregar()
        {
            this._objLogica = new LogicaClase();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
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

        protected void Aceptar_Click(object sender, EventArgs e)
        {
            bool resultado;
                        
            if ((nombreNuevaClase.Text.Equals(""))||(descripcioNuevaClase.Text.Equals("")))
            {
                NClase.Visible = true;
            }
            else
            {
                NClase.Visible = false;
                resultado = _objLogica.AgregarClase(nombreNuevaClase.Text, descripcioNuevaClase.Text);

                if (resultado != false)
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