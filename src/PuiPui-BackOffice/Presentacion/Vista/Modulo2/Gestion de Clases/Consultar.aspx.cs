﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using PuiPui_BackOffice.Entidades.Cliente; 
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_de_Clases
{
    public partial class Consultar : System.Web.UI.Page
    {
        #region Atributos
        private List<Clase> _listaClase;       
        private  LogicaClase _logicaClase= new LogicaClase();
        private int Estatus;
        private int seleccionCheck;
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

                _listaClase = _logicaClase.ObtenerClases();
                

                if (!IsPostBack)
                {
                    GridConsultar.Visible = false;
                    cargarTabla();
                }
                else
                {
                    GridConsultar.Visible = true;
                    // cargarTabla();
                }

            }
            catch (NullReferenceException) //si la persona no ha iniciado sesión y simplemente pegó el URL en el navegador va a caer en esta excepción
            {

                Response.Redirect("../../Home/Login.aspx"); //lo redirigimos al LOGIN para que a juro se tenga que autenticar
            }

            catch (Exception)
            {
                
               Response.Redirect("../../Vista/Modulo2/Gestion_de_Clases/Consultar.aspx");
            }
        }

        protected void GridConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
      /* int seleccion = GridConsultar.SelectedIndex;
           Clase clases = _listaClase[seleccion];
           Session["No"] = clases;
           Response.Redirect("DetalleConsultar.aspx");*/
        }

        protected void GridConsultar_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridConsultar.PageIndex = e.NewPageIndex;
            cargarTabla();
           /*  if ((consultaClasePorEstatus.Checked==false)&&(consultaClasePorNombres.Checked==false))
            {
                cargarTabla();
            }
             if (consultaClasePorNombres.Checked==true)
             {
                  GridConsultar.DataSource = _logicaClase.ConsultarClasesNombre(nombreClase.Text);
                    GridConsultar.DataBind();
             }
             if (consultaClasePorEstatus.Checked==true)
             {
                  GridConsultar.DataSource = _logicaClase.ConsultarClaseStatus(DropDownListEstatusClase.SelectedIndex);
                    GridConsultar.DataBind();
             }
             if (RadioButtonConsultaCompleta.Checked==true)
             {
                 cargarTabla();
             }*/
            switch (seleccionCheck)
            {
                case 1:

                    GridConsultar.DataSource = _logicaClase.ConsultarClase();
                    GridConsultar.DataBind();

                    break;

                case 2:
                    GridConsultar.DataSource = _logicaClase.ConsultarClasesNombre(nombreClase.Text);
                    GridConsultar.DataBind();

                    break;

                case 3:

                    GridConsultar.DataSource = _logicaClase.ConsultarClaseStatus(DropDownListEstatusClase.SelectedIndex);
                    GridConsultar.DataBind();

                    break;

               

            }
        }

        protected void GridConsultar_RowCommand(Object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Consultar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridConsultar.Rows[index];
                String id = Convert.ToString(row.Cells[1].Text);
                String nombre = Convert.ToString(row.Cells[2].Text);
                String estatus = Convert.ToString(row.Cells[3].Text);
                Session["idClase"] = id;
                char[] charsToTrim = { '*', ' ', '\'', 'O', ':' };
                char[] charsToTrim1 = { '*', ' ', '\'', ':' };    
                nombre = nombre.Trim(charsToTrim1);

                Response.Redirect("ConsultaDetalle.aspx?nombre=" + nombre + "&estatus=" + estatus + "&id=" + id);

            }

        }

        protected void botonBuscarClase_Click(object sender, EventArgs e)
        {
           
            switch (seleccionCheck)
            {
                case 1: 
                    
                GridConsultar.DataSource = _logicaClase.ConsultarClase();
                GridConsultar.DataBind();

                break;

                case 2:
                GridConsultar.DataSource = _logicaClase.ConsultarClasesNombre(nombreClase.Text);                
                GridConsultar.DataBind();

                break;

                case 3:
                if (DropDownListEstatusClase.SelectedItem.ToString().Equals("Activa"))
                {
                     Estatus = 1;
                }
                else 
                {
                     Estatus = 0;
                }
                
                GridConsultar.DataSource = _logicaClase.ConsultarClaseStatus(Estatus);                
                GridConsultar.DataBind();

                break;

            }
        }       

        protected void RadioButtonConsultaCompleta_CheckedChanged1(object sender, EventArgs e)
        {
            seleccionCheck = 1;
        }

        protected void consultaClasePorNombres_CheckedChanged(object sender, EventArgs e)
        {
            seleccionCheck = 2;
        }

        protected void consultaClasePorEstatus_CheckedChanged1(object sender, EventArgs e)
        {
            seleccionCheck = 3;
        }

        public void cargarTabla()
        {

            String stat = null;
            DataTable miTabla = new DataTable();
            miTabla.Columns.Add("No.", typeof(string));
            miTabla.Columns.Add("Nombre", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

            foreach (Clase clase in _listaClase)
            {
                if (clase.Status == 1)
                {
                    stat = "Activa";
                }
                else
                {
                    stat = "Inactiva";
                }
                miTabla.Rows.Add(clase.IdClase, clase.Nombre, stat);
            }
            GridConsultar.DataSource = miTabla;
            GridConsultar.DataBind();
        }

        protected void DropDownListEstatusClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            
         
        }
    }
}