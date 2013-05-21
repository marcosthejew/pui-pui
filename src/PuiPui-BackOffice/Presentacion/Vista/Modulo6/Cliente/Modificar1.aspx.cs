using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_BackOffice.Entidades.Cliente;
using PuiPui_BackOffice.PruebasUnitarias.Cliente;
using PuiPui_BackOffice.LogicaDeNegocios.Cliente;

namespace PuiPui_BackOffice.Presentacion.Vista.Modulo6.Cliente
{
    public partial class Modificar1 : System.Web.UI.Page
    {
        Persona persona;
        LogicaPersona logicaPersona = new LogicaPersona();
        Persona objPersona = new Persona();
        Persona nuevaPersona = new Persona();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Exito.Visible = false;
                falla.Visible = false;

                persona = (Persona)Session["idPersona"];
                int idPersona = persona.IdPersona;
                objPersona = logicaPersona.ConsultarDetallePersona(idPersona);
                llenarGenero(ComboGenero);
                llenarTipo(ComboTipo);
                CargarDatos();

            }
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
            string loginPersona = LUsuario.Text;
            string passwordPersona = LContrasena.Text;

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
            nuevaPersona.LoginPersona = loginPersona;
            nuevaPersona.PasswordPersona = passwordPersona;

            persona = (Persona)Session["idPersona"];
            int a = persona.IdPersona;

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
            LUsuario.Enabled = false;
            LContrasena.Enabled = false;
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

        //int a = persona.NumeroHistoria;

        //string[] _arreglorespuesta = { resp1, resp2, resp3, resp4, resp5, resp6, 
        //                               resp7, resp8, resp9, resp10, resp11, resp12,
        //                               resp13, resp14, resp15, resp16 };

        //LogicaHistoriaClinica historia = new LogicaHistoriaClinica();
        //historia.ModificarHistoriaClinica(_arreglorespuesta, a);

        //Response.Redirect("DetalleHistoriaClinica.aspx");


    }
}