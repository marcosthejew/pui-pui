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
                Exito.Visible = false;
                falla.Visible = false;
                
            }
            catch (NullReferenceException)
            {

                Response.Redirect("../../Home/Login.aspx");
            }
            
        }


        protected void BAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                int cedula = Convert.ToInt32(LCedula.Text.TrimEnd());
                string tipo = ComboTipo.SelectedItem.Text.TrimEnd();
                DateTime fechaNacimiento = FechaNacimiento.SelectedDate;
                string genero = ComboGenero.Text.TrimEnd();
                string primerNombre = LPrimerNombre.Text.TrimEnd();
                string segundoNombre = LSegundoNombre.Text.TrimEnd();
                string primerApellido = LPrimerApellido.Text.TrimEnd();
                string segundoApellido = LSegundoApellido.Text.TrimEnd();
                string telefonoCelular = LTelefonoCelular.Text.TrimEnd();
                string telefonoLocal = LTelefonoLocal.Text.TrimEnd();
                string nombreContactoEmergencia = LNombreContactoEmergencia.Text.TrimEnd();
                string numeroContactoEmergencia = LTelefonoContactoEmergencia.Text.TrimEnd();
                string correo = LCorreo.Text.TrimEnd();
                string ciudad = LCiudad.Text.TrimEnd();
                string direccion = LDireccion.Text.TrimEnd();
                string usuario = LUsuario.Text.TrimEnd();
                string contrasena = LContrasena.Text.TrimEnd();
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