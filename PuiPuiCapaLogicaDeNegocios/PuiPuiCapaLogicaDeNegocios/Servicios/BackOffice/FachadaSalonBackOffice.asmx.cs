using PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PuiPuiCapaLogicaDeNegocios.Servicios.BackOffice
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    /*[WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]*/
    public class FachadaSalonBackOffice : System.Web.Services.WebService
    {

        [WebMethod]
        public int ServicioAgregarSalon(string codigo, string ubicacion, int status, int capacidad)
        {

            Salon salon = (Salon) FabricaEntidad.CrearSalon(codigo,capacidad,ubicacion,status);
            return FabricaComandosSalon.CrearComandoAgregarSalon(salon).Ejecutar();
        }
    }
}
