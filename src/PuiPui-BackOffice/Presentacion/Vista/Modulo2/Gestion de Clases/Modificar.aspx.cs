using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.Entidades.Cliente;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_de_Clases
{
    public partial class Modificar : System.Web.UI.Page
    {
        #region Atributos
        Persona persona;
        Acceso acceso;
        string loginPersona;
        private LogicaClase _objLogica = new LogicaClase();
        private Clase _objetoClase;
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            String id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            String nombre = Convert.ToString((Request.QueryString["nombre"] != null) ? Request.QueryString["nombre"] : "");
            String estatus = Convert.ToString((Request.QueryString["estatus"] != null) ? Request.QueryString["estatus"] : "");
            String descripcion = Convert.ToString((Request.QueryString["Desc"] != null) ? Request.QueryString["Desc"] : "");
            _objetoClase = new Clase(Convert.ToInt32(id));

            try
            {
                if (!IsPostBack)
                {
                    acceso = (Acceso)Session["loginPersona"];//recibo a través del SESSION el objeto "acceso" que esta compuesto por el login y el password de la persona que inicio sesión
                    loginPersona = acceso.Login; //le asigno a la variable loginPersona el login de la persona que acaba de iniciar sesión, si nadie ha iniciado sesión esto se va al catch y te redirige al login, si la persona inicio sesión ya tengo su login y se quien es con esto puedo ir a la bd y ver que persona es para hacer las operaciones necesarias

                    nombreClaseAModificar.Text = nombre;
                    TextArea.Text = descripcion;

                    if (estatus.Equals("Activa"))
                    {
                        Activo.Checked = true;
                    }
                    if (estatus.Equals("Inactiva"))
                    {
                        Inactivo.Checked = true;
                    }
                }

            }
            catch (NullReferenceException) //si la persona no ha iniciado sesión y simplemente pegó el URL en el navegador va a caer en esta excepción
            {

                Response.Redirect("../../Home/Login.aspx"); //lo redirigimos al LOGIN para que a juro se tenga que autenticar
            }
        }

        protected void Activo_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void botonAceptar_Click(object sender, EventArgs e)
        {
            _objetoClase.Descripcion = TextArea.Text;
            _objetoClase.Nombre = nombreClaseAModificar.Text;

            if (Activo.Checked)
            {
                _objetoClase.Status = 1;
            }
            if (Inactivo.Checked)
            {
                _objetoClase.Status = 0;
            }

            bool resultado = _objLogica.ModificarClase(_objetoClase);


            if (resultado != false)
            {
                Exito.Visible = true;

            }
            else
            {
                falla.Visible = true;
            }
        }

        protected void botonRegresar_Click(object sender, EventArgs e)
        {
           Response.Redirect("../../Modulo2/Gestion de Clases/Consultar.aspx");
        }


    }
}