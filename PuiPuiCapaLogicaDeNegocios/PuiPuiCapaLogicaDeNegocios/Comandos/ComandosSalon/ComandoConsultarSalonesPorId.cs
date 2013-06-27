using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsClases;
using PuiPuiCapaLogicaDeNegocios.Entidades.EClases;
using PuiPuiCapaLogicaDeNegocios.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosSalon
{
    public class ComandoConsultarSalonesPorId: AComando<Salon>
    {
        private int _id;
        private Salon _Salon;
        
        public ComandoConsultarSalonesPorId(int id)
        {
            _id = id;
        }

        public override Salon Ejecutar()
        {
            ISalonDAO salonDao=(ISalonDAO) 
            AFabricaDAO.CrearFabricaSQLServerDAO().CrearSalonSQLServerDAO();
            _Salon = (Salon) salonDao.ConsultarPorId(_id);
            return (_Salon);
        }
        
    }
}