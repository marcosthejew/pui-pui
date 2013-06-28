using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandasoClaseSalon
{
    public class ComandoConsultarClaseSalonTodos : AComando<List<ClaseSalon>>
    {
        public ComandoConsultarClaseSalonTodos()
        { 
        
        
        }

        public override List<ClaseSalon> Ejecutar()
        {
            IClaseSalonDAO ClaseDao = (IClaseSalonDAO)
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearClaseSalonSQLServerDAO();
            List<ClaseSalon> listaClaseSalon=(ClaseDao.ConsultarTodos().Cast<ClaseSalon>().ToList());
            return (listaClaseSalon);
        
        }
    }
}