using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandasoClaseSalon
{
    public class ComandoBusquedaInstructor : AComando<List<ClaseSalon>>
    {
        private string _nombreInstructor;
        public ComandoBusquedaInstructor(string nombreInstructor)
        { 
        
        this._nombreInstructor=nombreInstructor;
        
        }

        public override List<ClaseSalon> Ejecutar()
        {

            IClaseSalonDAO ClaseDao = (IClaseSalonDAO)
              AFabricaDAO.CrearFabricaSQLServerDAO().CrearClaseSalonSQLServerDAO();
            List<ClaseSalon> listaClaseSalon = (ClaseDao.ListarSalonesClaseTinstructor(_nombreInstructor).Cast<ClaseSalon>().ToList());
            return (listaClaseSalon);


        }

    }
}