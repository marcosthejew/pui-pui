using System.Collections.Generic;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Web.Script.Services;
using System.Web.Security;
using System.Web.Security;
using System.Web.Services;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Web;
using System;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTReservarClase;
using PuiPuiCapaDeInterfazFrontOffice.Contratos;
using PuiPuiCapaDeInterfazFrontOffice.Presentadores.PReservarClase;



namespace PuiPuiCapaDeInterfazFrontOffice.Vistas.VReservarClase
{
    public partial class ConsultarDetalleReservacionClase : System.Web.UI.Page,IContratoConsultarDetalleReservacionClase
    {
        private int _idPersona = 0;
        private int _idEvento;
        private PConsultarDetalleReservacionClase _presentadorDetalleConsulta;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _idEvento = int.Parse(Request.QueryString["idEvento"]);
            }
            _presentadorDetalleConsulta = new PConsultarDetalleReservacionClase(this);
            lbDescripcionClase.Text = _idEvento.ToString();
            
        }
        public String TextNombreCliente
        {
            get { return tbCliente.Text; }
            set { tbCliente.Text =_idEvento.ToString(); }

        }
        public String TextDescripcionClase
        {
            get { return lbDescripcionClase.Text; }
            set { lbDescripcionClase.Text = value; }

        }
        public String TextFechaClase
        {
            get { return lbDia.Text; }
            set { lbDia.Text = value; }

        }
        public String TextInicioClase
        {
            get { return lbHoraInicio.Text; }
            set { lbHoraInicio.Text = value; }

        }
        public String TextFinalizaClase
        {
            get { return lbHoraFin.Text; }
            set { lbHoraFin.Text = value; }

        }
        public String TextNombreInstructor
        {
            get { return lbInstructorNombre.Text; }
            set { lbInstructorNombre.Text = value; }

        }
        public String TextEmailInstructor
        {
            get { return lbInstructorCorreo.Text; }
            set { lbInstructorCorreo.Text = value; }

        }
        public String TextUbicacionSalon
        {
            get { return lbSalonUbicacion.Text; }
            set { lbSalonUbicacion.Text = value; }

        }
        public String TextCapacidadSalon
        {
            get { return lbSalonCapacidad.Text; }
            set { lbSalonCapacidad.Text = value; }

        }
        public String TextEstatusReservacion
        {
            get { return lbEstatusReservacion.Text; }
            set { lbEstatusReservacion.Text = value; }

        }
        public int SessionID
        {
            get { return _idPersona; }
            set { SessionID = value; }

        }
        public void ConsultarDetalle()
        { 
        
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Vistas/VReservarClase/ReservarClase.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Vistas/VReservarClase/ReservarClase.aspx");
        }
    }
}