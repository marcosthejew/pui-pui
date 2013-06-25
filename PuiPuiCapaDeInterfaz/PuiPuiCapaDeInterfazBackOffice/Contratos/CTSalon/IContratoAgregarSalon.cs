using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contractos.CTSalon
{
   public interface IContratoAgregarSalon
    {
        String TxtCodigoSalon { get; set; }
        String TxtNombreSalon { get; set; }
        int TextCapacidadSalon { get; set; }

    }
}
