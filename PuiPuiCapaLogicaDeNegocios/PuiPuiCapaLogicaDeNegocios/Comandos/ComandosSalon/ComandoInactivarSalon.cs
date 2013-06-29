using PuiPuiCapaLogicaDeNegocios.Bitacora;
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
    /// clase inactivar salon.
    /// </summary>
   public class ComandoInactivarSalon: AComando<bool>
    {
        private int _id;
        /// <summary>
        /// Constructor de la clase por defecto que recibe el id del salon a inactivar.
        /// </summary>
        /// <param name="id"></param>
        public ComandoInactivarSalon(int id)
        {
            _id = id;
        }

        /// <summary>
        /// Ejecuta el comando inactivar salon, que produce que el salon se inactive en el sistema.
        /// </summary>
        /// <returns></returns>
        public override bool Ejecutar()
        {
            bool inactivo = false;
            ISalonDAO salonDao=(ISalonDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearSalonSQLServerDAO();
            inactivo=salonDao.Inactivar(_id);
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora
           ("el usuario **** accedio al comando consultar inactivar salon");
            return (inactivo);

        }
    }
}