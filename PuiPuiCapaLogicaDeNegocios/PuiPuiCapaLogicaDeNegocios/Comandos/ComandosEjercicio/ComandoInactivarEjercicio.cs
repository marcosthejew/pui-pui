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

        public override bool Ejecutar(AEntidad ejercicio)
        {
            bool flag=false;
            try
            {
                flag = FabricaSQLServerDAO.obtenerInstancia().CrearEjercicioSQLServerDAO().Inactivar(ejercicio.Id);

            }
            catch (ExcepcionEjercicioConexionBD e)
            {
                throw new ExcepcionEjercicioConexionBD("No se pudo eliminar el ejercicio: " + e.Message, e);
            }
            return flag;
        }
    }
}