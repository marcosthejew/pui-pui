using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Excepciones;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEjercicio
{
    public class ComandoConsultarTodosEjercicio:AComando<List<AEntidad>>
    {
        public override List<AEntidad> Ejecutar()
        {
            List<AEntidad> ejercicios;
            
            try
            {
                ejercicios = FabricaSQLServerDAO.obtenerInstancia().CrearEjercicioSQLServerDAO().ConsultarTodos();
            }
            catch (ExcepcionEjercicioConexionBD e)
            {
                throw new ExcepcionEjercicioConexionBD("No se pudieron consultar los ejercicios: " + e.Message, e);
            }
            return ejercicios;
        }
    }
}