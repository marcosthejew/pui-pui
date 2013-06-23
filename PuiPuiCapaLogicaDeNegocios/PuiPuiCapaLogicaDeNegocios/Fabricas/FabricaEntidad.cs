using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios;
using PuiPuiCapaLogicaDeNegocios.Entidades.EPersonas;
using PuiPuiCapaLogicaDeNegocios.Entidades.EHorario;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones;
using PuiPuiCapaLogicaDeNegocios.Entidades.EReservaciones;

namespace PuiPuiCapaLogicaDeNegocios.Fabricas
{
    public class FabricaEntidad
    {
        #region Clases

        /// <summary>
        /// Metodo estatico que retorna una instancia de la clase Clase 
        /// encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearClase()
        {
            return new Clase();
        }

        /// <summary>
        /// Metodo estatico que retorna una instancia de la clase ClaseSalon
        /// encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearClaseSalon()
        {
            return new ClaseSalon();
        }

        /// <summary>
        /// Metodo estatico que retorna una instancia de la clase Salon 
        /// encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearSalon()
        {
            return new Salon();
        }
        #endregion

        #region Ejercicios

        /// <summary>
        /// Metodo estatico que retorna una instancia de la clase Ejercicio
        /// encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearEjercicio()
        {
            return new Ejercicio();
        }

        public static AEntidad CrearEjercicio(int id)
        {
            return new Ejercicio(id);
        }

        public static AEntidad CrearEjercicio(int id, string nombre)
        {
            return new Ejercicio(id, nombre);
        }

        public static AEntidad CrearEjercicio(int id, string nombre, string descripcion)
        {
            return new Ejercicio(id, nombre,descripcion);
        }

        public static AEntidad CrearEjercicio(int id, string nombre, string descripcion, Musculo musculo)
        {
            return new Ejercicio(id , nombre,descripcion,musculo);
        }

        public static AEntidad CrearEjercicio(int id, string nombre, string descripcion, Musculo musculo, string duracion, int repeticiones)
        {
            return new Ejercicio(id,nombre,descripcion,musculo,duracion,repeticiones);
        }

        /// <summary>
        /// Metodo estatico que retorna una instancia de la clase Musculo 
        /// encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearMusculo()
        {
            return new Musculo();
        }

        /// <summary>
        /// Metodo estatico que retorna una instancia de la clase Rutina 
        /// encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearRutina()
        {
            return new Rutina();
        }
        #endregion

        #region Evaluaciones

        /// <summary>
        /// Metodo estatico que retorna una instancia de la clase 
        /// EvaluacionClase encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearEvaluacionClase()
        {
            return new EvaluacionClase();
        }

        /// <summary>
        /// Metodo estatico que retorna una instancia de la clase 
        /// EvaluacionInstructor encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearEvaluacionInstructor()
        {
            return new EvaluacionInstructor();
        }
        #endregion

        #region Horario

        /// <summary>
        /// Metodo estatico que retorna una instancia de la clase Horario
        /// encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearHorario()
        {
            return new Horario();
        }
        #endregion

        #region Personas

        /// <summary>
        /// Metodo estatico que retorna una instancia de la clase Administrador
        /// encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearAdministrador()
        {
            return new Administrador();
        }

        /// <summary>
        /// Metodo estatico que retorna una instancia de la clase Cliente 
        /// encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearCliente()
        {
            return new Cliente();
        }

        /// <summary>
        /// Metodo estatico que retorna una instancia de la clase Instructor 
        /// encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearInstructor()
        {
            return new Instructor();
        }
        #endregion

        #region Reservaciones

        /// <summary>
        /// Metodo estatico que retorna una instancia de la clase 
        /// ReservacionClase encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearReservacionClase()
        {
            return new ReservacionClase();
        }

        /// <summary>
        /// Metodo estatico que retorna una instancia de la clase 
        /// ReservacionInstructor encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearReservacionInstructor()
        {
            return new ReservacionInstructor();
        }
        #endregion
    }
}