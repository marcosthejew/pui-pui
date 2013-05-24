using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.Entidades.Salon;
using PuiPui_BackOffice.Entidades.Instructor;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon;
using PuiPui_BackOffice.LogicaDeNegocios.Instructor;
using PuiPui_BackOffice.Entidades.Cliente; 

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_Clase_Salon_Instructor
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        #region Atributos
        List<Clase> _listClase = new List<Clase>();
        List<Salon> _listSalon = new List<Salon>();
        List<Instructor> _listInstructor = new List<Instructor>();
        List<ClaseSalon> _listClaseSalon = new List<ClaseSalon>();
        LogicaClase _accesoClase = new LogicaClase();
        ClaseSalon objetoModificado = new ClaseSalon();
        LogicaSalon _accesosSalon = new LogicaSalon();
        LogicaInstructor _accesoInstructor = new LogicaInstructor();
        String id;
        String nombreClase;
        String estatus;
        String ubiSalon;
        String instruc;
        Acceso acceso;
        string loginPersona;
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

            id = Convert.ToString((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            nombreClase = Convert.ToString((Request.QueryString["nombre"] != null) ? Request.QueryString["nombre"] : "");
            estatus = Convert.ToString((Request.QueryString["estatus"] != null) ? Request.QueryString["estatus"] : "");
            ubiSalon = Convert.ToString((Request.QueryString["ubicacion"] != null) ? Request.QueryString["ubicacion"] : "");
            instruc = Convert.ToString((Request.QueryString["instruct"] != null) ? Request.QueryString["instruct"] : "");
            LlenarCombos();


            try
            {
                acceso = (Acceso)Session["loginPersona"];
                loginPersona = acceso.Login;

                if (!IsPostBack)
                {
                    etiqueta_instructorA.Text = instruc;
                    etiqueta_salonA.Text = ubiSalon;
                    etiqueta_clase.Text = nombreClase;
                    if (estatus.Equals("Activa"))
                    {
                        Activo.Checked = true;
                    }
                    else
                    {
                        Inactivo.Checked = true;
                    }
                }
            }
            catch (NullReferenceException) 
            {

                Response.Redirect("../../Home/Login.aspx");
            }     
            

        }
        private void LlenarCombos()
        {
            _listClase = _accesoClase.ObtenerClases();
            _listSalon = _accesosSalon.ObtenerSalones();
            _listInstructor = _accesoInstructor.ConsultarTodosInstructores();
            
            foreach (Clase clas in _listClase)
            {
                ComboClase.Items.Add(clas.Nombre);
            }
            foreach (Salon sal in _listSalon)
            {
                ComboSalon.Items.Add(sal.Ubicacion);
            }
            foreach (Instructor ins in _listInstructor)
            {
                ComboInstructor.Items.Add(ins.NombrePersona1 + " " + ins.ApellidoPersona1);
            }

        }

        protected void defaultButton_Click(object sender, EventArgs e)
        {
            objetoModificado.Id = Convert.ToInt32(id);
            objetoModificado.Salon.IdSalon = _listSalon[ComboSalon.SelectedIndex].IdSalon;
            objetoModificado.Clase.IdClase = _listClase[ComboClase.SelectedIndex].IdClase;
            objetoModificado.Instructor.IdPersona = _listInstructor[ComboInstructor.SelectedIndex].IdPersona;
            if (Activo.Checked==true)
            {
                objetoModificado.Disponibilidad = 1;
            }
            else if (Inactivo.Checked==true)
            {
                objetoModificado.Disponibilidad = 0;
            }
            bool flag=_accesosSalon.ModificarSalonesClase(objetoModificado);

            if (flag==true)
            {
                Exito.Visible = true;
            }
            else
            {
                falla.Visible = true;
            }
            
            }
            
            

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarClasesSalon.aspx");
        }

        protected void Activo_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Inactivo_CheckedChanged(object sender, EventArgs e)
        {
                
        }

        

    }
}