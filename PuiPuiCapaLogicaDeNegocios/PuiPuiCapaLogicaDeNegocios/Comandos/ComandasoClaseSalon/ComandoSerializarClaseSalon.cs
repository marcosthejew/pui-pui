using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandasoClaseSalon
{
    public class ComandoSerializarClaseSalon:AComando<string>
    {
         private List<ClaseSalon> _listaClase;

         public ComandoSerializarClaseSalon(List<ClaseSalon> listaClase)
        {
            _listaClase = listaClase;
        }

        public override string Ejecutar()
        {
            string cadenaAEnviar = "<ClasesSalon>";
            foreach (ClaseSalon salon in _listaClase)
            {
                cadenaAEnviar += salon.serializar();
            }
            cadenaAEnviar += "</ClasesSalon>";

            return cadenaAEnviar;
        }
    }
}