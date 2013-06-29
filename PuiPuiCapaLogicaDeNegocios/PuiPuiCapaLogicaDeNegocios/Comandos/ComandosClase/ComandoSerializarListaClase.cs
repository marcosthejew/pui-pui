using PuiPuiCapaLogicaDeNegocios.Bitacora;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosClase
{
    public class ComandoSerializarListaClase : AComando<string>
    {
        /// <summary>
        ///comando que sirve para serializar listas de objetos clase
        /// </summary>
        private List<Clase> _listaClase;
        /// <summary>
        /// constructor de la clase que recibe la lista a
        /// modificar
        /// </summary>
        /// <param name="listaClase"></param>
        public ComandoSerializarListaClase(List<Clase> listaClase)
        {
            _listaClase = listaClase;
        }

        /// <summary>
        /// ejecuta el comando y devuelve una lista de clases serializada
        /// </summary>
        /// <returns></returns>
        public override string Ejecutar()
        {
            string cadenaAEnviar = "<Clases>";
            foreach (Clase salon in _listaClase)
            {
                cadenaAEnviar += salon.serializar();
            }
            cadenaAEnviar += "</Clases>";
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora("el usuario **** accedio al comando serialziar lista clase");
            return cadenaAEnviar;
        }
    }
}