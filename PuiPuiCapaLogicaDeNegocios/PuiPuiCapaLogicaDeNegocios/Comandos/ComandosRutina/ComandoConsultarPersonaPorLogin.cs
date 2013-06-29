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

        string login;
        /// <summary>
        /// Esta clase tiene como finalidad 
        /// </summary>
        public ComandoConsultarPersonaPorLogin(string _login)
        {
            this.login = _login;
        }
        public override int Ejecutar()
        {
            try
            {
                IRutinaDAO ClienteDAO = (IRutinaDAO)Fabricas.AFabricaDAO.CrearFabricaSQLServerDAO().CrearRutinaSQLServerDAO();

                return ClienteDAO.ConsultarPersonaPorLogin(login);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}