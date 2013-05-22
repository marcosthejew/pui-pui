﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_de_Clases
{
    public partial class Consultar : System.Web.UI.Page
    { 
        private List<Clase> _listaClase;
        private String _nombreClase ;
        private int _estatusClase;
        private  LogicaClase _logicaClase;
        private int seleccionCheck;
       

        public Consultar()
        {
            
            //this._estatusClase = Int32.Parse(DropDownListEstatusClase.SelectedValue);
            this._logicaClase = new LogicaClase();
        }
   
        protected void Page_Load(object sender, EventArgs e)
        {
           
            try
            {
                _listaClase = _logicaClase.ObtenerClases();
                if (!IsPostBack)
                {
                    GridConsultar.Visible = false;
                    cargarTabla();
                }
                else
                {
                    GridConsultar.Visible = true;
                }
            }
            catch (NullReferenceException)
            {
                
               Response.Redirect("../../Home/Modulo2/Gestion_de_Clases/Consultar.aspx");
            }
           
            
        }

        protected void GridConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
        int seleccion = GridConsultar.SelectedIndex;
           Clase clases = _listaClase[seleccion];
           Session["No"] = clases;
           Response.Redirect("DetalleConsultar.aspx");
        }

        protected void GridConsultar_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridConsultar.PageIndex = e.NewPageIndex;
            cargarTabla();
                

                /*switch (seleccionCheck)
                {
                    case 1:

                        GridConsultar.DataSource = _logicaClase.ConsultarClase();
                        GridConsultar.DataBind();
                        break;

                    case 2:

                        this._nombreClase = nombreClase.Text;
                        GridConsultar.DataSource = _logicaClase.ConsultarClasesNombre(_nombreClase);
                        GridConsultar.DataBind();
                        break;
                }*/
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

                Response.Redirect("DetalleConsultar.aspx?nombre=" + nombre + "&estatus=" + estatus + "&id=" + id);

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
                this._nombreClase = nombreClase.Text;
                GridConsultar.DataSource = _logicaClase.ConsultarClasesNombre(_nombreClase);
                GridConsultar.DataBind();

                break;

                case 3:
                    
                GridConsultar.DataSource = _logicaClase.ConsultarClase();
                GridConsultar.DataBind();
                break;

            }


            


        }

        protected void consultaClasePorEstatus_CheckedChanged(object sender, EventArgs e)
        {
            seleccionCheck = 2;
        }

        protected void consultaClasePorNombres_CheckedChanged1(object sender, EventArgs e)
        {
            seleccionCheck = 3;

        }

        protected void RadioButtonConsultaCompleta_CheckedChanged(object sender, EventArgs e)
        {
            seleccionCheck = 1;
        }

        protected void RadioButtonConsultaCompleta_CheckedChanged1(object sender, EventArgs e)
        {
            seleccionCheck = 1;
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



    }
}