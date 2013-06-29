using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon
{
    public class ComandoSerializarListaSalon : AComando<string>
    {
        private List<Salon> _listaSalon;

        public ComandoSerializarListaSalon(List<Salon> listaSalon)
        {
            _listaSalon = listaSalon;
        }

        public override string Ejecutar()
        {
            string cadenaAEnviar = "<Salones>";
            foreach (Salon salon in _listaSalon)
            {
                cadenaAEnviar += salon.serializar();
            }
            cadenaAEnviar += "</Salones>";

            return cadenaAEnviar;
        }
    }
}