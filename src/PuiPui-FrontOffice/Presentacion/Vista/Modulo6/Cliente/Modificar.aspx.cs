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
    public partial class Modificar : System.Web.UI.Page
    {
        Acceso acceso;
        Persona persona;

        string loginPersona;
        LogicaPersona logicaPersona = new LogicaPersona();
        Persona nuevaPersona = new Persona();

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

                    nuevaPersona = logicaPersona.ConsultarPersonaPorLogin(loginPersona);
                    llenarGenero(ComboGenero);
                    llenarTipo(ComboTipo);
                    CargarDatos();
                    
                }

            }
            catch (NullReferenceException)
            {

                Response.Redirect("../../Home/Login.aspx");
            }
        }
        protected void Cambiar_Click(object sender, EventArgs e)
        {
            persona = (Persona)Session["idPersona"];
            Session["idPersona"] = persona;

            Response.Redirect("../../Home/CambiarContraseña.aspx");
        }

        protected void BRegistrar_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(LIdentificador.Text);
            DateTime fechaIngreso = Convert.ToDateTime(LFechaIngreso.Text);
            DateTime fechaNacimiento = LFechaNacimiento.SelectedDate;
            string generoPersona = ComboGenero.SelectedItem.Text;
            string nombrePersona1 = LPrimerNombre.Text;
            string nombrePersona2 = LSegundoNombre.Text;
            string apellidoPersona1 = LPrimerApellido.Text;
            string apellidoPersona2 = LSegundoApellido.Text;
            string telefonoCelularPersona = LTelefonoCelular.Text;
            string telefonoLocalPersona = LTelefonoLocal.Text;
            string direccionPersona = LDireccion.Text;
            string correoPersona = LCorreo.Text;
            string tipoPersona = ComboTipo.SelectedItem.Text;
            int cedulaPersona = Convert.ToInt32(LCedula.Text);
            string ciudadPersona = LCiudad.Text;
            string contactoNombrePersona = LNombreContactoEmergencia.Text;
            string contactoTelefonoPersona = LTelefonoContactoEmergencia.Text;
            string estadoPersona = ComboStatus.SelectedItem.Text;

            nuevaPersona.IdPersona = idCliente;
            nuevaPersona.FechaIngresoPersona = fechaIngreso;
            nuevaPersona.FechaNacimientoPersona = fechaNacimiento;
            nuevaPersona.GeneroPersona = generoPersona;
            nuevaPersona.NombrePersona1 = nombrePersona1;
            nuevaPersona.NombrePersona2 = nombrePersona2;
            nuevaPersona.ApellidoPersona1 = apellidoPersona1;
            nuevaPersona.ApellidoPersona2 = apellidoPersona2;
            nuevaPersona.TelefonoCelularPersona = telefonoCelularPersona;
            nuevaPersona.TelefonoLocalPersona = telefonoLocalPersona;
            nuevaPersona.DireccionPersona = direccionPersona;
            nuevaPersona.CorreoPersona = correoPersona;
            nuevaPersona.TipoPersona = tipoPersona;
            nuevaPersona.CedulaPersona = cedulaPersona;
            nuevaPersona.CiudadPersona = ciudadPersona;
            nuevaPersona.ContactoNombrePersona = contactoNombrePersona;
            nuevaPersona.ContactoTelefonoPersona = contactoTelefonoPersona;
            nuevaPersona.EstadoPersona = estadoPersona;

          

            logicaPersona.ModificarPersona(nuevaPersona);
            Exito.Visible = true;
            BloquearPantalla();
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
            BRegistrar.Visible = false;
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

            LIdentificador.Text = nuevaPersona.IdPersona.ToString();
            LIdentificador.Enabled = false;
            LFechaIngreso.Text = nuevaPersona.FechaIngresoPersona.ToString("dd-MM-yyyy");
            LFechaIngreso.Enabled = false;
            LFechaNacimiento.SelectedDate = nuevaPersona.FechaNacimientoPersona;
            ComboGenero.SelectedValue = nuevaPersona.GeneroPersona.ToString();
            LPrimerNombre.Text = nuevaPersona.NombrePersona1.ToString();
            LSegundoNombre.Text = nuevaPersona.NombrePersona2.ToString();
            LPrimerApellido.Text = nuevaPersona.ApellidoPersona1.ToString();
            LSegundoApellido.Text = nuevaPersona.ApellidoPersona2.ToString();
            LTelefonoCelular.Text = nuevaPersona.TelefonoCelularPersona.ToString();
            LTelefonoLocal.Text = nuevaPersona.TelefonoLocalPersona.ToString();
            LDireccion.Text = nuevaPersona.DireccionPersona.ToString();

            LCorreo.Text = nuevaPersona.CorreoPersona.ToString();
            ComboTipo.SelectedValue = nuevaPersona.TipoPersona;
            ComboTipo.Enabled = false;
            LCedula.Text = nuevaPersona.CedulaPersona.ToString();
            LCiudad.Text = nuevaPersona.CiudadPersona.ToString();
            LNombreContactoEmergencia.Text = nuevaPersona.ContactoNombrePersona.ToString();
            LTelefonoContactoEmergencia.Text = nuevaPersona.ContactoTelefonoPersona.ToString();
            ComboStatus.Text = nuevaPersona.EstadoPersona.ToString();

        }

    }
}