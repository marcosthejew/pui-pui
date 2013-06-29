using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosRutina
{
    public class ComandoObtenerUltimoIDRutina : AComando<int>
    {
        /// <summary>
        /// Esta clase tiene como finalidad 
        /// </summary>
        public ComandoObtenerUltimoIDRutina()
        {

        }
        public override int Ejecutar()
        {
            try
            {
                IRutinaDAO RutinaDAO = (IRutinaDAO)Fabricas.AFabricaDAO.CrearFabricaSQLServerDAO().CrearRutinaSQLServerDAO();

                return RutinaDAO.ObtenerUltimoIDRutina();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}