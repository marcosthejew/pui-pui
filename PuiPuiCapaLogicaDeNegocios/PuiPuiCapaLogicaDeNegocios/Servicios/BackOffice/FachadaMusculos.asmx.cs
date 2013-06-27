using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Comandos;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios;
using System.Xml;

namespace PuiPuiCapaLogicaDeNegocios.Servicios.BackOffice
{
    /// <summary>
    /// Summary description for FachadaMusculos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class FachadaMusculos : System.Web.Services.WebService
    {
        XmlTextWriter _escritorXML;

        [WebMethod]
        public bool ServicioAgregarMusculo(string nombre, string descripcion)
        {
            AEntidad musculo;

            musculo = FabricaEntidad.CrearMusculo(nombre, descripcion);
            return FabricaComando.CrearComandoAgregarMusculo(musculo).Ejecutar();
        }

        [WebMethod]
        public XmlDocument ServicioConsultarTodosLosMusculos() 
        {
            List<AEntidad> salida = FabricaComando.CrearConsultarTodosLosMusculos().Ejecutar();

            foreach (AEntidad lista in salida)
            {
                _escritorXML = new XmlTextWriter("C:\\XmlMusculosTodos.xml", null);
                _escritorXML.WriteStartDocument();
                _escritorXML.WriteComment("XMl para la consulta de musculos");
                _escritorXML.WriteStartElement("Musculos");
                _escritorXML.WriteElementString("id", XmlConvert.ToString((lista as Musculo).IdMusculo));
                _escritorXML.WriteElementString("nombre", ((lista as Musculo).NombreMusculo));
                _escritorXML.WriteElementString("descripcion", (lista as Musculo).Descripcion);
                _escritorXML.WriteElementString("estatus",XmlConvert.ToString ((lista as Musculo).Status));
                _escritorXML.WriteEndElement();
            }

            _escritorXML.Flush();
            _escritorXML.WriteEndDocument();
            _escritorXML.Close();

            XmlDocument retorno = new XmlDocument();

            retorno.Load("C:\\XmlMusculosTodos.xml");

            return retorno;
        }


        [WebMethod]
        public bool ServicioDesactivarMusculo(int idMusculo)
        {
            return FabricaComando.CrearDesactivarMusculos(FabricaEntidad.CrearMusculo(idMusculo)).Ejecutar();
        }

    }
}
