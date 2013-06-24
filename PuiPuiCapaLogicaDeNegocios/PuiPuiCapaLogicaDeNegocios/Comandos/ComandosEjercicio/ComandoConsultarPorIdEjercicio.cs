using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Excepciones;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEjercicio
{
    public class ComandoConsultarPorIdEjercicio: AComando<AEntidad>
    {

        public override AEntidad Ejecutar(AEntidad ejercicio)
        {
            
            
            try
            {
                ejercicio = FabricaSQLServerDAO.obtenerInstancia().CrearEjercicioSQLServerDAO().ConsultarPorId(ejercicio.Id);
            }
            catch (ExcepcionEjercicioConexionBD e)
            {
                throw new ExcepcionEjercicioConexionBD("No se pudo consultar el ejercicio: " + e.Message, e);
            }
            return ejercicio;
        }
    }
}