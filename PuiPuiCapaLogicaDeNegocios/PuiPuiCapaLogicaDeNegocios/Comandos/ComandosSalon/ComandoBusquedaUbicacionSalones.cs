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
    /// Clase Comando Busqueda ubicacion salon 
    /// que implementa el comando busqueda ubicacion salones.
    /// </summary>
    public class ComandoBusquedaUbicacionSalones: AComando<List<Salon>>
    {
        String _ubicacion;
        /// <summary>
        /// constructor de la clase que recibe como parametro el atributo necesario para la ejecucion del comando.
        /// </summary>
        /// <returns></returns>
        /// <param name="ubicacion"></param>
        public ComandoBusquedaUbicacionSalones(String ubicacion)
        {
            _ubicacion = ubicacion;
        }

        /// <summary>
        /// implementacion del comando busqueda ubicacion salones.
        /// </summary>
        /// <returns></returns>
        public override List<Salon> Ejecutar()
        {
            ISalonDAO salonDao = (ISalonDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearSalonSQLServerDAO();
            List<Salon> listaSalon= (salonDao.BusquedaUbicacion(_ubicacion)).Cast<Salon>().ToList();
            EscritorBitacora bitacora = EscritorBitacora.obtenerInstancia();
            bitacora.escribirInfoEnBitacora("el usuario **** accedio al comando consultar ubicacion salones");
            return (listaSalon);

        }
    }
    }
