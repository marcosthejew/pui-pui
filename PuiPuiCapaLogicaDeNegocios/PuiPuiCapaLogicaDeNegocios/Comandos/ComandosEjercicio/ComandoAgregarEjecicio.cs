using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Excepciones;
namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEjercicio
{
    public class ComandoAgregarEjecicio: AComando<bool>
    {

        #region Atributos
        AEntidad _ejecicio;
        bool flag;
        #endregion

        #region Constructor
        public ComandoAgregarEjecicio(AEntidad ejercicio)
        {
            _ejecicio = ejercicio;
        }
        #endregion

        #region Metodo
        public override bool Ejecutar()
        {
            
            try
            {
                if (FabricaSQLServerDAO.obtenerInstancia().CrearEjercicioSQLServerDAO().ExisteEjercicio(_ejecicio))
                {
                    flag = false;
                }
                else
                {
                    flag = FabricaSQLServerDAO.obtenerInstancia().CrearEjercicioSQLServerDAO().Agregar(0,_ejecicio);
                }
            }
            catch (ExcepcionEjercicioConexionBD e)
            {
                throw new ExcepcionEjercicioConexionBD("No se pudo agregar el ejercicio: " + e.Message, e);
            }
            return flag;
        }
        #endregion
    }
}