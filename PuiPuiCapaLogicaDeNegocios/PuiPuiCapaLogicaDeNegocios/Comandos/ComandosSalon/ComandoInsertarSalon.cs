using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon
{
    /// <summary>
    /// Comando que inserta un nuevo salon.
    /// </summary>
    public class ComandoAgregarSalon : AComando<int>
    {
        private Salon salon;

        public ComandoAgregarSalon(Salon salon) {
            this.salon = salon;
        }

        /// <summary>
        /// Ejecuta el comando.
        /// </summary>
        /// <returns></returns>
        public override int Ejecutar()
        {
            int agrego = 1;
            ISalonDAO salonDao=(ISalonDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearSalonSQLServerDAO();
            agrego=salonDao.Agregar(this.salon);
            return (agrego);
            
        }
    }
}