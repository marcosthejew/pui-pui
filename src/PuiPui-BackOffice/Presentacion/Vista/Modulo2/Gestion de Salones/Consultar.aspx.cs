using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using PuiPui_BackOffice.Entidades.Cliente;
using PuiPui_BackOffice.Entidades.Salon;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Geestion_de_Salones
{
    public partial class Consultar : System.Web.UI.Page
    {
        #region Atributos

        private List<Salon> _listaSalon;
        private String _ubicacion;
        private int _capacidad;
        private int _status;
        private LogicaSalon _logicaSalon;
        private int _checkSeleccion;
        Acceso acceso;
        string loginPersona;

        #endregion

        #region Metodos

        public Consultar() 
        {

            this._logicaSalon = new LogicaSalon();
        
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                acceso = (Acceso)Session["loginPersona"];//recibo a través del SESSION el objeto "acceso" que esta compuesto por el login y el password de la persona que inicio sesión
                loginPersona = acceso.Login; //le asigno a la variable loginPersona el login de la persona que acaba de iniciar sesión, si nadie ha iniciado sesión esto se va al catch y te redirige al login, si la persona inicio sesión ya tengo su login y se quien es con esto puedo ir a la bd y ver que persona es para hacer las operaciones necesarias

                _listaSalon = _logicaSalon.ObtenerSalones();

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
                Response.Redirect("../../Home/Login.aspx"); //lo redirigimos al LOGIN para que a juro se tenga que autenticar
            }
            catch (Exception)
            {
                Response.Redirect("../../Modulo2/Gestion de Salones/Consultar.aspx");
            }
        }

        protected void GridConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridConsultar_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {            
            GridConsultar.PageIndex = e.NewPageIndex;
            cargarTabla();

            switch (_checkSeleccion)
            {                
                case 1:

                    GridConsultar.DataSource = _logicaSalon.ConsultarSalones();
                    GridConsultar.DataBind();
                    break;

                case 2:

                    this._ubicacion = salon.Text;
                    GridConsultar.DataSource = _logicaSalon.ConsultarSalonesUbicacion(_ubicacion);
                    GridConsultar.DataBind();
                    break;

                case 3:

                    GridConsultar.DataSource = _logicaSalon.ConsultarSalonesStatus(DropDownListStatusSalon.SelectedIndex);
                    GridConsultar.DataBind();
                    break;

                case 4:

                    this._capacidad = Convert.ToInt32(TextBoxCapacidad.Text);

                    if (DropDownListCapacidadSalon.SelectedItem.ToString().Equals("Mayor a"))
                    {
                        //_statusCapacidad = 1;
                        GridConsultar.DataSource = _logicaSalon.ConsultarSalonesCapacidadMayo(_capacidad);
                    }
                    else
                    {
                        //_statusCapacidad = 0;
                        GridConsultar.DataSource = _logicaSalon.ConsultarSalonesCapacidadMenor(_capacidad);
                    }
                    GridConsultar.DataBind();
                    //if {}
                    /*else {}
                    GridConsultar.DataSource = _logicaSalon.*/
                    break;
            }
        }

        protected void GridConsultar_RowCommand(Object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Consultar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridConsultar.Rows[index];
                String _id = Convert.ToString(row.Cells[1].Text);
                String _ubicacion = Convert.ToString(row.Cells[2].Text);
                String _capacidad = Convert.ToString(row.Cells[3].Text);
                String _status = Convert.ToString(row.Cells[4].Text);
                Session["_idSalon"] = _id;
                char[] charsToTrim = { '*', ' ', '\'', 'O', ':' };
                char[] charsToTrim1 = { '*', ' ', '\'', ':' };
                _ubicacion = _ubicacion.Trim(charsToTrim1);
                Response.Redirect("VerDetalle.aspx?ubicacion=" + _ubicacion + "&status=" + _status + "&id=" + _id + "&capacidad=" + _capacidad);

            }

        }
        
        protected void botonBuscarSalon_Click(object sender, EventArgs e)
        {
            switch (_checkSeleccion)
            {
                case 1:

                    GridConsultar.DataSource = _logicaSalon.ConsultarSalones();
                    GridConsultar.DataBind();
                    break;

                case 2:
                    
                    this._ubicacion = salon.Text;
                    GridConsultar.DataSource = _logicaSalon.ConsultarSalonesUbicacion(_ubicacion);
                    GridConsultar.DataBind();
                    break;

                case 3:

                    if (DropDownListStatusSalon.SelectedItem.ToString().Equals("Activo"))
                    {
                        _status = 1;
                    }
                    else
                    {
                        _status = 0;
                    }
                    GridConsultar.DataSource = _logicaSalon.ConsultarSalonesStatus(_status);                
                    GridConsultar.DataBind();
                    break;

                case 4:

                    this._capacidad = Convert.ToInt32(TextBoxCapacidad.Text);
                    if (DropDownListCapacidadSalon.SelectedItem.ToString().Equals("Mayor a"))
                    {
                        //_statusCapacidad = 1;
                        GridConsultar.DataSource = _logicaSalon.ConsultarSalonesCapacidadMayo(_capacidad);
                    }
                    else
                    {
                        //_statusCapacidad = 0;
                        GridConsultar.DataSource = _logicaSalon.ConsultarSalonesCapacidadMenor(_capacidad);
                    }
                    GridConsultar.DataBind();
                    break;
            }
        }

        protected void consultaCompleta_CheckedChanged1(object sender, EventArgs e)
        {
            _checkSeleccion = 1;
        }
        
        protected void consultarSalonPorUbicacion_CheckedChanged(object sender, EventArgs e)
        {
            _checkSeleccion = 2;
        }

        protected void consultaSalonPorStatus_CheckedChanged(object sender, EventArgs e)
        {
            _checkSeleccion = 3;
        }

        protected void consultaCapacidad_CheckedChanged1(object sender, EventArgs e)
        {
            _checkSeleccion = 4;
        }

        public void cargarTabla()
        {

            String _status = null;
            DataTable _miTabla = new DataTable();
            _miTabla.Columns.Add("No.", typeof(string));
            _miTabla.Columns.Add("Ubicacion", typeof(string));
            _miTabla.Columns.Add("Capacidad", typeof(string));
            _miTabla.Columns.Add("Estatus", typeof(string));

            foreach (Salon salon in _listaSalon)
            {
                if (salon.Status == 1)
                {
                    _status = "Activo";
                }
                else
                {
                    _status = "Inactivo";
                }
                _miTabla.Rows.Add(salon.IdSalon, salon.Ubicacion, salon.Capacidad, _status);
            }
            GridConsultar.DataSource = _miTabla;
            GridConsultar.DataBind();
        }

        #endregion Metodos

    }
}