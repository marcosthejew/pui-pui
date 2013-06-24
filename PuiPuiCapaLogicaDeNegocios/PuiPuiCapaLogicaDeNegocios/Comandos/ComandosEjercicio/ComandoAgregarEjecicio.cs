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

        bool flag;
        #endregion
        public override bool Ejecutar(AEntidad ejercicio)
        {
            
            try
            {
                if (FabricaSQLServerDAO.obtenerInstancia().CrearEjercicioSQLServerDAO().ExisteEjercicio(ejercicio))
                {
                    flag = false;
                }
                else
                {
                    int valor = FabricaSQLServerDAO.obtenerInstancia().CrearEjercicioSQLServerDAO().Agregar(ejercicio);
                    if(valor==1){
                        flag=true;
                    }else
                    {
                        flag=false;
                    }
                }
            }
            catch (ExcepcionEjercicioConexionBD e)
            {
                throw new ExcepcionEjercicioConexionBD("No se pudo agregar el ejercicio: " + e.Message, e);
            }
            return flag;
        }

    }
}