using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_FrontOffice.Entidades.Cliente;
using PuiPui_FrontOffice.LogicaDeNegocios.Cliente;

namespace PuiPui_FrontOffice.Presentacion.Vista.Modulo6.Cliente
{
    public partial class Consultar : System.Web.UI.Page
    {
        Acceso acceso;
        string loginPersona;
        LogicaPersona logicaPersona = new LogicaPersona();
        Persona objPersona = new Persona();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                acceso = (Acceso)Session["loginPersona"];
                loginPersona = acceso.Login;

                if (!IsPostBack)
                {
                    Exito.Visible = false;
                    falla.Visible = false;

                    objPersona = logicaPersona.ConsultarPersonaPorLogin(loginPersona);
                    llenarGenero(ComboGenero);
                    llenarTipo(ComboTipo);
                    CargarDatos();
                    BloquearPantalla();
                }

            }
            catch (NullReferenceException)
            {

                Response.Redirect("../../Home/Login.aspx");
            }
        }

        public void BloquearPantalla()
        {
            LIdentificador.Enabled = false;
            LFechaIngreso.Enabled = false;
            LFechaNacimiento.Enabled = false;
            ComboGenero.Enabled = false;
            LPrimerNombre.Enabled = false;
            LSegundoNombre.Enabled = false;
            LPrimerApellido.Enabled = false;
            LSegundoApellido.Enabled = false;
            LTelefonoCelular.Enabled = false;
            LTelefonoLocal.Enabled = false;
            LDireccion.Enabled = false;
            LCorreo.Enabled = false;
            ComboTipo.Enabled = false;
            LCedula.Enabled = false;
            LCiudad.Enabled = false;
            LNombreContactoEmergencia.Enabled = false;
            LTelefonoContactoEmergencia.Enabled = false;
            ComboStatus.Enabled = false;
            LUsuario.Enabled = false;
            LContrasena.Enabled = false;

        }
        public void llenarGenero(DropDownList ComboGenero)
        {
            ComboGenero.Items.Clear();
            ComboGenero.Items.Add("Femenino");
            ComboGenero.Items.Add("Masculino");
        }

        public void llenarTipo(DropDownList ComboTipo)
        {
            ComboTipo.Items.Clear();
            ComboTipo.Items.Add("Cliente");
            ComboTipo.Items.Add("Administrador");
        }

        public void CargarDatos()
        {
            Exito.Visible = false;
            falla.Visible = false;

            LIdentificador.Text = objPersona.IdPersona.ToString();
            LIdentificador.Enabled = false;
            LFechaIngreso.Text = objPersona.FechaIngresoPersona.ToString("dd-MM-yyyy");
            LFechaIngreso.Enabled = false;
            LFechaNacimiento.SelectedDate = objPersona.FechaNacimientoPersona;
            ComboGenero.SelectedValue = objPersona.GeneroPersona.ToString();
            LPrimerNombre.Text = objPersona.NombrePersona1.ToString();
            LSegundoNombre.Text = objPersona.NombrePersona2.ToString();
            LPrimerApellido.Text = objPersona.ApellidoPersona1.ToString();
            LSegundoApellido.Text = objPersona.ApellidoPersona2.ToString();
            LTelefonoCelular.Text = objPersona.TelefonoCelularPersona.ToString();
            LTelefonoLocal.Text = objPersona.TelefonoLocalPersona.ToString();
            LDireccion.Text = objPersona.DireccionPersona.ToString();

            LCorreo.Text = objPersona.CorreoPersona.ToString();
            ComboTipo.SelectedValue = objPersona.TipoPersona;
            ComboTipo.Enabled = false;
            LCedula.Text = objPersona.CedulaPersona.ToString();
            LCiudad.Text = objPersona.CiudadPersona.ToString();
            LNombreContactoEmergencia.Text = objPersona.ContactoNombrePersona.ToString();
            LTelefonoContactoEmergencia.Text = objPersona.ContactoTelefonoPersona.ToString();
            ComboStatus.Text = objPersona.EstadoPersona.ToString();
            LUsuario.Text = objPersona.LoginPersona.ToString();
            LContrasena.Text = objPersona.PasswordPersona.ToString();
        }

    }
}