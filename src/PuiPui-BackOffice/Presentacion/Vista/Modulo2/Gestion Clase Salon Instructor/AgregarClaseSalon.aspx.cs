using System;
using System.Collections.Generic;
using PuiPui_BackOffice.Entidades.Clase;
using PuiPui_BackOffice.Entidades.Salon;
using PuiPui_BackOffice.Entidades.Instructor;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaClase;
using PuiPui_BackOffice.LogicaDeNegocios.LogicaSalon;
using PuiPui_BackOffice.LogicaDeNegocios.Instructor;
using PuiPui_BackOffice.Entidades.Cliente; 

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_Clase_Salon_Instructor
{
    public partial class AgregarClaseSalon : System.Web.UI.Page
    {
        #region Atributos
        List<Clase> _listClase = new List<Clase>();
        List<Salon> _listSalon = new List<Salon>();
        List<Instructor> _listInstructor = new List<Instructor>();
        List<ClaseSalon> _listClaseSalon = new List<ClaseSalon>();
        LogicaClase _accesoClase = new LogicaClase();
        LogicaSalon _accesosSalon = new LogicaSalon();
        LogicaInstructor _accesoInstructor = new LogicaInstructor();
        Acceso acceso;
        string loginPersona;
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarCombos();
            try
            {
                acceso = (Acceso)Session["loginPersona"];//recibo a través del SESSION el objeto "acceso" que esta compuesto por el login y el password de la persona que inicio sesión
                loginPersona = acceso.Login; //le asigno a la variable loginPersona el login de la persona que acaba de iniciar sesión, si nadie ha iniciado sesión esto se va al catch y te redirige al login, si la persona inicio sesión ya tengo su login y se quien es con esto puedo ir a la bd y ver que persona es para hacer las operaciones necesarias

                //a partir de aquí colocan toda la lógica de sus pantallas si desean usar el (!IsPostBack) lo pueden hacer sin ningún problema

                if (!IsPostBack)
                {
                    //el código que quieran!
                }

            }
            catch (NullReferenceException) //si la persona no ha iniciado sesión y simplemente pegó el URL en el navegador va a caer en esta excepción
            {

                Response.Redirect("../../Home/Login.aspx"); //lo redirigimos al LOGIN para que a juro se tenga que autenticar
            }

        }
        private void Init2()
        {
            _listClase = new List<Clase>();
            _listSalon = new List<Salon>();
            _listInstructor = new List<Instructor>();
            _listClaseSalon = new List<ClaseSalon>();
            _accesoClase = new LogicaClase();
            _accesosSalon = new LogicaSalon();
            _accesoInstructor = new LogicaInstructor();
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
                ComboInstructor.Items.Add(ins.NombrePersona1+" "+ins.ApellidoPersona1);
            }

        }
        protected void defaultButton_Click(object sender, EventArgs e)
        {
            bool flag = false;

                    flag = _accesosSalon.AgregarSalonesClase(_listClase[ComboClase.SelectedIndex].IdClase, _listInstructor[ComboInstructor.SelectedIndex].IdPersona, _listSalon[ComboSalon.SelectedIndex].IdSalon);
                    if (flag == true)
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
            Response.Redirect("../../Home/Home.aspx");
        }
    }
}
