using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contractos.CTSalon
{
    /// <summary>
    /// Interfaz que implementa tods los de datos primitivos
    /// que pertenecen a las Vista agregar.
    /// </summary>
   public interface IContratoAgregarSalon
    {
        String TxtCodigoSalon { get; set; }
        String TxtNombreSalon { get; set; }
        int TextCapacidadSalon { get; set; }

    }
}
