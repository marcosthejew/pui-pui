using PuiPuiCapaLogicaDeNegocios.Bitacora;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon
/// <summary>
/// Clase Comando Busqueda status salon 
/// que implementa el comando busqueda status salon
/// </summary>
{
    public class ComandoBusquedaStatusSalon: AComando<List<Salon>>
    {
        private int _status;
        /// <summary>
        /// constructor de la clase que recibe como parametro el atributo necesario para la ejecucion del comando.
        /// </summary>
        /// <param name="status"></param>
        public ComandoBusquedaStatusSalon(int status)
        {
            _status = status;
        }
        /// <summary>
       ///metodo que implementa la ejecucion del comando busqueda status salon
       ///,y devuelve una lista de salones que presenten el estatus del objeto
        /// </summary>
        public override List<Salon> Ejecutar()
        {
            ISalonDAO salonDao = (ISalonDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearSalonSQLServerDAO();
            List<Salon> listaSalon = (salonDao.BusquedaStatusSalon(_status)).Cast<Salon>().ToList();
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora("el usuario **** accedio al comando consultar capacidad menor salon");
            return (listaSalon);
        }
    }
}