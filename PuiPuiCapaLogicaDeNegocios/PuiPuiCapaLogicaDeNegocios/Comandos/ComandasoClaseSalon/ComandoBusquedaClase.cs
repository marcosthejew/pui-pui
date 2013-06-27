using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandasoClaseSalon
{
    public class ComandoBusquedaClase: AComando<List<ClaseSalon>>
    {
        private string _nombreClase;
        public ComandoBusquedaClase(string claseNombre)
        {
            this._nombreClase = claseNombre;
        }

        public override List<ClaseSalon> Ejecutar() {

            IClaseSalonDAO ClaseDao = (IClaseSalonDAO)
              AFabricaDAO.CrearFabricaSQLServerDAO().CrearClaseSalonSQLServerDAO();
            List<ClaseSalon> listaClaseSalon = (ClaseDao.ListarSalonesClaseTclase(_nombreClase).Cast<ClaseSalon>().ToList());
            return (listaClaseSalon);
        
        
        }
    }
}