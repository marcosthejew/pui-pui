using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Excepciones;
namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEjercicio
{
    public class ComandoModificarEjercicio:AComando<bool>
    {
        AEntidad _ejercicio;
        public ComandoModificarEjercicio(AEntidad ejercicio)
        {
            _ejercicio = ejercicio;
        }
        public override bool Ejecutar()
        {
           
            bool flag = false;
            try
            {
                flag = FabricaSQLServerDAO.obtenerInstancia().CrearEjercicioSQLServerDAO().Modificar(_ejercicio);
                
            }
            catch (ExcepcionMusculoConexionBD e)
            {
                throw new ExcepcionMusculoConexionBD("No se pudo actualizar el ejercicio: " + e.Message, e);
            }
            catch (ExcepcionEjercicioConexionBD e)
            {
                throw new ExcepcionEjercicioConexionBD("No se pudo actualizar el ejercicio: " + e.Message, e);
            }
            return flag;
        }
    }
}