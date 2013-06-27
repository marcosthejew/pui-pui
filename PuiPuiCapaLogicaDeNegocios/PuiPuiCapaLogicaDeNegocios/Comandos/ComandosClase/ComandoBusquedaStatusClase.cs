using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosClase
{
    public class ComandoBusquedaStatusClase: AComando<List<Clase>>
    {
        private int _status;

        public ComandoBusquedaStatusClase(int status)
        {
            _status = status;
        }

        public override List<Clase> Ejecutar()
        {
            IClaseDAO claseDao = (IClaseDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearClaseSQLServerDAO();
            List<Clase> listaClase = (claseDao.BusquedaStatusClase(_status)).Cast<Clase>().ToList();
            return (listaClase);
        }
    }
}