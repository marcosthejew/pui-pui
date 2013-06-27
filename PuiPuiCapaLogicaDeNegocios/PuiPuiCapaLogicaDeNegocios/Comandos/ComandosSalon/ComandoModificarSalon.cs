using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon
{
    /// <summary>
    /// Comando que modifica salones.
    /// </summary>
    public class ComandoModificarSalon : AComando<bool>
    {
        private int _id;
        private AEntidad _salon;
        /// <summary>
        /// Constructor de la clase por defecto.
        /// </summary>
        /// <returns></returns>
        public ComandoModificarSalon(int id, Salon salon)
        {
            _id = id;
            _salon = salon;
        }

        /// <summary>
        /// Ejecuta el comando.
        /// </summary>
        /// <returns></returns>
        public override bool Ejecutar()
        {
            bool modifico = false;
            ISalonDAO salonDao= (ISalonDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearSalonSQLServerDAO();
            salonDao = new DAOs.DAOsClases.SalonSQLServerDAO();
            modifico = salonDao.Modificar(_id, _salon);
            return (modifico);

        }
    }
}