using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Entidades.EHorario;
using PuiPuiCapaLogicaDeNegocios.Entidades.EPersonas;

namespace PuiPuiCapaLogicaDeNegocios.Servicios.BackOffice
{
    /// <summary>
    /// Summary description for FachadaClaseSalonBackOffice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FachadaClaseSalonBackOffice : System.Web.Services.WebService
    {

        [WebMethod]
        public string ServicioConsultarClaseSalonTodos()
        {
            List<ClaseSalon> listaClaseSalon = FabricaComandoClaseSalon.CrearComandoConsultarClaseSalonTodos().Ejecutar();
            string cadenaEnviar = FabricaComandoClaseSalon.CrearComandoSerializar(listaClaseSalon).Ejecutar();
            return cadenaEnviar;
        }
        [WebMethod]
        public string ServicioConsultarPorClase( string clase)
        {
            List<ClaseSalon> listaClaseSalon = FabricaComandoClaseSalon.CrearComandoBusquedaClase(clase).Ejecutar();
            string cadenaEnviar = FabricaComandoClaseSalon.CrearComandoSerializar(listaClaseSalon).Ejecutar();
            return cadenaEnviar;
        }
        [WebMethod]
        public string ServicioConsultarPorSalon(string salon)
        {
            List<ClaseSalon> listaClaseSalon = FabricaComandoClaseSalon.CrearComandoBusquedaSalon(salon).Ejecutar();
            string cadenaEnviar = FabricaComandoClaseSalon.CrearComandoSerializar(listaClaseSalon).Ejecutar();
            return cadenaEnviar;
        }
        [WebMethod]
        public string ServicioConsultarPorInstructor(string instructor)
        {
            List<ClaseSalon> listaClaseSalon = FabricaComandoClaseSalon.CrearComandoBusquedaInstructor(instructor).Ejecutar();
            string cadenaEnviar = FabricaComandoClaseSalon.CrearComandoSerializar(listaClaseSalon).Ejecutar();
            return cadenaEnviar;
        }

          [WebMethod]
        public int ServicioInsertarClaseSalon(int id,int id_clase,int id_salon,int id_instructor,int id_horario,int status)
        {
              Salon idSalon=(Salon)FabricaEntidad.CrearSalon();
              idSalon.Id=id_salon;
              Clase idClase=(Clase)FabricaEntidad.CrearClase();
              idClase.Id=id_clase;
              Instructor idInstructor=(Instructor)FabricaEntidad.CrearInstructor();
              idInstructor.Id=id_instructor;
              Horario idHorario=(Horario)FabricaEntidad.CrearHorario();
              //ClaseSalon insertarClaseSalon=(ClaseSalon)FabricaEntidad.CrearClaseSalon(id,idSalon,idClase,idInstructor,status);
             // int insertarSalon = FabricaComandoClaseSalon.CrearComandoInsertarClaseSalon(insertarClaseSalon).Ejecutar();
              //return insertarSalon;
              return 0;
        }

    }
}
