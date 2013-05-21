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
    public partial class Agregar : System.Web.UI.Page
    {

        Persona persona;
        LogicaPersona logicaPersona = new LogicaPersona();
        Persona objPersona = new Persona();

        protected void Page_Load(object sender, EventArgs e)
        {
            Exito.Visible = false;
            falla.Visible = false;

        }


        protected void BAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                int cedula = Convert.ToInt32(LCedula.Text);
                string tipo = ComboTipo.SelectedItem.Text;
                DateTime fechaNacimiento = FechaNacimiento.SelectedDate;
                string genero = ComboGenero.Text;
                string primerNombre = LPrimerNombre.Text;
                string segundoNombre = LSegundoNombre.Text;
                string primerApellido = LPrimerApellido.Text;
                string segundoApellido = LSegundoApellido.Text;
                string telefonoCelular = LTelefonoCelular.Text;
                string telefonoLocal = LTelefonoLocal.Text;
                string nombreContactoEmergencia = LNombreContactoEmergencia.Text;
                string numeroContactoEmergencia = LTelefonoContactoEmergencia.Text;
                string correo = LCorreo.Text;
                string ciudad = LCiudad.Text;
                string direccion = LDireccion.Text;
                string usuario = LUsuario.Text;
                string contrasena = LContrasena.Text;
                string estado = "Activo";


                Persona objPersona = new Persona();
                objPersona.CedulaPersona = cedula;
                objPersona.TipoPersona = tipo;
                objPersona.FechaNacimientoPersona = fechaNacimiento;
                objPersona.GeneroPersona = genero;
                objPersona.NombrePersona1 = primerNombre;
                objPersona.NombrePersona2 = segundoNombre;
                objPersona.ApellidoPersona1 = primerApellido;
                objPersona.ApellidoPersona2 = segundoNombre;
                objPersona.TelefonoCelularPersona = telefonoCelular;
                objPersona.TelefonoLocalPersona = telefonoLocal;
                objPersona.ContactoNombrePersona = nombreContactoEmergencia;
                objPersona.ContactoTelefonoPersona = numeroContactoEmergencia;
                objPersona.CorreoPersona = correo;
                objPersona.CiudadPersona = ciudad;
                objPersona.DireccionPersona = direccion;
                objPersona.LoginPersona = usuario;
                objPersona.PasswordPersona = contrasena;
                objPersona.EstadoPersona = estado;


                LogicaPersona logicaPersona = new LogicaPersona();
                logicaPersona.AgregoCliente(objPersona);
                Exito.Visible = true;
                falla.Visible = false;

                LCedula.Enabled = false;
                ComboTipo.Enabled = false;
                FechaNacimiento.Enabled = false;
                ComboGenero.Enabled = false;
                LPrimerNombre.Enabled = false;
                LSegundoNombre.Enabled = false;
                LPrimerApellido.Enabled = false;
                LSegundoApellido.Enabled = false;
                LTelefonoCelular.Enabled = false;
                LTelefonoLocal.Enabled = false;
                LNombreContactoEmergencia.Enabled = false;
                LTelefonoContactoEmergencia.Enabled = false;
                LCorreo.Enabled = false;
                LCiudad.Enabled = false;
                LDireccion.Enabled = false;
                LUsuario.Enabled = false;
                LContrasena.Enabled = false;
                BAgregar.Visible = false;


            }
            catch (Exception error)
            {
                falla.Text = error.Message;
                Exito.Visible = false;
                falla.Visible = true;

            }
        }
    }
}