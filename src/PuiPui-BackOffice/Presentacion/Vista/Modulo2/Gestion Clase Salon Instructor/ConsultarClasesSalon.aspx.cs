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
using PuiPui_BackOffice.Entidades.Cliente; 

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_Clase_Salon_Instructor
{
    public partial class ConsultarClasesSalon : System.Web.UI.Page
    {
        #region Atributos
        List<ClaseSalon> _listaClase;
        LogicaSalon _accesoLogica=new LogicaSalon();
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
                _listaClase = _accesoLogica.SalonesClase();

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
                Response.Redirect("../../Home/Login.aspx"); 
            }
        }

        protected void GridConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void GridConsultar_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridConsultar.PageIndex = e.NewPageIndex;
            cargarTabla();
            
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
                String nombre_clase = Convert.ToString(row.Cells[2].Text);
                String ubicacion_salon = Convert.ToString(row.Cells[3].Text);
                String Nombre_instructor = Convert.ToString(row.Cells[4].Text);
                String Estatus = Convert.ToString(row.Cells[5].Text);
                Session["idClase"] = id;
                char[] charsToTrim = { '*', ' ', '\'', 'O', ':' };
                char[] charsToTrim1 = { '*', ' ', '\'', ':' };
                nombre_clase = nombre_clase.Trim(charsToTrim1);

                Response.Redirect("DetalleClaseSalonInstructor.aspx?nombre=" + nombre_clase + "&estatus=" + Estatus + "&id=" + id+"&ubicacion="+ubicacion_salon+"&instruct="+Nombre_instructor);

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