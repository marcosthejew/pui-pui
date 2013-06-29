using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Comandos;
using PuiPuiCapaLogicaDeNegocios.Entidades.EPersonas;

namespace PuiPuiCapaLogicaDeNegocios.Servicios.BackOffice
{
    /// <summary>
    /// Descripción breve de FachadaInstructor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class FachadaInstructor : System.Web.Services.WebService
    {


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
