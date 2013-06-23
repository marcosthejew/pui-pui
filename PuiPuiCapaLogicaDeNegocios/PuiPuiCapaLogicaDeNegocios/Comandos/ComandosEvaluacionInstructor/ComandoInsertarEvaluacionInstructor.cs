using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones;


namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEvaluacionInstructor
{
    public class ComandoInsertarEvaluacionInstructor : AComando<EvaluacionInstructor>
    {
        private EvaluacionInstructor EvaluacionInstruc;

        public ComandoInsertarEvaluacionInstructor(EvaluacionInstructor EvaluacionInstructor)
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
            int result = EvaluacionDao.Agregar(this.EvaluacionInstruc);
            if (result == 0)
                this.EvaluacionInstruc = (EvaluacionInstructor)Fabricas.FabricaEntidad.CrearEvaluacionInstructor();
            return (this.EvaluacionInstruc);

        }

    }
}