using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon
{
    /// <summary>
    /// Comando que inserta una nueva clase.
    /// </summary>
    public class ComandoInsertarSalon : AComando<Salon>
    {
        private Salon salon;

        public ComandoInsertarSalon(Salon salon) {
            this.salon = salon;
        }



        /// <summary>
        /// Ejecuta el comando.
        /// </summary>
        /// <returns></returns>
        public override Salon Ejecutar()
        {

            DAOs.IDAO SalonSqlServerDAO;
            SalonSqlServerDAO = new DAOs.DAOsClases.SalonSQLServerDAO();
            SalonSqlServerDAO.Agregar(this.salon);
            return (this.salon);
            
        }
    }
}