﻿using System;
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
        public static AEntidad CrearClase(string nombre,int idClase, string descripcion, int status)
        {

            return new Clase(nombre, idClase, descripcion, status);
        }

        /// <summary>
        /// Metodos estaticos que reciben distintos parametros y retornan una instancia de la clase ClaseSalon
        /// encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearClaseSalon()
        {
            return new ClaseSalon();

        }
         public static AEntidad CrearClaseSalon(int iid, Salon sal, Clase clas, Instructor ins,Horario ho, int disp)
        {
            return new ClaseSalon(iid, sal, clas, ho, ins, disp);
        }
     
         public static AEntidad CrearClaseSalon(int iid, Salon sal, Clase clas, Instructor ins,  int disp)
         {
             return new ClaseSalon(iid, sal, clas, ins, disp);
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
        /// <summary>
        /// Metodo estatico que retorna una instancia de la clase Salon 
        /// encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearSalon(string codigo, int capacidad, string ubicacion, int status) 
        {
            return new Salon(codigo, ubicacion, capacidad, status);
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

        public static AEntidad CrearMusculo(int id)
        {
            return new Musculo(id);
        }

        public static AEntidad CrearMusculo(int id, string nombre)
        {
            return new Musculo(id,nombre);
        }

        public static AEntidad CrearMusculo(string nombre, string descripcion)
        {
            return new Musculo(nombre,descripcion);
        }

        public static AEntidad CrearMusculo(int id, string nombre, string descripcion)
        {
            return new Musculo(id, nombre, descripcion);
        }

        public static AEntidad CrearMusculo(int id, string nombre, string descripcion, bool status)
        { 
            return new Musculo(id,nombre,descripcion,status);
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

        public static AEntidad CrearEvaluacionInstructor(int id)
        {
            EvaluacionInstructor eva = new EvaluacionInstructor();
            eva.Id = id;
            return eva;
        }

        public static AEntidad CrearEvaluacionInstructor(int id, DateTime fecha, String observaciones, int status, string idcliente, string idinstructor, int calificacion)
        {          
            EvaluacionInstructor eva = new EvaluacionInstructor();
            eva.Id = id;
            eva.Inactivo = status; 
            eva.Fecha = fecha;
            eva.Observaciones = observaciones;
            eva.idCliente = idcliente;
            eva.idInstructor = idinstructor;
            eva.Calificacion = calificacion;
            return eva;
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

        public static AEntidad CrearInstructor(int id)
        {
            return new Instructor(id);
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
        /// ReservacionEventoCalendario encajonada en la clase abstracta AEntidad.
        /// </summary>
        /// <returns></returns>
        public static AEntidad CrearReservacionEventoCalendario()
        {
            return new ReservacionEventoCalendario();
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