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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                persona = (Persona)Session["idPersona"];
                int idPersona = persona.IdPersona;
                objPersona = logicaPersona.ConsultarDetallePersona(idPersona);
                llenarGenero(ComboGenero);
                llenarTipo(ComboTipo);
                CargarDatos();
            }
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
            LFechaNacimiento.Text = objPersona.FechaNacimientoPersona.ToString("dd-MM-yyyy");
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