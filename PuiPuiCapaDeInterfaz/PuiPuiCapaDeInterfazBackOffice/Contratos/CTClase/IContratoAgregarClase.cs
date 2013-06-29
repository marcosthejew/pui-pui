using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTClase
{
    /// <summary>
    /// Interfaz que implementa tods los de datos primitivos
    /// que pertenecen a las Vista Agregar.
    /// </summary>
   public interface IContratoAgregarClase
    {
        String TxtnombreClaseNueva { set; get; }
        String TxtDescripcionClaseNueva { set; get; }
    }
}
