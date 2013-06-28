using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosRutina
{
    public class ComandoAgregarRutina : AComando<bool>
    {

        /// <summary>
        /// Esta clase tiene como finalidad agregar rutinas nuevas
        /// </summary>
        public ComandoAgregarRutina()
        {

        }

        public override bool Ejecutar()
        {
            try
            {
                IRutinaDAO rutinaDAO = (IRutinaDAO)Fabricas.AFabricaDAO.CrearFabricaSQLServerDAO().CrearRutinaSQLServerDAO();
                return rutinaDAO.AgregarRutina("hola", "hola");


            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}