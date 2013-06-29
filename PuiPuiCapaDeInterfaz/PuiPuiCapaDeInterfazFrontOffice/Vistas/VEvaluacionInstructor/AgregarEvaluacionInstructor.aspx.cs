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
    public partial class AgregarEvaluacionInstructor : System.Web.UI.Page, IContratoAgregarEvaluarInstructor
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


        }

        protected void botonModificar_Click(object sender, EventArgs e)
        {
            if ((TXCalificacion.Equals("")) || (TXFecha.Equals("")) || (TXnombreCliente.Equals("")) || (TXnombreInstructor.Equals("")) || (TXObservacion.Equals("")))
            {
                NClase.Visible = true;
            }
            else
            {
                PAgregarEvaluacionInstructor modificarClase = new PAgregarEvaluacionInstructor(this);
                int seModifico = modificarClase.AgregarClase();
                if (seModifico == 0)
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
                    falla.Visible = true;
            }
        }


    }
}