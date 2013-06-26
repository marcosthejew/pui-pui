using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Excepciones;
using PuiPuiCapaLogicaDeNegocios.Fabricas;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandoMusculo
{
    public class ComandoConsultarTodosLosMusculos: AComando<List<AEntidad>>
    {
        
        public override List<AEntidad> Ejecutar()
        {
            List<AEntidad> listaConsulta;
            try
            {
                listaConsulta = FabricaSQLServerDAO.obtenerInstancia().CrearMusculoSQLServerDAO().ConsultarTodos();
            }
            catch (ExcepcionMusculoConexionBD e)
            {
                throw new ExcepcionMusculoConexionBD("No se pudo consultar los musculos: " + e.Message, e);
            }
            return listaConsulta;
        }        
        
    }
}