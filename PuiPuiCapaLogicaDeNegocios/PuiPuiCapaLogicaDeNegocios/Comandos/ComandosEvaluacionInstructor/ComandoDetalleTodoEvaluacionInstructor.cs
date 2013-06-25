using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEvaluaciones;


namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEvaluacionInstructor
{
    public class ComandoDetalleTodoEvaluacionInstructor : AComando<List<EvaluacionInstructor>>
        
        
    {
        public ComandoDetalleTodoEvaluacionInstructor()
        {
            
        }

        /// <summary>
        /// Ejecuta el comando.
        /// </summary>
        /// <returns></returns>
        public override List<EvaluacionInstructor> Ejecutar()
        {

            DAOs.IDAO EvaluacionDao;
            EvaluacionDao = new DAOs.DAOsEvaluaciones.EvaluacionInstructorSQLServerDAO();
            List<EvaluacionInstructor> EvaluacionInstruc = (EvaluacionDao.ConsultarTodos()).Cast<EvaluacionInstructor>().ToList();                        
            return (EvaluacionInstruc);
            
        }
    }
}
