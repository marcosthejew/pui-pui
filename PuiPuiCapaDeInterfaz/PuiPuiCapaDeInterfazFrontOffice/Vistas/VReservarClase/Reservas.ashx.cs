using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Globalization;
using PuiPuiCapaDeInterfazFrontOffice.Presentadores.PReservarClase;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTReservarClase;
using PuiPuiCapaDeInterfazFrontOffice.Contratos;

namespace PuiPuiCapaDeInterfazFrontOffice.Vistas.VReservarClase
{
    /// <summary>
    /// Summary description for Reservas
    /// </summary>
    public class Reservas : IHttpHandler, IContratoReservarClase
    {

        private PReservarClase _presentador;
        string datos;
        public Reservas()
        {
            _presentador = new PReservarClase(this);
        }

        public String lbNombreClase
        {
            get { return datos.ToString(); }
            set { datos = value; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Expires = -1;
            // /*
            string sJSON2 = _presentador.WSObtenerReservaciones();
            context.Response.Write(sJSON2);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}