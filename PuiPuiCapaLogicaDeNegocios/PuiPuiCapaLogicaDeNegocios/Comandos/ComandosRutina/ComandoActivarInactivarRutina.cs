using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.DAOs.DAOsEjercicios;

namespace PuiPuiCapaLogicaDeNegocios.Comandos.ComandosRutina
{
    public class ComandoActivarInactivarRutina :AComando<bool>
    {
        int idRutina;
        byte inactivo;
        public ComandoActivarInactivarRutina(int _idRutina, byte _inactivo)
        {
            this.idRutina = _idRutina;
            this.inactivo = _inactivo;
        }
        public override bool Ejecutar()
        {
            try
            {
                IRutinaDAO rutinaDAO = (IRutinaDAO)Fabricas.AFabricaDAO.CrearFabricaSQLServerDAO().CrearRutinaSQLServerDAO();

                return rutinaDAO.ActivarInactivarRutina(idRutina,inactivo);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}