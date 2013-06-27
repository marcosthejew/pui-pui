using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTSalon
{
   public interface IContractoDetalleConsulta
    {
        String SessionID { get; set; }
        String TxtUbicacion { get; set; }
        String TxtStatus { get; set; }
        String TxtCodigo{ get; set; }
        int TxtCapcidad { get; set; }
    }
}
