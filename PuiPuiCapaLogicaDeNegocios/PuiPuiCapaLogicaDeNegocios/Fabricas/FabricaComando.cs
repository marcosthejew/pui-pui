using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Comandos;
using PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEjercicio;

namespace PuiPuiCapaLogicaDeNegocios.Fabricas
{
    /// <summary>
    /// Clase que instancia Comandos especificos casteados a la clase abstracta
    /// AComando.
    /// </summary>
    public class FabricaComando
    {
        /// <summary>
        /// Devuelve una instancia del comando ComandoHolaMundo.
        /// </summary>
        /// <returns></returns>
        public static AComando<string> CrearComandoHolaMundo()
        {
            return new ComandoHolaMundo();
        }

        #region Ejercicios

        public static AComando<bool> CrearComandoAgregarEjercicio(AEntidad ejercicio)
        {
            return new ComandoAgregarEjecicio(ejercicio);

        }

        public static AComando<AEntidad> CrearComandoConsultarPorIdEjercicio(AEntidad ejercicio)
        {
            return new ComandoConsultarPorIdEjercicio(ejercicio);
        }

        public static AComando<List<AEntidad>> CrearComandoConsultarEjerciciosTodos()
        {
            return new ComandoConsultarTodosEjercicio();
        }

        public static AComando<bool> CrearComandoInactivarEjercicio(AEntidad ejercicio)
        {
            return new ComandoInactivarEjercicio(ejercicio);
        }

        public static AComando<bool> CrearComandoModificarEjercicio(AEntidad ejercicio)
        {
            return new ComandoModificarEjercicio(ejercicio);
        }
        #endregion
    }
}