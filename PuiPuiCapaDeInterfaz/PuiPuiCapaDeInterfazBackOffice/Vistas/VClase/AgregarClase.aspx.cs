﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTClase;
using PuiPuiCapaDeInterfazBackOffice.Presentadores.PClase;

namespace PuiPuiCapaDeInterfazBackOffice.Vistas.VClase
{
    public partial class AgregarClase : System.Web.UI.Page,IContratoAgregarClase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public String TxtnombreClaseNueva { 

            get{return nombreNuevaClase.Text;}
            set { nombreNuevaClase.Text = value;}
        
        }
        public String TxtDescripcionClaseNueva {

            get { return descripcioNuevaClase.Text; }
            set { descripcioNuevaClase.Text = value; }
        
        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {
            if ((nombreNuevaClase.Text.Equals("")) || (descripcioNuevaClase.Text.Equals("")))
            {
                NClase.Enabled = true;
            }
            else
            {
                PAgregarClase agregar = new PAgregarClase(this);
                bool Inserto = agregar.InsertarClase();
                if (Inserto == true)
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

        }



    }
}