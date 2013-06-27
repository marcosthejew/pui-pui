using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosRutina
{
    public class ComandoAgregarHistorial : AComando<bool>
    {

        /// <summary>
        /// Esta clase tiene como finalidad agregar rutinas nuevas
        /// </summary>
        public ComandoAgregarHistorial()
        {

        }

        public override bool Ejecutar()
        {
            try
            {
                IRutinaDAO rutinaDAO = (IRutinaDAO)Fabricas.AFabricaDAO.CrearFabricaSQLServerDAO().CrearRutinaSQLServerDAO();
                return rutinaDAO.AgregarHistorialRutina("10", 0, 7, 1, 1);


            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}