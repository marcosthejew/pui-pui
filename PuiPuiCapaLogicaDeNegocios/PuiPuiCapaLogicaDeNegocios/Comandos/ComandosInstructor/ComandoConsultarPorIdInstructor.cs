using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Excepciones;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosInstructor
{
    public class ComandoConsultarPorIdInstructor : AComando<AEntidad>
    {
        #region Atributos

        AEntidad _instructor;

        #endregion

        #region Constructor

        public ComandoConsultarPorIdInstructor(AEntidad instructor)
        {
            _instructor = instructor;
        }

        #endregion

        #region Metodos

        public override AEntidad Ejecutar()
        {
            try
            {
                _instructor = FabricaSQLServerDAO.obtenerInstancia().CrearInstructorSQLServerDAO().ConsultarPorId(_instructor.Id);
            }
            catch (ExcepcionInstructorConexionBD e)
            {
                throw new ExcepcionInstructorConexionBD("No se pudo consultar el instructor: " + e.Message, e);
            }
            return _instructor;
        }

        #endregion
    }
}