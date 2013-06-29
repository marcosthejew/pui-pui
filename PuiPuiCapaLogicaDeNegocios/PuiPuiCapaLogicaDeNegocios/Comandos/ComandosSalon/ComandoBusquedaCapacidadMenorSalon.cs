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
    /// Clase del Comando Busqueda capacidad menor salon 
    /// que implementa el comando busqueda capacidad menor salon
    /// </summary>
    public class ComandoBusquedaCapacidadMenorSalon: AComando<List<Salon>>
    {
        private int _capacidad;
        /// <summary>
        /// constructor de la clase que recibe como parametro el atributo necesario para la ejecucion del comando.
        /// </summary>
        /// <param name="capacidad"></param>
        public ComandoBusquedaCapacidadMenorSalon(int capacidad)
        {
            _capacidad = capacidad;
        }

        /// <summary>
        /// metodo que implementa la ejecucion del comando busqueda capacidad menor salon
        /// y devuelve una lista de los salones  con la capacidad otorgada.
        /// </summary>
        public override List<Salon> Ejecutar()
        {
            ISalonDAO salonDao = (ISalonDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearSalonSQLServerDAO();
            List<Salon> listaSalon = (salonDao.BusquedaCapacidadMenorSalon(_capacidad)).Cast<Salon>().ToList();
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora("el usuario **** accedio al comando consultar capacidad menor salon");
            return (listaSalon);
        }
    }
}