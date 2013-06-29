using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.LogicaMusculo;

namespace PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio
{
    public class ComandoDesactivarMusculos:AComando<bool>
    {
        private int _idMusculo;

        public ComandoDesactivarMusculos(int idMusculo)
        {
            _idMusculo = idMusculo;
        }

        public override bool Ejecutar()
        {
            return new FachadaMusculos().ServicioDesactivarMusculo(_idMusculo);
        }
    }
}