using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEjercicios;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosRutina
{
    public class ComandoConsutarStatusRutinaPorID : AComando<string>
    {
        int idRutina;

        public ComandoConsutarStatusRutinaPorID(int _idRutina)
        {
            this.idRutina = _idRutina;
        }
        public override string Ejecutar()
        {
            try
            {
                IRutinaDAO rutinaDAO = (IRutinaDAO)Fabricas.AFabricaDAO.CrearFabricaSQLServerDAO().CrearRutinaSQLServerDAO();

                return rutinaDAO.ConsultarStatusRutinaPorID(idRutina);

            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}