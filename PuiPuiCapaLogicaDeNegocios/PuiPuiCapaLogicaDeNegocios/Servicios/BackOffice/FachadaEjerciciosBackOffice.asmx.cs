using System;
using System.Linq;
using System.Web;
using System.Xml;
using System.Web.Services;
using System.Collections.Generic;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Comandos;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios;

namespace PuiPuiCapaLogicaDeNegocios.Servicios.BackOffice
{
    public class FachadaEjerciciosBackOffice : System.Web.Services.WebService
    {

        XmlTextWriter _escritorXML;

        [WebMethod]
        public bool ServicioAgregarEjercicio(string nombre, string descripcion, int idMusculo,string nombreMusculo)
        {
            AEntidad ejercicio;
            AEntidad musculo;
            musculo=FabricaEntidad.CrearMusculo(idMusculo,nombreMusculo);
            ejercicio=FabricaEntidad.CrearEjercicio(0,nombre,descripcion,(musculo as Musculo));

            return FabricaComando.CrearComandoAgregarEjercicio(ejercicio).Ejecutar();
        }

        [WebMethod]
        public XmlDocument ServicioConsultarEjecicioId(int id)
        {
            AEntidad ejercicio = FabricaEntidad.CrearEjercicio(id);
            AEntidad respuesta;
            respuesta= FabricaComando.CrearComandoConsultarPorIdEjercicio(ejercicio).Ejecutar();

            _escritorXML = new XmlTextWriter("C:\\XmlEjercicio.xml", null);
            _escritorXML.WriteStartDocument();
            _escritorXML.WriteComment("XMl para la consulta de ejercicios por Id");

            _escritorXML.WriteStartElement("Ejercicio");
            _escritorXML.WriteElementString("id",XmlConvert.ToString((respuesta as Ejercicio).Id));
            _escritorXML.WriteElementString("nombre",(respuesta as Ejercicio).Nombre);
            _escritorXML.WriteElementString("descripcion", (respuesta as Ejercicio).Descripcion);
            _escritorXML.WriteElementString("id", XmlConvert.ToString((respuesta as Ejercicio).Musculo.Id));
            _escritorXML.WriteEndElement();
            _escritorXML.WriteEndDocument();
            _escritorXML.Close();

            XmlDocument retorno= new XmlDocument();

            retorno.Load("C:\\XmlEjercicio.xml");

            return retorno;
        }

        [WebMethod]
        public void ServicioConsultarEjercicioTodos()
        {
            List<AEntidad> respuesta = FabricaComando.CrearComandoConsultarEjerciciosTodos().Ejecutar();

        }

        [WebMethod]
        public bool ServicioInactivarEjercicio(int id)
        {
            return FabricaComando.CrearComandoInactivarEjercicio(FabricaEntidad.CrearEjercicio(id)).Ejecutar();
        }

        [WebMethod]
        public bool ServicioModificarEjercicio(int id, string nombreEjercicio, string descripcionEjercicio, int idMusculo, string nombreMusculo)
        {
            AEntidad ejercicio=FabricaEntidad.CrearEjercicio(id,nombreEjercicio,descripcionEjercicio,(FabricaEntidad.CrearMusculo(idMusculo,nombreMusculo)as Musculo));
            return FabricaComando.CrearComandoModificarEjercicio(ejercicio).Ejecutar();
        }

    }
}
