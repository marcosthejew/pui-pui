using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandasoClaseSalon
{
    public class ComandoAgregarClaseSalon:AComando<int>
    {

        private ClaseSalon claseSalon;
        public ComandoAgregarClaseSalon(ClaseSalon eClaseSalon)
        {
            this.claseSalon = eClaseSalon;
        
        }
        public override int Ejecutar()
        {
            int agrego = 1;
            IClaseSalonDAO claseSalonDao = (IClaseSalonDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearClaseSalonSQLServerDAO();
            agrego = claseSalonDao.Agregar(this.claseSalon);
            return (agrego);
            
        }
    }
}