using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEjercicio
{
    public class ComandoConsultarEjerciciosPorIDRutina : AComando<List<Ejercicio>>
    {
        /// <summary>
        /// Esta clase tiene como finalidad 
        /// </summary>
        public ComandoConsultarEjerciciosPorIDRutina()
        {

        }
        public override List<Ejercicio> Ejecutar()
        {
            try
            {
                IRutinaDAO rutinaDAO = (IRutinaDAO)Fabricas.AFabricaDAO.CrearFabricaSQLServerDAO().CrearRutinaSQLServerDAO();

                return rutinaDAO.ConsultarEjerciciosPorIDRutina(18);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}