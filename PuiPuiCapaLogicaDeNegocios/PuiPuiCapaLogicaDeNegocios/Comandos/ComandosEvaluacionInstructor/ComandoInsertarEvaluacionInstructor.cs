using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEvaluaciones;


namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEvaluacionInstructor
{
    public class ComandoInsertarEvaluacionInstructor : AComando<int>
    {
        private EvaluacionInstructor _EvaluacionInstruc;

        public ComandoInsertarEvaluacionInstructor(EvaluacionInstructor _EvaluacionInstruc)
        {
            this._EvaluacionInstruc = _EvaluacionInstruc;
        }



        /// <summary>
        /// Ejecuta el comando.
        /// </summary>
        /// <returns></returns>
        public override int Ejecutar()
        {

            IEvaluacionInstructorDAO evaluacionDao = (IEvaluacionInstructorDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearEvaluacionInstructorSQLServerDAO();
            int result = evaluacionDao.Agregar(_EvaluacionInstruc);
            return result;

        }

    }
}