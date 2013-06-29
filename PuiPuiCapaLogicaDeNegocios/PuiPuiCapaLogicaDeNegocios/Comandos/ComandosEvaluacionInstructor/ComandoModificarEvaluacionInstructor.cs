using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEvaluaciones;


namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEvaluacionInstructor
{
    public class ComandoModificarEvaluacionInstructor: AComando<bool>
    
        {
        private EvaluacionInstructor _EvaluacionInstruc;

        public ComandoModificarEvaluacionInstructor(EvaluacionInstructor _EvaluacionInstruc)
        {
            this._EvaluacionInstruc = _EvaluacionInstruc;
        }



        /// <summary>
        /// Ejecuta el comando.
        /// </summary>
        /// <returns></returns>
        public override bool Ejecutar()
        {

            IEvaluacionInstructorDAO evaluacionDao = (IEvaluacionInstructorDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearEvaluacionInstructorSQLServerDAO();
            bool result = evaluacionDao.Modificar(_EvaluacionInstruc.Id,_EvaluacionInstruc);
            return result;
            
        }
    }
}
