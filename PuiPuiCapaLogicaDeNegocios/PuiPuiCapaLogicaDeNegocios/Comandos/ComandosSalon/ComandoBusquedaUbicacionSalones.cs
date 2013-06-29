using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon
{
    public class ComandoBusquedaUbicacionSalones: AComando<List<Salon>>
    {
        String _ubicacion;
        /// <summary>
        /// Constructor de la clase por defecto.
        /// </summary>
        /// <returns></returns>
        public ComandoBusquedaUbicacionSalones(String ubicacion)
        {
            _ubicacion = ubicacion;
        }

        /// <summary>
        /// Ejecuta el comando.
        /// </summary>
        /// <returns></returns>
        public override List<Salon> Ejecutar()
        {
            ISalonDAO salonDao = (ISalonDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearSalonSQLServerDAO();
            List<Salon> listaSalon= (salonDao.BusquedaUbicacion(_ubicacion)).Cast<Salon>().ToList();
            return (listaSalon);

        }
    }
    }
