using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon
{
    public class ComandoBusquedaCapacidadMayorSalon: AComando<List<Salon>>
    {
        private int _capacidad;

        public ComandoBusquedaCapacidadMayorSalon(int capacidad)
        {
            _capacidad = capacidad;
        }

        public override List<Salon> Ejecutar()
        {
            ISalonDAO salonDao = (ISalonDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearSalonSQLServerDAO();
            List<Salon> listaSalon = (salonDao.BusquedaCapacidadMayorSalon(_capacidad)).Cast<Salon>().ToList();
            return (listaSalon);
        }
    }
}