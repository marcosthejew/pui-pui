using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEvaluacionInstructor
{
    public class ComandoModificarEvaluacionInstructor: AComando<EvaluacionInstructor>
    
        {
        private EvaluacionInstructor EvaluacionInstruc;

        public ComandoModificarEvaluacionInstructor(EvaluacionInstructor EvaluacionInstructor)
        {
            this.EvaluacionInstruc = EvaluacionInstructor;
        }



        /// <summary>
        /// Ejecuta el comando.
        /// </summary>
        /// <returns></returns>
        public override EvaluacionInstructor Ejecutar()
        {

            DAOs.IDAO EvaluacionDao;
            EvaluacionDao = new DAOs.DAOsEvaluaciones.EvaluacionInstructorSQLServerDAO();
            bool result = EvaluacionDao.Modificar(this.EvaluacionInstruc.idEvaluacion,this.EvaluacionInstruc);
            if (result)
                this.EvaluacionInstruc = (EvaluacionInstructor)Fabricas.FabricaEntidad.CrearEvaluacionInstructor();
            return (this.EvaluacionInstruc); ;
            
        }
    }
}
