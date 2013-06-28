using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosRutina
{
    public class ComandoConsultarTodosEjerciciosR : AComando<List<Ejercicio>>
    {
        /// <summary>
        /// Esta clase tiene como finalidad 
        /// </summary>
        public ComandoConsultarTodosEjerciciosR()
        {

        }
        public override List<Ejercicio> Ejecutar()
        {
            try
            {
                IRutinaDAO rutinaDAO = (IRutinaDAO)Fabricas.AFabricaDAO.CrearFabricaSQLServerDAO().CrearRutinaSQLServerDAO();

                return rutinaDAO.ConsultarTodosEjerciciosR();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}