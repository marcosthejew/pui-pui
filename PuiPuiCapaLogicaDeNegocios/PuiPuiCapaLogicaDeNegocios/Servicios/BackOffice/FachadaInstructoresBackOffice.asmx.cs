using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Comandos;
using PuiPuiCapaLogicaDeNegocios.Entidades.EPersonas;
using System.Xml;

namespace PuiPuiCapaLogicaDeNegocios.Servicios.BackOffice
{
    public class FachadaInstructoresBackOffice : System.Web.Services.WebService
    {
        XmlTextWriter _escritorXML;

        [WebMethod]
        public XmlDocument ServicioConsultarTodosInstructor()
        {
            List<AEntidad> _respuesta = FabricaComando.CrearComandoConsultarTodosInstructor().Ejecutar();

            foreach (AEntidad lista in _respuesta)
            {
                _escritorXML = new XmlTextWriter("C:\\XmlInstructorTodos.xml", null);
                _escritorXML.WriteStartDocument();
                _escritorXML.WriteComment("XMl para la consulta de instructores por Id");
                _escritorXML.WriteStartElement("Instructor");
                _escritorXML.WriteElementString("id", XmlConvert.ToString((lista as Instructor).Id));
                _escritorXML.WriteElementString("cedula", (lista as Instructor).CedulaPersona);
                _escritorXML.WriteElementString("primerNombre", (lista as Instructor).NombrePersona1);
                _escritorXML.WriteElementString("segundoNombre", (lista as Instructor).NombrePersona2);
                _escritorXML.WriteElementString("primerApellido", (lista as Instructor).ApellidoPersona1);
                _escritorXML.WriteElementString("segundoApellido", (lista as Instructor).ApellidoPersona2);
                _escritorXML.WriteElementString("segundoNombre", (lista as Instructor).NombrePersona2);
                _escritorXML.WriteElementString("sexo", (lista as Instructor).GeneroPersona);
                _escritorXML.WriteElementString("fechaNacimiento", XmlConvert.ToString((lista as Instructor).FechaNacimientoPersona));
                _escritorXML.WriteElementString("fechaIngreso", XmlConvert.ToString((lista as Instructor).FechaIngresoPersona));
                _escritorXML.WriteElementString("entidadFederal", (lista as Instructor).EstadoPersona);
                _escritorXML.WriteElementString("ciudad", (lista as Instructor).CiudadPersona);
                _escritorXML.WriteElementString("direccion", (lista as Instructor).DireccionPersona);
                _escritorXML.WriteElementString("telefonoLocal", (lista as Instructor).TelefonoLocalPersona);
                _escritorXML.WriteElementString("telefonoCelular", (lista as Instructor).TelefonoCelularPersona);
                _escritorXML.WriteElementString("email", (lista as Instructor).CorreoPersona);
                _escritorXML.WriteElementString("nombreContactoEmergencia", (lista as Instructor).NombreContactoEmergencia);
                _escritorXML.WriteElementString("telefonoContactoEmergencia", (lista as Instructor).TelefonoContactoEmergencia);
                //_escritorXML.WriteElementString("status", (lista as Instructor).Status);
                //_escritorXML.WriteElementString("horario", XmlConvert.ToString((lista as Instructor).Horario));
                _escritorXML.WriteEndElement();
            }

            _escritorXML.Flush();
            _escritorXML.WriteEndDocument();
            _escritorXML.Close();

            XmlDocument _retorno = new XmlDocument();

            _retorno.Load("C:\\XmlInstructorTodos.xml");

            return _retorno;
        }

        [WebMethod]
        public XmlDocument ServicioConsultarPorIdInstructor(int id)
        {
            AEntidad instructor = FabricaEntidad.CrearInstructor(id);
            AEntidad respuesta;
            respuesta = FabricaComando.CrearComandoConsultarPorIdInstructor(instructor).Ejecutar();

            _escritorXML = new XmlTextWriter("C:\\XmlInstructor.xml", null);
            _escritorXML.WriteStartDocument();
            _escritorXML.WriteComment("XMl para la consulta de instructor por Id");

            _escritorXML.WriteStartElement("Instructor");
            _escritorXML.WriteElementString("id", XmlConvert.ToString((respuesta as Instructor).Id));
            _escritorXML.WriteElementString("cedula", (respuesta as Instructor).CedulaPersona);
            _escritorXML.WriteElementString("primerNombre", (respuesta as Instructor).NombrePersona1);
            _escritorXML.WriteElementString("segundoNombre", (respuesta as Instructor).NombrePersona2);
            _escritorXML.WriteElementString("primerApellido", (respuesta as Instructor).ApellidoPersona1);
            _escritorXML.WriteElementString("segundoApellido", (respuesta as Instructor).ApellidoPersona2);
            _escritorXML.WriteElementString("segundoNombre", (respuesta as Instructor).NombrePersona2);
            _escritorXML.WriteElementString("sexo", (respuesta as Instructor).GeneroPersona);
            _escritorXML.WriteElementString("fechaNacimiento", XmlConvert.ToString((respuesta as Instructor).FechaNacimientoPersona));
            _escritorXML.WriteElementString("fechaIngreso", XmlConvert.ToString((respuesta as Instructor).FechaIngresoPersona));
            _escritorXML.WriteElementString("entidadFederal", (respuesta as Instructor).EstadoPersona);
            _escritorXML.WriteElementString("ciudad", (respuesta as Instructor).CiudadPersona);
            _escritorXML.WriteElementString("direccion", (respuesta as Instructor).DireccionPersona);
            _escritorXML.WriteElementString("telefonoLocal", (respuesta as Instructor).TelefonoLocalPersona);
            _escritorXML.WriteElementString("telefonoCelular", (respuesta as Instructor).TelefonoCelularPersona);
            _escritorXML.WriteElementString("email", (respuesta as Instructor).CorreoPersona);
            _escritorXML.WriteElementString("nombreContactoEmergencia", (respuesta as Instructor).NombreContactoEmergencia);
            _escritorXML.WriteElementString("telefonoContactoEmergencia", (respuesta as Instructor).TelefonoContactoEmergencia);
            //_escritorXML.WriteElementString("status", (lista as Instructor).Status);
            //_escritorXML.WriteElementString("horario", XmlConvert.ToString((lista as Instructor).Horario));
            _escritorXML.WriteEndElement();
            _escritorXML.WriteEndDocument();
            _escritorXML.Flush();
            _escritorXML.Close();

            XmlDocument retorno = new XmlDocument();

            retorno.Load("C:\\XmlInstructor.xml");

            return retorno;
        }

        [WebMethod]
        public bool ServicioInactivarInstructor(int id)
        {
            return FabricaComando.CrearComandoInactivarInstructor(FabricaEntidad.CrearInstructor(id)).Ejecutar();
        }


    }
}
