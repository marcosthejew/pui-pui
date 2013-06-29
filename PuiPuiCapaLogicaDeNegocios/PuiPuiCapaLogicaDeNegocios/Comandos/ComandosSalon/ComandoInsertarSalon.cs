using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Bitacora;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon
{
    /// <summary>
    /// Clase del comando agregar salon.
    /// </summary>
    public class ComandoAgregarSalon : AComando<int>
    {
        private Salon salon;
        /// <summary>
        /// Constructor de la clase por defecto que recibe el salon a insertar.
        /// </summary>
        /// <param name="id"></param>
        public ComandoAgregarSalon(Salon salon) {
            this.salon = salon;
        }

        /// <summary>
        /// Ejecuta el comando y retorna 0 en caso de que el salon se inserte y 1 en caso de que no lo haga
        /// </summary>
        /// <returns></returns>
        public override int Ejecutar()
        {
            int agrego = 1;
            ISalonDAO salonDao=(ISalonDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearSalonSQLServerDAO();
            agrego=salonDao.Agregar(this.salon);
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora("el usuario **** accedio al comando consultar insertar salon");
            return (agrego);
            
        }
    }
}