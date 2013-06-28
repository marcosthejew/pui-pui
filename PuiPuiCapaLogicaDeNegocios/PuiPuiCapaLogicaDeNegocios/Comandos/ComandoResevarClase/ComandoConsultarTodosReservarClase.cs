using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Excepciones;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandoResevarClase
{
    public class ComandoConsultarTodosReservarClase : AComando<List<AEntidad>>
    {
        public override List<AEntidad> Ejecutar()
        {
            List<AEntidad> eventos;

            try
            {
                eventos = FabricaSQLServerDAO.obtenerInstancia().CrearReservacionClaseSQLServerDAO().ConsultarTodos();
            }
            catch (ExcepcionReservarClaseConexionBD e)
            {
                throw new ExcepcionReservarClaseConexionBD("No se pudieron consultar las Reservaciones: " + e.Message, e);
            }
            return eventos;
        }
    }
}