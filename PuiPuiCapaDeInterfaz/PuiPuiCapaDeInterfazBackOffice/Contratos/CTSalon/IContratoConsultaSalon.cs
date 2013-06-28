using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTSalon
{
    /// <summary>
    /// Interfaz que implementa tods los de datos primitivos
    /// que pertenecen a las Vista consultar.
    /// </summary>
    public interface IContratoConsultaSalon
    {
        Boolean RBConsultaCompleta { set; get; }
        Boolean RBUbicacion { set; get; }
        Boolean RBCapacidad { set; get; }
        Boolean RBStatus { set; get; }
        String TextNombreSalon { set; get; }
        String DPLStatus { set; get; }
        String DPLCapacidad{ set; get; }
        int TxtCapacidad { set; get; }
    }
}
