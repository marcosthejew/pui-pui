using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTSalon
{
    interface IContratoModificarSalon
    {

        Boolean RBStatus_Activo { set; get; }
        Boolean RBStatus_Inactivo { set; get; }
        String TXTSalonModificar{ set; get; }
        String DPLSalonModificar { set; get; }
        int TxtCapacidad { set; get; }
    }
}
