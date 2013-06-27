using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Comandos;
using PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEjercicio;
using PuiPuiCapaLogicaDeNegocios.Comandos.ComandosInstructor;
using PuiPuiCapaLogicaDeNegocios.Comandos.ComandoResevarClase;
using PuiPuiCapaLogicaDeNegocios.Comandos.ComandoMusculo;
using System.IO;

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

        #region Ejercicio

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

        #region Musculo

        public static AComando<bool> CrearComandoAgregarMusculo(AEntidad musculo)
        {
            return new ComandoAgregarMusculo(musculo);
        }

        public static AComando<List<AEntidad>> CrearConsultarTodosLosMusculos()
        {
            return new ComandoConsultarTodosLosMusculos();
        }

        public static AComando<bool> CrearDesactivarMusculos(AEntidad musculo)
        {
            return new ComandoDesactivarMusculo(musculo);
        }
        #endregion 

        #region Instructor

        public static AComando<bool> CrearComandoAgregarInstructor(AEntidad instructor)
        {
            return new ComandoAgregarInstructor(instructor);
        }

        public static AComando<AEntidad> CrearComandoConsultarPorIdInstructor(AEntidad instructor)
        {
            return new ComandoConsultarPorIdInstructor(instructor);
        }

        public static AComando<List<AEntidad>> CrearComandoConsultarTodosInstructor()
        {
            return new ComandoConsultarTodosInstructor();
        }

        public static AComando<bool> CrearComandoInactivarInstructor(AEntidad instructor)
        {
            return new ComandoInactivarInstructor(instructor);
        }

        public static AComando<bool> CrearComandoModificarInstructor(AEntidad instructor)
        {
            return new ComandoModificarInstructor(instructor);
        }

        #endregion
        
        #region Reservacion Clase

        public static AComando<List<AEntidad>> CrearComandoConsultarTodosReservacionClase()
        {
            return new ComandoConsultarTodosReservarClase();
        }
        public static AComando<StringWriter> CrearComandoSerializadorListaEntidades(List<AEntidad> entidad)
        {
            return new ComandoSerializadorListaEntidades(entidad);
        }

        #endregion

        #region  Rutina
        
        /// <summary>
        /// Devuelve una instancia del comando ComandoHolaMundo.
        /// </summary>
        /// <returns></returns>
        public static AComando<List<Entidades.EEjercicios.Rutina>> CrearComandoConsultarRutinasPorIDCliente()
        {
            return new  ComandoConsultarRutinasPorCliente();
        }
        public static AComando<List<Entidades.EEjercicios.Ejercicio>> CrearComandoConsultarEjerciciosPorIDRutina()
        {
            return new ComandoConsultarEjerciciosPorIDRutina();
        }
        #endregion
    }
}