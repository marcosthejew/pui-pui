using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Excepciones;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosInstructor
{
    public class ComandoAgregarInstructor : AComando<bool>
    {
        #region Atributos

        AEntidad _instructor;
        bool _flag;

        #endregion

        #region Constructor

        public ComandoAgregarInstructor(AEntidad instructor)
        {
            _instructor = instructor;
        }

        #endregion

        #region Metodos

        public override bool Ejecutar()
        {
            try
            {
                if (FabricaSQLServerDAO.obtenerInstancia().CrearInstructorSQLServerDAO().ExisteInstructor(_instructor))
                {
                    _flag = false;
                }
                else
                {
                    _flag = FabricaSQLServerDAO.obtenerInstancia().CrearInstructorSQLServerDAO().Agregar(0, _instructor);
                }
            }
            catch (ExcepcionInstructorConexionBD e)
            {
                throw new ExcepcionInstructorConexionBD("No se pudo agregar el instructor: " + e.Message, e);
            }
            return _flag;
        }

        #endregion
    }
}