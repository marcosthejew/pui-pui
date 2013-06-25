using System;
using System.Linq;
using System.Web;
using System.Xml;
using System.Web.Services;
using System.Collections.Generic;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Comandos;
using PuiPuiCapaLogicaDeNegocios.Entidades.EReservaciones;


namespace PuiPuiCapaLogicaDeNegocios.Servicios.FrontOffice
{

    public class FachadaReservarClasesFrontOffice : System.Web.Services.WebService
    {
        XmlWriterSettings xwrSettings;

        [WebMethod]
        public XmlDocument ServicioConsultarTodosReservacionesClases()
        {
            AEntidad evento = FabricaEntidad.CrearReservacionEventoCalendario();
            
            List<AEntidad> respuesta = FabricaComando.CrearComandoConsultarTodosReservacionClase().Ejecutar();

            xwrSettings = new XmlWriterSettings();
            xwrSettings.IndentChars = "\t";
            xwrSettings.NewLineHandling = NewLineHandling.Entitize;
            xwrSettings.Indent = true;
            xwrSettings.NewLineChars = "\n";

            XmlWriter writer = XmlWriter.Create(@"C:\ReservacionesClases.xml", xwrSettings);
            writer.WriteStartDocument();
            writer.WriteStartElement("eventos");

            foreach (AEntidad lista in respuesta)
            {
                writer.WriteStartElement("evento");
                writer.WriteElementString("id", (lista as ReservacionEventoCalendario).id.ToString());
                writer.WriteElementString("title", (lista as ReservacionEventoCalendario).title);
                writer.WriteElementString("start", (lista as ReservacionEventoCalendario).start.ToString());
                writer.WriteElementString("end", (lista as ReservacionEventoCalendario).end.ToString());
                writer.WriteElementString("allDay", (lista as ReservacionEventoCalendario).allDay.ToString());
                writer.WriteElementString("end", (lista as ReservacionEventoCalendario).instructor);
                writer.WriteElementString("CuposDisponibles", (lista as ReservacionEventoCalendario).cuposDisponibles.ToString());
                writer.WriteElementString("status", (lista as ReservacionEventoCalendario).status.ToString());
                writer.WriteElementString("color", (lista as ReservacionEventoCalendario).color);
                writer.WriteElementString("textColor", (lista as ReservacionEventoCalendario).textColor);
                writer.WriteEndElement();

            }
            writer.WriteEndElement();
            writer.Flush();
            writer.WriteEndDocument();
            writer.Close();

            XmlDocument retorno = new XmlDocument();

            retorno.Load(@"C:\ReservacionesClases.xml");
            return retorno;
        }
    }
}
