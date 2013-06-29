using log4net;
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
    /// Clase Comando Busqueda capacidad mayor salon 
    /// que implementa el metodo busqueda mayor salon
    /// </summary>
    public class ComandoBusquedaCapacidadMayorSalon: AComando<List<Salon>>
    {
        private int _capacidad;
        /// <summary>
        /// constructor de la clase que recibe como parametro el atributo necesario para la ejecucion del comando.
        /// </summary>
        public ComandoBusquedaCapacidadMayorSalon(int capacidad)
        {
            _capacidad = capacidad;
        }

        /// <summary>
        /// metodo que implementa la ejecucion del comando busqueda capacidad mayor salon y rwetorna una lista con los salones de capacidad mayor.
        /// </summary>
        public override List<Salon> Ejecutar()
        {
            ISalonDAO salonDao = (ISalonDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearSalonSQLServerDAO();
            List<Salon> listaSalon = (salonDao.BusquedaCapacidadMayorSalon(_capacidad)).Cast<Salon>().ToList();
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora("el usuario **** accedio al comando consultar capacidad mayor salon");
            return (listaSalon);
        }

    }
}