﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.Entidades.Cliente;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;


namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_de_Clases
{
    public partial class ConsultaDetalle : System.Web.UI.Page
    {
        #region Atributos
        private String Desc;
        Persona persona;
        Acceso acceso;
        string loginPersona;
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                acceso = (Acceso)Session["loginPersona"];//recibo a través del SESSION el objeto "acceso" que esta compuesto por el login y el password de la persona que inicio sesión
                loginPersona = acceso.Login; //le asigno a la variable loginPersona el login de la persona que acaba de iniciar sesión, si nadie ha iniciado sesión esto se va al catch y te redirige al login, si la persona inicio sesión ya tengo su login y se quien es con esto puedo ir a la bd y ver que persona es para hacer las operaciones necesarias

                String id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
                String nombre = Convert.ToString((Request.QueryString["nombre"] != null) ? Request.QueryString["nombre"] : "");
                String estatus = Convert.ToString((Request.QueryString["estatus"] != null) ? Request.QueryString["estatus"] : "");

                LogicaClase objetoLogico = new LogicaClase();

                nombreClaseActual.Text = nombre;
                EstatusActual.Text = estatus;
                Desc = objetoLogico.ObtenerDetalleClases(Convert.ToInt32(id)).Descripcion;
                TextArea.Text = Desc;
            }
            catch (NullReferenceException) //si la persona no ha iniciado sesión y simplemente pegó el URL en el navegador va a caer en esta excepción
            {
                Response.Redirect("../../Home/Login.aspx"); //lo redirigimos al LOGIN para que a juro se tenga que autenticar
            }

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
            Response.Redirect("../../Modulo2/Gestion de Clases/Consultar.aspx");
        }
    }
}