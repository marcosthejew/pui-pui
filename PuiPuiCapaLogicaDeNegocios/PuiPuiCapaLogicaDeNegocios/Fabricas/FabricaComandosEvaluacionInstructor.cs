using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Comandos;
using PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEvaluacionInstructor;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones;
using PuiPuiCapaLogicaDeNegocios.Entidades;

namespace PuiPuiCapaLogicaDeNegocios.Fabricas
{
    public class FabricaComandosEvaluacionInstructor
    {

        public static AComando<List<EvaluacionInstructor>> CrearComandoDetalleTodoEvaluacionInstructor()
        {
            return new ComandoDetalleTodoEvaluacionInstructor();
        }

        public static AComando<EvaluacionInstructor>  CrearComandoDetalleEvaluacionInstructor(int id)
        {
            return new ComandoDetalleEvaluacionInstructor(id);
        }

        public static AComando<int> CrearComandoInsertarEvaluacionInstructor(EvaluacionInstructor evaluacion)
        {
            return new ComandoInsertarEvaluacionInstructor(evaluacion);
        }

        public static AComando<bool> CrearComandoModificarEvaluacionInstructor(EvaluacionInstructor evaluacion)
        {
            return new ComandoModificarEvaluacionInstructor(evaluacion);
        }

    }
}