using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;

namespace PuiPuiCapaLogicaDeNegocios.Servicios.BackOffice
{
    public class FachadaClases : System.Web.Services.WebService
    {
        [WebMethod]
        public string ServicioConsultarSalonesTodos()
        {

            List<Clase> listaClases = FabricaComandosClase.CrearComandoConsultarTodasClases().Ejecutar();
            String cadenaAEnviar = FabricaComandosClase.CrearComandoSerializarListaClase(listaClases).Ejecutar();
            return cadenaAEnviar;


        }


        [WebMethod]
        public int ServicioAgregarClase(string nombre, int idClase,string descripcion, int status)
        {
            Clase clase = (Clase)FabricaEntidad.CrearClase(nombre, idClase, descripcion, status);
            return FabricaComandosClase.CrearComandoAgregarClase(clase).Ejecutar();
        }
        [WebMethod]
        public bool ServicioInactivarClase(int id)
        {
            return FabricaComandosClase.CrearComandoInactivarClase(id).Ejecutar();
        }

        [WebMethod]
        public bool ServicioModificarClase(int id, string nombre, int idClase, string descripcion, int status)
        {
           Clase clase = (Clase)FabricaEntidad.CrearClase(nombre, idClase, descripcion, status);
            return FabricaComandosClase.CrearComandoModificarClase(id, clase).Ejecutar();
        }

        [WebMethod]
        public string ServicioComandoNombreClase(String nombre)
        {
            List<Clase> listaClases = FabricaComandosClase.CrearComandoBusquedaNombreClase(nombre).Ejecutar();
            String cadenaAEnviar = FabricaComandosClase.CrearComandoSerializarListaClase(listaClases).Ejecutar();
            return cadenaAEnviar;
        }
        [WebMethod]
        public string ServicioComandoBusquedaStatusClases(int status)
        {
            List<Clase> listaClases = FabricaComandosClase.CrearComandoBusquedaSatusClase(status).Ejecutar();
            string cadenaAEnviar = FabricaComandosClase.CrearComandoSerializarListaClase(listaClases).Ejecutar();
            return cadenaAEnviar;
        }
    }
}
