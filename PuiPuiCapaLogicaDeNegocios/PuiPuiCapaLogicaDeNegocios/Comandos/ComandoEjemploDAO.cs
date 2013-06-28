using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using PuiPuiCapaLogicaDeNegocios.Entidades;

namespace PuiPuiCapaLogicaDeNegocios.Comandos
{
    /// <summary>
    /// Esta clase tiene como finalidad ilustrar un ejemplo explicativo del uso
    /// de los objetos de acceso de datos (DAO)
    /// </summary>
    public class ComandoEjemploDAO : AComando<bool>
    {
        /// <summary>
        /// Agrega una rutina a la base de datos y, si ésta ha sido agregada con
        /// éxito, retorna true; de lo contrario, retorna false. NOTA: En este 
        /// ejemplo se da por supuesto que la clase Rutina tiene implementado un
        /// método Equals que determina si dos rutinas son iguales.
        /// </summary>
        /// <returns></returns>
        public override bool Ejecutar()
        {
            IDAO rutinaDAO;
            AEntidad nuevaRutina;
            int idNuevaRutina;

            rutinaDAO = AFabricaDAO.CrearFabricaSQLServerDAO()
                        .CrearRutinaSQLServerDAO();
            nuevaRutina = FabricaEntidad.CrearRutina();

            idNuevaRutina = rutinaDAO.Agregar(nuevaRutina);

            return nuevaRutina.Equals(rutinaDAO.ConsultarPorId(idNuevaRutina));
        }
    }
}