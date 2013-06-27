using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosClase
{
    /// <summary>
    /// Comando que consulta salones.
    /// </summary>
   public class ComandoInactivarClase: AComando<bool>
    {
        private int _id;
        /// <summary>
        /// Constructor de la clase por defecto.
        /// </summary>
        /// <returns></returns>
        public ComandoInactivarClase(int id)
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
            IClaseDAO ClaseDao=(IClaseDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearClaseSQLServerDAO();
            inactivo=ClaseDao.Inactivar(_id);
            return (inactivo);

        }
    }
}