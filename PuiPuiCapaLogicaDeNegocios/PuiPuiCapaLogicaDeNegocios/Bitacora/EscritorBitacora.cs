using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.DAOs;
using PuiPuiCapaLogicaDeNegocios.Fabricas;

namespace PuiPuiCapaLogicaDeNegocios.Bitacora
{
    /// <summary>
    /// Clase Singleton que se encarga de escribir en la bitacora.
    /// </summary>
    public class EscritorBitacora
    {
        private readonly ILog _log;
        private static EscritorBitacora _instancia;

        /// <summary>
        /// Instancia la clase Singleton EscritorBitacora.
        /// </summary>
        private EscritorBitacora()
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo(
                    ConfigurationManager.AppSettings["Log4netConfigPath"]));
            _log = LogManager.GetLogger("PuiPuiLogger");
            _instancia = this;
        }

        /// <summary>
        /// Metodo para obtener la instancia Singleton.
        /// </summary>
        /// <returns></returns>
        public static EscritorBitacora obtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new EscritorBitacora();
            }
            return _instancia;
        }

        /// <summary>
        /// Escribe un mensaje en el archivo de bitacora especificado en el 
        /// archivo Log4netConfig.xml en el nivel de DEBUG.
        /// </summary>
        /// <param name="mensaje">
        /// El mensaje que se desea escribir.
        /// </param>
        public void escribirDebugEnBitacora(string mensaje)
        {
            _log.Debug(mensaje);
        }

        /// <summary>
        /// Escribe un mensaje en el archivo de bitacora especificado en el 
        /// archivo Log4netConfig.xml en el nivel de INFO.
        /// </summary>
        /// <param name="mensaje">
        /// El mensaje que se desea escribir.
        /// </param>
        public void escribirInfoEnBitacora(string mensaje)
        {
            _log.Info(mensaje);
        }

        /// <summary>
        /// Escribe un mensaje en el archivo de bitacora especificado en el 
        /// archivo Log4netConfig.xml en el nivel de ERROR.
        /// </summary>
        /// <param name="mensaje">
        /// El mensaje que se desea escribir.
        /// </param>
        public void escribirErrorEnBitacora(string mensaje)
        {
            _log.Error(mensaje);
        }
    }
}