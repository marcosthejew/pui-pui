using PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Xml;
using System.Xml.Serialization;
using System.Reflection;

namespace PuiPuiCapaLogicaDeNegocios.Servicios.BackOffice
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    /*[WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. */
     [System.Web.Script.Services.ScriptService]
    public class FachadaSalonBackOffice : System.Web.Services.WebService
    { 
        [WebMethod]
        public string ServicioConsultarSalonesTodos()
        {
           
            List <Salon> listaSalones= FabricaComandosSalon.CrearComandoConsultarTodosSalones().Ejecutar();
            String cadenaAEnviar =FabricaComandosSalon.CrearComandoSerializarListaSalon(listaSalones).Ejecutar();
            return cadenaAEnviar;

         
        }
    

        [WebMethod]
        public int ServicioAgregarSalon(string codigo, string ubicacion, int status, int capacidad)
        {
            Salon salon = (Salon) FabricaEntidad.CrearSalon(codigo,capacidad,ubicacion,status);
            return FabricaComandosSalon.CrearComandoAgregarSalon(salon).Ejecutar();
        }
          [WebMethod]
        public bool ServicioInactivarSalon(int id)
        {
            return FabricaComandosSalon.CrearComandoInactivarSalon(id).Ejecutar();
        }
        
        [WebMethod]
        public bool ServicioModificarSalon(int id, String codigo,string ubicacion, int status,int capacidad)
        {
            Salon salon = (Salon)FabricaEntidad.CrearSalon(codigo,capacidad,ubicacion,status);
            return FabricaComandosSalon.CrearComandoModificarSalon(id,salon).Ejecutar();
        }

        [WebMethod]
        public string ServicioComandoUbicacionSalones(String ubicacion)
        {
            List<Salon> listaSalones = FabricaComandosSalon.CrearComandoBusquedaUbicacionSalones(ubicacion).Ejecutar();
            String cadenaAEnviar = FabricaComandosSalon.CrearComandoSerializarListaSalon(listaSalones).Ejecutar();
            return cadenaAEnviar;
        }


        [WebMethod]
        public string ServicioComandoBusquedaCapacidadMayorSalon(int capacidad)
        {
            List<Salon> listaSalones = FabricaComandosSalon.CrearComandoBusquedaCapacidadMayorSalon(capacidad).Ejecutar();
            string cadenaAEnviar = FabricaComandosSalon.CrearComandoSerializarListaSalon(listaSalones).Ejecutar();
            return cadenaAEnviar;
        }
         
        [WebMethod]
        public string ServicioComandoBusquedaCapacidadMenorSalon(int capacidad)
        {
            List<Salon> listaSalones = FabricaComandosSalon.CrearComandoBusquedaCapacidadMenorSalon(capacidad).Ejecutar();
            string cadenaAEnviar = FabricaComandosSalon.CrearComandoSerializarListaSalon(listaSalones).Ejecutar();
            return cadenaAEnviar;
        }
        [WebMethod]
        public string ServicioComandoBusquedaStatusSalon(int status)
        {
            List<Salon> listaSalones = FabricaComandosSalon.CrearComandoBusquedaStatusSalon(status).Ejecutar();
            string cadenaAEnviar = FabricaComandosSalon.CrearComandoSerializarListaSalon(listaSalones).Ejecutar();
            return cadenaAEnviar;
        }
    }
}
