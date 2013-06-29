using PuiPuiCapaLogicaDeNegocios.Bitacora;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosClase
{    ///
    public class ComandoBusquedaStatusClase: AComando<List<Clase>>
    {
        private int _status;
       /// <summary>
       /// constructor de la clase que recibe el status a consultar
       /// </summary>
       /// <param name="status"></param>
        public ComandoBusquedaStatusClase(int status)
        {
            _status = status;
        }
        /// <summary>
        ///se verifica si la clase esta inactiva mediante este metodo
        /// </summary>
        public override List<Clase> Ejecutar()
        {
            IClaseDAO claseDao = (IClaseDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearClaseSQLServerDAO();
            List<Clase> listaClase = (claseDao.BusquedaStatusClase(_status)).Cast<Clase>().ToList();
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora("el usuario **** accedio al comando busqueda status clase");
            return (listaClase);
        }
    }
}