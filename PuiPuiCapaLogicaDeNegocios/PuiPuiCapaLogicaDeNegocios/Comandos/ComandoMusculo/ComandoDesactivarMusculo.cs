using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Excepciones;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandoMusculo
{
    public class ComandoDesactivarMusculo: AComando<bool>
    {
        private AEntidad _musculo;

        public ComandoDesactivarMusculo(AEntidad musculo)
        {
            _musculo = musculo;
        }

        public override bool Ejecutar()
        {
            bool flag = false;
           
            try
            {
                if ((FabricaSQLServerDAO.obtenerInstancia().CrearMusculoSQLServerDAO().ExisteEjercicioConMusculo((_musculo as Musculo).IdMusculo))!=true)
                    
                    {
                        flag = FabricaSQLServerDAO.obtenerInstancia().CrearMusculoSQLServerDAO().Inactivar((_musculo as Musculo).IdMusculo);                        
                    }
            }
            catch (ExcepcionMusculoConexionBD e)
            {
                throw new ExcepcionMusculoConexionBD("No se pudo eliminar el musculo: " + e.Message, e);
            }
            return flag;
        }
    }
}