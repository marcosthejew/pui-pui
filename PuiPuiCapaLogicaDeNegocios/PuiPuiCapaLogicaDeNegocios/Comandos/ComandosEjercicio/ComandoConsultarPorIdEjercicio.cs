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
        AEntidad _ejercicio;

        public ComandoConsultarPorIdEjercicio(AEntidad ejercicio)
        {
            _ejercicio = ejercicio;
        }
        public override AEntidad Ejecutar()
        {
            
            try
            {
                _ejercicio = FabricaSQLServerDAO.obtenerInstancia().CrearEjercicioSQLServerDAO().ConsultarPorId(_ejercicio.Id);
            }
            catch (ExcepcionEjercicioConexionBD e)
            {
                throw new ExcepcionEjercicioConexionBD("No se pudo consultar el ejercicio: " + e.Message, e);
            }
            return _ejercicio;
        }
    }
}