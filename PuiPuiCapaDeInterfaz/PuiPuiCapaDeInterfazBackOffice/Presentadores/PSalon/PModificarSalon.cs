using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.LogicaSalon;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTSalon;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PSalon
{
    public class PModificarSalon
    {
        IContratoModificarSalon _modificar;
        public PModificarSalon(IContratoModificarSalon VistaModificar)
        {
            this._modificar = VistaModificar;
        
        }

        public Boolean ModificarSalon()
        {
            FachadaSalonBackOfficeSoapClient modifica = new FachadaSalonBackOfficeSoapClient();
            if(_modificar.RBStatus_Activo==true)
            {
               return modifica.ServicioModificarSalon(_modificar.SessionID, _modificar.TXTSalonCodigo, _modificar.TXTSalonModificar, 0, _modificar.TxtCapacidad);
            }
            if (_modificar.RBStatus_Inactivo == true)
            {
              return  modifica.ServicioModificarSalon(_modificar.SessionID, _modificar.TXTSalonCodigo, _modificar.TXTSalonModificar, 1, _modificar.TxtCapacidad);
            }

            return false;
        }
    }
}