using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones;


namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEvaluacionInstructor
{
    public class ComandoDetalleTodoEvaluacionInstructor : AComando<EvaluacionInstructor>
    
        {
        private List<AEntidad> EvaluacionInstruc;

        public ComandoDetalleTodoEvaluacionInstructor(List<AEntidad> EvaluacionInstructor)
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
            EvaluacionInstruc = EvaluacionDao.ConsultarTodos();            
            throw new NotImplementedException();
            //return (this.EvaluacionInstruc);
            
        }
    }
}
