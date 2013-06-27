using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Excepciones;
namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEjercicio
{
    public class ComandoInactivarEjercicio:AComando<bool>
    {
        AEntidad _ejercicio;
        public ComandoInactivarEjercicio(AEntidad ejercicio)
        {
            _ejercicio = ejercicio;
        }
        public override bool Ejecutar()
        {
            bool flag=false;
            try
            {
                flag = FabricaSQLServerDAO.obtenerInstancia().CrearEjercicioSQLServerDAO().Inactivar(_ejercicio.Id);

            }
            catch (ExcepcionEjercicioConexionBD e)
            {
                throw new ExcepcionEjercicioConexionBD("No se pudo eliminar el ejercicio: " + e.Message, e);
            }
            return flag;
        }
    }
}