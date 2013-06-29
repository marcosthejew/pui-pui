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

        [WebMethod]
        public bool ServicioAgregarMusculo(string nombre, string descripcion)
        {
            AEntidad musculo;

            musculo = FabricaEntidad.CrearMusculo(nombre, descripcion);
            return FabricaComando.CrearComandoAgregarMusculo(musculo).Ejecutar();
        }

        [WebMethod]
        public string ServicioConsultarTodosLosMusculos() 
        {
            List<AEntidad> salida = FabricaComando.CrearConsultarTodosLosMusculos().Ejecutar();
           
            return FabricaComando.CrearComandoSerializarMusculo(salida).Ejecutar();
        }


        [WebMethod]
        public bool ServicioDesactivarMusculo(int idMusculo)
        {
            return FabricaComando.CrearDesactivarMusculos(FabricaEntidad.CrearMusculo(idMusculo)).Ejecutar();
        }

    }
}
