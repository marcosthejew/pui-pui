using PuiPuiCapaLogicaDeNegocios.Bitacora;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosClase
{
    public class ComandoBusquedaNombreClase : AComando<List<Clase>>
    {
        private string _nombre;

        /// <summary>
        /// Constructor de la clase de comandoBusquedaNombreClase
        /// </summary>
        public ComandoBusquedaNombreClase(string nombre)
        {

            _nombre = nombre;
        }

        /// <summary>
        /// Metodo que implementa la ejecucion del comando busquedaPorNombre
        /// </summary>
        public override List<Clase> Ejecutar()
        {
            IClaseDAO claseDao = (IClaseDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearClaseSQLServerDAO();
            List<Clase> listaClase = (claseDao.BusquedaNombreClase(_nombre)).Cast<Clase>().ToList();
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora("el usuario **** accedio al comando busqueda nombre clase");
            return (listaClase);
        }

    }
}