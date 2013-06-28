using System;
using System.Linq;
using System.Web;
using System.Xml;
using System.Web.Services;
using System.Web.Script.Serialization;
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
        public String ServicioConsultarTodosReservacionesClases()
        {
            List<AEntidad> respuesta = FabricaComando.CrearComandoConsultarTodosReservacionClase().Ejecutar();
            JavaScriptSerializer CadenaASerializar = new JavaScriptSerializer();
            string _salidaDocXml = CadenaASerializar.Serialize(respuesta);


            xwrSettings = new XmlWriterSettings();
            xwrSettings.IndentChars = "\t";
            xwrSettings.NewLineHandling = NewLineHandling.Entitize;
            xwrSettings.Indent = true;
            xwrSettings.NewLineChars = "\n";

            XmlWriter writer = XmlWriter.Create(@"C:\Users\DesarrolloTIG\Desktop\ClasesDisponibles.xml", xwrSettings);
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
                writer.WriteElementString("instructor", (lista as ReservacionEventoCalendario).instructor);
                writer.WriteElementString("color", (lista as ReservacionEventoCalendario).color);
                writer.WriteElementString("textColor", (lista as ReservacionEventoCalendario).textColor);
                writer.WriteEndElement();

            }
            writer.WriteEndElement();
            writer.Flush();
            writer.WriteEndDocument();
            writer.Close();

            XmlDocument _retornoDoc = new XmlDocument();
            _retornoDoc.Load(@"C:\Users\DesarrolloTIG\Desktop\ClasesDisponibles.xml");
            //return _retornoDoc.OuterXml;
            return _salidaDocXml;
        }


        [WebMethod]
        public String ServicioConsultarDetalleReservacionPorId(int idReservacion)
        {
            List<AEntidad> respuesta = FabricaComando.CrearComandoConsultarTodosReservacionClase().Ejecutar();
            JavaScriptSerializer CadenaASerializar = new JavaScriptSerializer();
            string _salidaDocXml = CadenaASerializar.Serialize(respuesta);


            xwrSettings = new XmlWriterSettings();
            xwrSettings.IndentChars = "\t";
            xwrSettings.NewLineHandling = NewLineHandling.Entitize;
            xwrSettings.Indent = true;
            xwrSettings.NewLineChars = "\n";

            XmlWriter writer = XmlWriter.Create(@"C:\Users\DesarrolloTIG\Desktop\ClasesDisponibles.xml", xwrSettings);
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
                writer.WriteElementString("instructor", (lista as ReservacionEventoCalendario).instructor);
                writer.WriteElementString("color", (lista as ReservacionEventoCalendario).color);
                writer.WriteElementString("textColor", (lista as ReservacionEventoCalendario).textColor);
                writer.WriteEndElement();

            }
            writer.WriteEndElement();
            writer.Flush();
            writer.WriteEndDocument();
            writer.Close();

            XmlDocument _retornoDoc = new XmlDocument();
            _retornoDoc.Load(@"C:\Users\DesarrolloTIG\Desktop\ClasesDisponibles.xml");
            //return _retornoDoc.OuterXml;
            return _salidaDocXml;
        }
    }
}
