using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEvaluaciones;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEvaluacionInstructor
{
    public class ComandoDetalleEvaluacionInstructor : AComando<EvaluacionInstructor>
    {
        private EvaluacionInstructor EvaluacionInstruc;

        public ComandoDetalleEvaluacionInstructor(EvaluacionInstructor EvaluacionInstructor)
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
            EvaluacionInstruc = (EvaluacionInstructor)EvaluacionDao.ConsultarPorId(this.EvaluacionInstruc.idEvaluacion);            
            return (this.EvaluacionInstruc);
            
        }
    }
}