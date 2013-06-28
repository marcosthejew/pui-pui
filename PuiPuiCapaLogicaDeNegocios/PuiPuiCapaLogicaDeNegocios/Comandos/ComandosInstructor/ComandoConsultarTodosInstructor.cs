using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Excepciones;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosInstructor
{
    public class ComandoConsultarTodosInstructor : AComando<List<AEntidad>>
    {
        #region Atributos

        List<AEntidad> instructores;

        #endregion

        #region Metodos

        public override List<AEntidad> Ejecutar()
        {
            try
            {
                instructores = FabricaSQLServerDAO.obtenerInstancia().CrearInstructorSQLServerDAO().ConsultarTodos();
            }
            catch (ExcepcionInstructorConexionBD e)
            {
                throw new ExcepcionInstructorConexionBD("No se pudieron consultar los instructores: " + e.Message, e);
            }
            return instructores;
        }

        #endregion
    }
}