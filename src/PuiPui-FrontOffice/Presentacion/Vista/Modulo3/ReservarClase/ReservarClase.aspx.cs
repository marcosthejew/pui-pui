using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPui_FrontOffice.Entidades.Clase;
using PuiPui_FrontOffice.LogicaDeNegocios.ReservarClase;



namespace PuiPui_FrontOffice.Presentacion.Vista.Modulo3.ReservarClase
{
    public partial class ReservarClase : System.Web.UI.Page
    {

        LogicaReservarClase logicaReservarClase = new LogicaReservarClase();
        Clase objClase = new Clase();

        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
           {
               LoadDdlClasesDisponibles();
           }
        }

        protected void ddlClasesDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idClase = Convert.ToInt32(ddlClasesDisponibles.SelectedValue);

            LoadDdlHorariosReservaDisponibles(idClase);

        }

        protected void ddlHorariosReservaDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idHorarioReservaDisponible = Convert.ToInt32(ddlHorariosReservaDisponibles.SelectedValue);

            LoadDdlInstructoresDisponibles(idHorarioReservaDisponible);
        }

        protected void ddlInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idInstructor = Convert.ToInt32(ddlInstructoresDisponibles.SelectedValue);

            //LoadGridViewCustomer(idInstructor);
        }

        private void LoadDdlClasesDisponibles()
        {

            ddlClasesDisponibles.DataSource = logicaReservarClase.ListarClases();
            //ddlArtist.DataSource = ChinookDAL.GellAllArtist();
            ddlClasesDisponibles.DataTextField = "nombre";
            ddlClasesDisponibles.DataValueField = "idClase";
            ddlClasesDisponibles.DataBind();

            if (ddlClasesDisponibles.Items.Count != 0)
            {
                int idClases = Convert.ToInt32(ddlClasesDisponibles.SelectedValue);

                LoadDdlHorariosReservaDisponibles(idClases);
            }
            else
            {
                ddlHorariosReservaDisponibles.Items.Clear();
                ddlInstructoresDisponibles.Items.Clear();
               // dvCustomer.DataSource = null;
               // dvCustomer.DataBind();
            }
        }

        private void LoadDdlHorariosReservaDisponibles(int idClases)
        {

            ddlHorariosReservaDisponibles.DataSource = logicaReservarClase.BuscarHorariosDisponibles(idClases);
           
            ddlHorariosReservaDisponibles.DataTextField = "Horario";
            ddlHorariosReservaDisponibles.DataValueField = "HoraReserva";
            ddlHorariosReservaDisponibles.DataBind();


            if (ddlHorariosReservaDisponibles.Items.Count != 0)
            {
                int idHorariosReservaSeleccionado = Convert.ToInt32(ddlHorariosReservaDisponibles.SelectedValue);

                LoadDdlInstructoresDisponibles(idHorariosReservaSeleccionado);
            }
            else
            {
                ddlInstructoresDisponibles.Items.Clear();
                //dvCustomer.DataSource = null;
                //dvCustomer.DataBind();
            }
        }

        private void LoadDdlInstructoresDisponibles(int idHorariosReservaSeleccionado)
        {
            ddlInstructoresDisponibles.DataSource = logicaReservarClase.ListarInstructoresDisponibles(idHorariosReservaSeleccionado);

            ddlInstructoresDisponibles.DataTextField = "Nombre";
            ddlInstructoresDisponibles.DataValueField = "IdInstructor";
            ddlInstructoresDisponibles.DataBind();

           /*if (ddlTrack.Items.Count != 0)
            {
                int TrackId = Convert.ToInt32(ddlTrack.SelectedValue);

                LoadGridViewCustomer(TrackId);
            }
            else
            {
                dvCustomer.DataSource = null;
                dvCustomer.DataBind();
            }*/
        }

        protected void BtnReservarClase_Click(object sender, EventArgs e)
        {
            /*int idCliente = Convert.ToInt32(LIdentificador.Text);
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



            logicaPersona.ModificarPersona(nuevaPersona);
            Exito.Visible = true;
            BloquearPantalla();*/
        }
    }
}