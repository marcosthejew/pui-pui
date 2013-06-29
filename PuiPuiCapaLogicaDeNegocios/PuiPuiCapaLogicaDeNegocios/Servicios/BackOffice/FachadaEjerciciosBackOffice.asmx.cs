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
        public string ServicioConsultarEjecicioId(int id,string nombre)
        {
            AEntidad ejercicio = FabricaEntidad.CrearEjercicio(id,nombre);
            AEntidad respuesta;
            respuesta= FabricaComando.CrearComandoConsultarPorIdEjercicio(ejercicio).Ejecutar();
            return FabricaComando.CrearComandoSerializarEjercicio(respuesta).Ejecutar();

        }

        [WebMethod]
        public string ServicioConsultarEjercicioTodos()
        {
            List<AEntidad> respuesta = FabricaComando.CrearComandoConsultarEjerciciosTodos().Ejecutar();

            return FabricaComando.CrearComandoSerializarEjercicio(respuesta).Ejecutar();
        }

        [WebMethod]
        public bool ServicioInactivarEjercicio(int id,string nombre)
        {
            return FabricaComando.CrearComandoInactivarEjercicio(FabricaEntidad.CrearEjercicio(id,nombre)).Ejecutar();
        }


        [WebMethod]
        public bool ServicioModificarEjercicio(string nombreEjercicio, string descripcionEjercicio,string nombreMusculo)
        {
            AEntidad ejercicio=FabricaEntidad.CrearEjercicio(0,nombreEjercicio,descripcionEjercicio,(FabricaEntidad.CrearMusculo(0,nombreMusculo)as Musculo));
            return FabricaComando.CrearComandoModificarEjercicio(ejercicio).Ejecutar();
        }

    }
}
