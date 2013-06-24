using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon
{
    /// <summary>
    /// Comando que consulta salones.
    /// </summary>
   public class ComandoInactivarSalon: AComando<bool>
    {
        private int _id;
        /// <summary>
        /// Constructor de la clase por defecto.
        /// </summary>
        /// <returns></returns>
        public ComandoInactivarSalon(int id)
        {
            _id = id;
        }

        /// <summary>
        /// Ejecuta el comando.
        /// </summary>
        /// <returns></returns>
        public override bool Ejecutar()
        {
            bool inactivo = false;
            ISalonDAO SalonDAO=(ISalonDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearSalonSQLServerDAO();
            inactivo=SalonDAO.Inactivar(_id);
            return (inactivo);

        }
    }
}