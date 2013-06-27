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

        public ComandoBusquedaNombreClase(string nombre)
        {

            _nombre = nombre;
        }

        public override List<Clase> Ejecutar()
        {
            IClaseDAO claseDao = (IClaseDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearClaseSQLServerDAO();
            List<Clase> listaClase = (claseDao.BusquedaNombreClase(_nombre)).Cast<Clase>().ToList();
            return (listaClase);
        }

    }
}