using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.LogicaSalon;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTSalon;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PSalon
{
    /// <summary>
    /// Estalase tiene como finalidad realizar operaciones referentes a la 
    /// Vista de modificar salon con la capa de Logica de negocios.
    /// </summary>
    public class PModificarSalon
    {
        IContratoModificarSalon _modificar;
        public PModificarSalon(IContratoModificarSalon VistaModificar)
        {
            this._modificar = VistaModificar;
        
        }

        /// <summary>
        /// Devuelve un booleano que determina si el salon se modifico o no 
        /// en la base de datos
        /// </summary>
        /// <returns>boolean</returns>
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