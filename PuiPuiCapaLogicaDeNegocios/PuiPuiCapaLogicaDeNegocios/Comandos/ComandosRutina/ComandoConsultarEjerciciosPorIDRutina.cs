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
        int idCliente;

        /// <summary>
        /// Esta clase tiene como finalidad 
        /// </summary>
        public ComandoConsultarEjerciciosPorIDRutina(int _idCliente)
        {
            this.idCliente = _idCliente;
        }
        public override List<Ejercicio> Ejecutar()
        {
            try
            {
                IRutinaDAO rutinaDAO = (IRutinaDAO)Fabricas.AFabricaDAO.CrearFabricaSQLServerDAO().CrearRutinaSQLServerDAO();

                return rutinaDAO.ConsultarEjerciciosPorIDRutina(idCliente);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}