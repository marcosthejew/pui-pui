using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Excepciones;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandoMusculo
{
    public class ComandoAgregarMusculo: AComando<bool>
    {

        private AEntidad _musculo;

        public ComandoAgregarMusculo(AEntidad musculo) 
        {
            _musculo = musculo;
        }

        public override bool Ejecutar()
        {

            bool flag = false;
            try
            {
                if (FabricaSQLServerDAO.obtenerInstancia().CrearMusculoSQLServerDAO().ExisteMusculo((_musculo as Musculo).NombreMusculo))
                {
                    flag = false;
                }else{
                    flag = FabricaSQLServerDAO.obtenerInstancia().CrearMusculoSQLServerDAO().Agregar(0,_musculo);
                }
            }
            catch (ExcepcionMusculoConexionBD e)
            {
                throw new ExcepcionMusculoConexionBD("No se pudo agregar el musculo: " + e.Message, e);
            }
            return flag;
        }


    }
}