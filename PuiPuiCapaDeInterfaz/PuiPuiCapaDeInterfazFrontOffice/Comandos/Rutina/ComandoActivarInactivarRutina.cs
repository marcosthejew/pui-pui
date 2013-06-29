using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaDeInterfazFrontOffice.Comandos.Rutina
{
    public class ComandoActivarInactivarRutina: AComando<bool>
    {
        int idCliente;
        byte inactivo;

        public ComandoActivarInactivarRutina(int _idCliente, byte _inactivo)
        {
            this.idCliente = _idCliente;
            this.inactivo = _inactivo;
        }
        public override bool Ejecutar()
        {
            try
            {
                new PuiPuiCapaDeInterfazFrontOffice.LogicaRutinasEjercicios.FachadaRutinasEjercicios().ActivarInactivarRutina(idCliente, inactivo);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}