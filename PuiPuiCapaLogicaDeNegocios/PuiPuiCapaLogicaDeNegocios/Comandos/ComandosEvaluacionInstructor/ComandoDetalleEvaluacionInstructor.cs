using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEvaluaciones;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEvaluacionInstructor
{
    public class ComandoDetalleEvaluacionInstructor : AComando<EvaluacionInstructor>
    {
        private EvaluacionInstructor _EvaluacionInstruc;

        public ComandoDetalleEvaluacionInstructor(EvaluacionInstructor EvaluacionInstructor)
        {
            this._EvaluacionInstruc = EvaluacionInstructor;
        }

        public ComandoDetalleEvaluacionInstructor(int id)
        {
            this._EvaluacionInstruc = (EvaluacionInstructor)FabricaEntidad.CrearEvaluacionInstructor(id);
        }


        /// <summary>
        /// Ejecuta el comando.
        /// </summary>
        /// <returns></returns>
        public override EvaluacionInstructor Ejecutar()
        {

            IEvaluacionInstructorDAO evaluacionDao = (IEvaluacionInstructorDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearEvaluacionInstructorSQLServerDAO();
            _EvaluacionInstruc = (EvaluacionInstructor)evaluacionDao.ConsultarPorId(_EvaluacionInstruc.Id);
            return (_EvaluacionInstruc);

            
        }
    }
}