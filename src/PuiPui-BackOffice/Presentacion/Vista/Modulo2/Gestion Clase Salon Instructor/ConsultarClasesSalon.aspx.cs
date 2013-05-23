using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.Entidades.Salon;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_Clase_Salon_Instructor
{
    public partial class ConsultarClasesSalon : System.Web.UI.Page
    {
        List<ClaseSalon> _listaClase;
        LogicaSalon _accesoLogica=new LogicaSalon();
        private int Estatus;
        private int seleccionCheck;

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                _listaClase = _accesoLogica.SalonesClase();

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
            catch (NullReferenceException)
            {

                //Response.Redirect("../../Vista/Modulo2/Gestion_de_Clases/Consultar.aspx");
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

                    GridConsultar.DataSource = _accesoLogica.ConsultarSalonesClasePorClase(nombreClase.Text);
                    GridConsultar.DataBind();

                    break;

                case 2:
                    GridConsultar.DataSource = _accesoLogica.ConsultarSalonesClasePorUbicacion(nombreClase.Text);
                    GridConsultar.DataBind();

                    break;

                case 3:

                    GridConsultar.DataSource = _accesoLogica.ConsultarSalonesClasePorEstatus(DropDownListEstatusClase.SelectedIndex);
                    GridConsultar.DataBind();

                    break;

                case 4:
                    GridConsultar.DataSource = _accesoLogica.ConsultarSalonesClasePorInstructor(nombreClase.Text);
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

                    GridConsultar.DataSource = _accesoLogica.ConsultarSalonesClasePorClase(nombreClase.Text);
                    GridConsultar.DataBind();

                    break;

                case 2:
                    GridConsultar.DataSource = _accesoLogica.ConsultarSalonesClasePorUbicacion(nombreClase.Text);
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

                     GridConsultar.DataSource = _accesoLogica.ConsultarSalonesClasePorEstatus(Estatus);
                    GridConsultar.DataBind();
                    
                    break;

                case 4:
                     GridConsultar.DataSource = _accesoLogica.ConsultarSalonesClasePorInstructor(nombreClase.Text);
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
            _listaClase = _accesoLogica.SalonesClase();

            miTabla.Columns.Add("Id", typeof(string));
            miTabla.Columns.Add("Nombre Clase", typeof(string));
            miTabla.Columns.Add("Salon", typeof(string));
            miTabla.Columns.Add("Instructor", typeof(string));
            miTabla.Columns.Add("Estatus", typeof(string));

            foreach (ClaseSalon salon in _listaClase)
            {
                if (salon.Disponibilidad == 1)
                {
                    stat = "Activa";
                }
                else
                {
                    stat = "Inactiva";
                }
                miTabla.Rows.Add(salon.Id, salon.Clase.Nombre, salon.Salon.Ubicacion, salon.Instructor.NombrePersona1 + salon.Instructor.ApellidoPersona1, stat);
            }
            GridConsultar.DataSource = miTabla;
            GridConsultar.DataBind();
        }

        protected void DropDownListEstatusClase_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void consultaClasePorInstructor_CheckedChanged(object sender, EventArgs e)
        {
            seleccionCheck = 4;
        }
    }
}