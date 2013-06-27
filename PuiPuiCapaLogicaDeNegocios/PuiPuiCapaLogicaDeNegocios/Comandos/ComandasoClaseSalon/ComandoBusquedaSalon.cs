using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandasoClaseSalon
{
    public class ComandoBusquedaSalon: AComando<List<ClaseSalon>>
    {

        private string _codigoSalon;
        public ComandoBusquedaSalon(string codigoSalon)
        {
            this._codigoSalon = codigoSalon;
        
        }

        public override List<ClaseSalon> Ejecutar()
        {

            IClaseSalonDAO ClaseDao = (IClaseSalonDAO)
              AFabricaDAO.CrearFabricaSQLServerDAO().CrearClaseSalonSQLServerDAO();
            List<ClaseSalon> listaClaseSalon = (ClaseDao.ListarSalonesClaseTsalon(_codigoSalon).Cast<ClaseSalon>().ToList());
            return (listaClaseSalon);


        }
    
    }
}