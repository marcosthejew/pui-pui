using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Comandos;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones;


namespace PuiPuiCapaLogicaDeNegocios.Servicios.FrontOffice
{
    public class FachadaInstructores : System.Web.Services.WebService
    {

        [WebMethod]
        public String ServicioComandoConsultarEvaluacionesInstructorTodos()
        {
            List<EvaluacionInstructor> listaevaluaciones = FabricaComandosEvaluacionInstructor.CrearComandoDetalleTodoEvaluacionInstructor().Ejecutar();
            String cadenaAEnviar = FabricaComandosEvaluacionInstructor.CrearComandoSerializarListaEvaluacionInstructor(listaevaluaciones).Ejecutar();
            return cadenaAEnviar;
        }

        [WebMethod]
        public String ServicioComandoConsultarEvaluacionesInstructorDetalle(int id_evaluacion_instructor)
        {

            List<EvaluacionInstructor> listaevaluaciones = new List<EvaluacionInstructor>();
            listaevaluaciones.Add(FabricaComandosEvaluacionInstructor.CrearComandoDetalleEvaluacionInstructor(id_evaluacion_instructor).Ejecutar());
            String cadenaAEnviar = FabricaComandosEvaluacionInstructor.CrearComandoSerializarListaEvaluacionInstructor(listaevaluaciones).Ejecutar();
            return cadenaAEnviar;
        }

        [WebMethod]
        public int ServicioComandoInsertarEvaluacionesInstructor(DateTime fecha, String observaciones, int status, int idcliente, int idinstructor)
        {

            EvaluacionInstructor evaluaciionInstructor = (EvaluacionInstructor)FabricaEntidad.
                CrearEvaluacionInstructor(0, fecha, observaciones,status ,idcliente, idinstructor);
            return FabricaComandosEvaluacionInstructor.CrearComandoInsertarEvaluacionInstructor(evaluaciionInstructor).Ejecutar();
        }


        [WebMethod]
        public bool ServicioComandoModificarEvaluacionesInstructor(int id,DateTime fecha, String observaciones, int status, int idcliente, int idinstructor)
        {

            EvaluacionInstructor evaluaciionInstructor = (EvaluacionInstructor)FabricaEntidad.
                CrearEvaluacionInstructor(id, fecha, observaciones, status, idcliente, idinstructor);
            return FabricaComandosEvaluacionInstructor.CrearComandoModificarEvaluacionInstructor(evaluaciionInstructor).Ejecutar();
        }
    }
}
