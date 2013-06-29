using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTInstructor;
using PuiPuiCapaDeInterfazFrontOffice.Presentadores.PInstructor;


namespace PuiPuiCapaDeInterfazFrontOffice.Vistas.VEvaluacionInstructor
{
    public partial class ModificarEvaluacionInstructor : System.Web.UI.Page, IContratoModificarEvaluarInstructor
    {
        private int _idevaluacion = 0;
        
        public int SessionID
        {
            get { return _idevaluacion; }
            set { _idevaluacion = value; }
        }

        public String TXnombreCliente
        {
            get { return nombreCliente.Text; }
            set { nombreCliente.Text = value; }
        }

        public String TXnombreInstructor
        {
            get { return MnombreInstructor.Text; }
            set { MnombreInstructor.Text = value; }
        }

        public String TXFecha
        {
            get { return Fecha.Text; }
            set { Fecha.Text = value; }
        }

        public String TXObservacion
        {
            get { return Observacion.Text; }
            set { Observacion.Text = value; }
        }

        public String TXCalificacion
        {
            get { return Calificacion.Text; }
            set { Calificacion.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SessionID = Convert.ToInt32((Request.QueryString["id"] != null) ? Request.QueryString["id"] : "");
            TXFecha = DateTime.Now.ToString();
            /**String _fecha = Convert.ToString((Request.QueryString["fecha"] != null) ? Request.QueryString["fecha"] : "");
            String _observacion = Convert.ToString((Request.QueryString["observacion"] != null) ? Request.QueryString["observacion"] : "");
            String _cliente = Convert.ToString((Request.QueryString["cliente"] != null) ? Request.QueryString["cliente"] : "");
            String _instructor =Convert.ToString((Request.QueryString["instructor"] != null) ? Request.QueryString["instructor"] : "");
            String _calificacion =Convert.ToString((Request.QueryString["calificacion"] != null) ? Request.QueryString["calificacion"] : "");            
            TXnombreCliente = _cliente;
            TXnombreInstructor = _instructor;
            TXFecha = _fecha;
            TXObservacion = _observacion;
            TXCalificacion = _calificacion;
            **/
        }



        protected void botonModificar_Click(object sender, EventArgs e)
        {
            if ((TXCalificacion.Equals("")) || (TXFecha.Equals("")) || (TXnombreCliente.Equals("")) || (TXnombreInstructor.Equals("")) || (TXObservacion.Equals("")))
            {
                NClase.Visible = true;
            }
            else
            {
                PModificarEvaluacionInstructor modificarClase = new PModificarEvaluacionInstructor(this);
                bool seModifico = modificarClase.ModificarClase();
                if (seModifico == true)
                {
                    falla.Visible = false;
                    Exito.Visible = true;
                    TXCalificacion = "";
                    TXFecha = "";
                    TXnombreCliente = "";
                    TXnombreInstructor = "";
                    TXObservacion = "";

                }
                else
                    Exito.Visible = false;
                    falla.Visible = true;
            }
        }

        protected void botonRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarEvaluacionInstructor.aspx");
        }


    }
}