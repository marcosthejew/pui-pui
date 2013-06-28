using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTSalon
{
    /// <summary>
    /// Interfaz que implementa tods los de datos primitivos
    /// que pertenecen a las Vista detalle Consulta.
    /// </summary>
   public interface IContractoDetalleConsulta
    {
        String SessionID { get; set; }
        String TxtUbicacion { get; set; }
        String TxtStatus { get; set; }
        String TxtCodigo{ get; set; }
        int TxtCapcidad { get; set; }
    }
}
