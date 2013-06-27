using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosRutina
{
    public class ComandoActivarInactivarRutina :AComando<bool>
    {
        public ComandoActivarInactivarRutina()
        {

        }
        public override bool Ejecutar()
        {
            try
            {
                IRutinaDAO rutinaDAO = (IRutinaDAO)Fabricas.AFabricaDAO.CrearFabricaSQLServerDAO().CrearRutinaSQLServerDAO();

                return rutinaDAO.ActivarInactivarRutina(18,1);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}