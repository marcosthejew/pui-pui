using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEvaluacionInstructor
{
    public class ComandoSerializarListaEvaluacionInstructor : AComando<string>
    {
        private List<EvaluacionInstructor> _listaEvaluaiconInstructor;

        public ComandoSerializarListaEvaluacionInstructor(List<EvaluacionInstructor> listaEvaluaiconInstructor)
        {
            _listaEvaluaiconInstructor = listaEvaluaiconInstructor;
        }

        public override string Ejecutar()
        {
            string cadenaAEnviar = "<EvaluacionInstructor>";
            foreach (EvaluacionInstructor evalinst in _listaEvaluaiconInstructor)
            {
                cadenaAEnviar += evalinst.serializar();
            }
            cadenaAEnviar += "</EvaluacionInstructor>";

            return cadenaAEnviar;
        }

    }
}
