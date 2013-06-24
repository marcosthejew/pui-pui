using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTSalon
{
    interface IContratoConsultaSalon
    {
        Boolean RBConsultaCompleta { set; get; }
        Boolean RBUbicacion { set; get; }
        Boolean RBCapacidad { set; get; }
        Boolean RBStatus { set; get; }
        String SessionID { get; set; }
        String TextNombreSalon { set; get; }
        String DPLStatus { set; get; }
        String DPLCapacidad{ set; get; }
        int TxtCapacidad { set; get; }
    }
}
