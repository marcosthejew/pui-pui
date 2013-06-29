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
        public string ServicioConsultarTodosInstructor()
        {
            List<AEntidad> _respuesta = FabricaComando.CrearComandoConsultarTodosInstructor().Ejecutar();

            return FabricaComando.CrearComandoSerializarInstructor(_respuesta).Ejecutar();
        }

        [WebMethod]
        public string ServicioConsultarPorIdInstructor(int id)
        {
            AEntidad _instructor = FabricaEntidad.CrearInstructor(id);
            AEntidad _respuesta;
            _respuesta = FabricaComando.CrearComandoConsultarPorIdInstructor(_instructor).Ejecutar();
            return FabricaComando.CrearComandoSerializarInstructor(_respuesta).Ejecutar();
        }

        [WebMethod]
        public bool ServicioInactivarInstructor(int id)
        {
            return FabricaComando.CrearComandoInactivarInstructor(FabricaEntidad.CrearInstructor(id)).Ejecutar();
        }


    }
}
