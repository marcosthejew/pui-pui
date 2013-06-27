using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon
{
    public class ComandoBusquedaStatusSalon: AComando<List<Salon>>
    {
        private int _status;

        public ComandoBusquedaStatusSalon(int status)
        {
            _status = status;
        }

        public override List<Salon> Ejecutar()
        {
            ISalonDAO salonDao = (ISalonDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearSalonSQLServerDAO();
            List<Salon> listaSalon = (salonDao.BusquedaStatusSalon(_status)).Cast<Salon>().ToList();
            return (listaSalon);
        }
    }
}