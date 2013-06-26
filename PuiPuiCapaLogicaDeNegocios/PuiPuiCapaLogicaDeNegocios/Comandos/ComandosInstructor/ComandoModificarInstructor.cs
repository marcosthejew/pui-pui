using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Excepciones;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosInstructor
{
    public class ComandoModificarInstructor : AComando<bool>
    {
        #region Atributos

        AEntidad _instructor;

        #endregion

        #region Constructor

        public ComandoModificarInstructor(AEntidad instructor)
        {
            _instructor = instructor;
        }

        #endregion

        #region Metodos

        public override bool Ejecutar()
        {
            bool _flag = false;
            try
            {
                _flag = FabricaSQLServerDAO.obtenerInstancia().CrearInstructorSQLServerDAO().Modificar(_instructor);
            }
            catch (ExcepcionInstructorConexionBD e)
            {
                throw new ExcepcionInstructorConexionBD("No se pudo actualizar el instructor: " + e.Message, e);
            }
            return _flag;
        }

        #endregion
    }
}