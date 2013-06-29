using PuiPuiCapaLogicaDeNegocios.Bitacora;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon
{   
    /// <summary>
    /// Clase que contiene el comando serializar salon
    /// </summary>
    public class ComandoSerializarListaSalon : AComando<string>
    {
        private List<Salon> _listaSalon;
        /// <summary>
        /// constructor que recibe la lista de salones a modificarse
        /// </summary>
        /// <param name="listaSalon"></param>
        public ComandoSerializarListaSalon(List<Salon> listaSalon)
        {
            _listaSalon = listaSalon;
        }
        /// <summary>
        /// implementacion de la ejecucion del comando serializar lista salon que devuelve una lista de salones en formato XML
        /// </summary>
        /// <returns>listaSalon</returns>
        public override string Ejecutar()
        {
            string cadenaAEnviar = "<Salones>";
            foreach (Salon salon in _listaSalon)
            {
                cadenaAEnviar += salon.serializar();
            }
            cadenaAEnviar += "</Salones>";
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora("el usuario **** accedio al comando serializar lista salon");
            return cadenaAEnviar;
        }
    }
}