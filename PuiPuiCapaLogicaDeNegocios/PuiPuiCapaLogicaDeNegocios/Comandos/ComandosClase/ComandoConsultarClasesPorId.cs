using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosClase
{
    public class ComandoConsultarClasesPorId: AComando<Clase>
    {
        private int _id;
        private Clase _Clase;
        
        public ComandoConsultarClasesPorId(int id)
        {
            _id = id;
        }

        public override Clase Ejecutar()
        {
            IClaseDAO claseDao=(IClaseDAO) 
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearClaseSQLServerDAO();
            _Clase = (Clase) claseDao.ConsultarPorId(_id);
            return (_Clase);
        }
        
    }
}