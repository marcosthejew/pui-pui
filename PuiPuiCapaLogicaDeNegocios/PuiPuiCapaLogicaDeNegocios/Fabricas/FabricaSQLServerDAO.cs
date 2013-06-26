using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEvaluaciones;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsHorario;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsPersonas;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsReservaciones;

namespace PuiPuiCapaLogicaDeNegocios.Fabricas
{
    /// <summary>
    /// Clase Singleton de fabrica que tiene como finalidad instanciar objetos
    /// DAO que operen con la fuente de datos de SQL server de la capa de datos.
    /// </summary>
    public class FabricaSQLServerDAO
    {
        private static FabricaSQLServerDAO _instancia;

        private FabricaSQLServerDAO()
        {
        }

        /// <summary>
        /// Metodo estatico que devuelve la instancia Singleton de la clase
        /// FabricaSQLServerDAO
        /// </summary>
        /// <returns></returns>
        public static FabricaSQLServerDAO obtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FabricaSQLServerDAO();
            }
            return _instancia;
        }

        /// <summary>
        /// Devuelve una instancia de la clase ClaseSQLServerDAO encajonada en
        /// la interfaz IDAO.
        /// </summary>
        /// <returns></returns>
        public IDAO CrearClaseSQLServerDAO()
        {
            return new ClaseSQLServerDAO();
        }

        /// <summary>
        /// Devuelve una instancia de la clase ClaseSalonSQLServerDAO encajonada
        /// en la interfaz IDAO.
        /// </summary>
        /// <returns></returns>
        public IDAO CrearClaseSalonSQLServerDAO()
        {
            return new ClaseSalonSQLServerDAO();
        }

        /// <summary>
        /// Devuelve una instancia de la clase SalonSQLServerDAO encajonada en
        /// la interfaz IDAO.
        /// </summary>
        /// <returns></returns>
        public IDAO CrearSalonSQLServerDAO()
        {
            return new SalonSQLServerDAO();
        }

        /// <summary>
        /// Devuelve una instancia de la clase EjercicioSQLServerDAO encajonada
        /// en la interfaz IDAO.
        /// </summary>
        /// <returns></returns>
        public IEjercicioDAO CrearEjercicioSQLServerDAO()
        {
            return new EjercicioSQLServerDAO();
        }

        /// <summary>
        /// Devuelve una instancia de la clase MusculoSQLServerDAO encajonada en
        /// la interfaz IDAO.
        /// </summary>
        /// <returns></returns>
        public IMusculoDAO CrearMusculoSQLServerDAO()
        {
            return new MusculoSQLServerDAO();
        }

        /// <summary>
        /// Devuelve una instancia de la clase RutinaSQLServerDAO encajonada en
        /// la interfaz IDAO.
        /// </summary>
        /// <returns></returns>
        public IDAO CrearRutinaSQLServerDAO()
        {
            return new RutinaSQLServerDAO();
        }

        /// <summary>
        /// Devuelve una instancia de la clase EvaluacionClaseSQLServerDAO
        /// encajonada en la interfaz IDAO.
        /// </summary>
        /// <returns></returns>
        public IDAO CrearEvaluacionClaseSQLServerDAO()
        {
            return new EvaluacionClaseSQLServerDAO();
        }

        /// <summary>
        /// Devuelve una instancia de la clase EvaluacionInstructorSQLServerDAO
        /// encajonada en la interfaz IDAO.
        /// </summary>
        /// <returns></returns>
        public IDAO CrearEvaluacionInstructorSQLServerDAO()
        {
            return new EvaluacionInstructorSQLServerDAO();
        }

        /// <summary>
        /// Devuelve una instancia de la clase HorarioSQLServerDAO encajonada en
        /// la interfaz IDAO.
        /// </summary>
        /// <returns></returns>
        public IDAO CrearHorarioSQLServerDAO()
        {
            return new HorarioSQLServerDAO();
        }

        /// <summary>
        /// Devuelve una instancia de la clase AdministradorSQLServerDAO
        /// encajonada en la interfaz IDAO.
        /// </summary>
        /// <returns></returns>
        public IDAO CrearAdministradorSQLServerDAO()
        {
            return new AdministradorSQLServerDAO();
        }

        /// <summary>
        /// Devuelve una instancia de la clase ClienteSQLServerDAO encajonada en
        /// la interfaz IDAO.
        /// </summary>
        /// <returns></returns>
        public IDAO CrearClienteSQLServerDAO()
        {
            return new ClienteSQLServerDAO();
        }

        /// <summary>
        /// Devuelve una instancia de la clase InstructorSQLServerDAO encajonada
        /// en la interfaz IDAO.
        /// </summary>
        /// <returns></returns>
        public IInstructorDAO CrearInstructorSQLServerDAO()
        {
            return new InstructorSQLServerDAO();
        }

        /// <summary>
        /// Devuelve una instancia de la clase ReservacionClaseSQLServerDAO 
        /// encajonada en la interfaz IDAO.
        /// </summary>
        /// <returns></returns>
        public IDAO CrearReservacionClaseSQLServerDAO()
        {
            return new ReservacionClaseSQLServerDAO();
        }

        /// <summary>
        /// Devuelve una instancia de la clase ReservacionInstructorSQLServerDAO
        /// encajonada en la interfaz IDAO.
        /// </summary>
        /// <returns></returns>
        public IDAO CrearReservacionInstructorSQLServerDAO()
        {
            return new ReservacionInstructorSQLServerDAO();
        }
    }
}