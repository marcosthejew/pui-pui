using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios;
using PuiPuiCapaLogicaDeNegocios.Entidades.EPersonas;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosRutina
{
    public class ComandoConsultarPersonaPorLogin : AComando<int>
    {
        /// <summary>
        /// Esta clase tiene como finalidad 
        /// </summary>
        public ComandoConsultarPersonaPorLogin()
        {

        }
        public override int Ejecutar()
        {
            try
            {
                IRutinaDAO ClienteDAO = (IRutinaDAO)Fabricas.AFabricaDAO.CrearFabricaSQLServerDAO().CrearRutinaSQLServerDAO();

                return ClienteDAO.ConsultarPersonaPorLogin("Karla");

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}