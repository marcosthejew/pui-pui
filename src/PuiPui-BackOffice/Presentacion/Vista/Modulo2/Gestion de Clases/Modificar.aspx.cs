using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_de_Clases
{
    public partial class Modificar : System.Web.UI.Page
    {

        private LogicaClase _objLogica= new LogicaClase();
        private Clase _objetoClase;

        protected void Page_Load(object sender, EventArgs e)
        {
            String id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            String nombre = Convert.ToString((Request.QueryString["nombre"] != null) ? Request.QueryString["nombre"] : "");
            String estatus = Convert.ToString((Request.QueryString["estatus"] != null) ? Request.QueryString["estatus"] : "");
            String descripcion = Convert.ToString((Request.QueryString["Desc"] != null) ? Request.QueryString["Desc"] : "");
            _objetoClase = new Clase(Convert.ToInt32(id));

            if (!IsPostBack)
            {
               
                if (estatus.Equals("Activa"))
                {
                    Activo.Checked = true;
                }
                if (estatus.Equals("Inactiva"))
                {
                    Inactivo.Checked = true;
                }
                nombreClaseAModificar.Text = nombre;
                TextArea.Text = descripcion;
            }
        }

        protected void Activo_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void botonAceptar_Click(object sender, EventArgs e)
        {
            //nombreClaseAModificar.Text, TextArea.Text
            _objetoClase.Descripcion = TextArea.Text;
            _objetoClase.Nombre = nombreClaseAModificar.Text;
            if (Activo.Checked){
                _objetoClase.Status=1;    
	        }
            if (Inactivo.Checked){
		        _objetoClase.Status=0;    
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

        
    }
}