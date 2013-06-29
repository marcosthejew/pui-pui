using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosEjercicio
{
    public class ComandoConsultarRutinasPorCliente : AComando<List<Rutina>>
    {
        int idCliente;
        public ComandoConsultarRutinasPorCliente(int _idCliente)
        {
            this.idCliente = _idCliente;
        }
        public override List<Rutina> Ejecutar()
        {
            try
            {
                IRutinaDAO rutinaDAO = (IRutinaDAO)Fabricas.AFabricaDAO.CrearFabricaSQLServerDAO().CrearRutinaSQLServerDAO();

                return rutinaDAO.ConsultarRutinasPorIDCliente(idCliente);

            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}