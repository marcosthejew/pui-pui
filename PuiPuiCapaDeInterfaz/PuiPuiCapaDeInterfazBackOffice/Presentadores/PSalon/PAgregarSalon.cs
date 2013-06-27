using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.LogicaSalon;
using PuiPuiCapaDeInterfazBackOffice.Contractos.CTSalon;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PSalon
{
    public class PAgregarSalon
    {
        IContratoAgregarSalon salon;

        public PAgregarSalon(IContratoAgregarSalon vista_agregar)
        {

            this.salon = vista_agregar;

        }
        public  bool AgregarSalon()
        {
            FachadaSalonBackOfficeSoapClient agregar = new FachadaSalonBackOfficeSoapClient();
            int se_agrego = agregar.ServicioAgregarSalon(salon.TxtCodigoSalon, salon.TxtNombreSalon, 0, salon.TextCapacidadSalon);

            if (se_agrego == 0)
                return true;
            else
                return false;
        }






    }
}