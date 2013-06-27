using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosClase
{
    public class ComandoSerializarListaClase : AComando<string>
    {
        private List<Clase> _listaClase;

        public ComandoSerializarListaClase(List<Clase> listaClase)
        {
            _listaClase = listaClase;
        }

        public override string Ejecutar()
        {
            string cadenaAEnviar = "<Clases>";
            foreach (Clase salon in _listaClase)
            {
                cadenaAEnviar += salon.serializar();
            }
            cadenaAEnviar += "</Clases>";

            return cadenaAEnviar;
        }
    }
}