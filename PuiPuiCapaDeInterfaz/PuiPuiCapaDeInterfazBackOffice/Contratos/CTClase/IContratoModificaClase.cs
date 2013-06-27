using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTClase
{
    public interface IContratoModificaClase
    {
        String TxtClaseModificar { get; set; }
        String TADescripcionModificar { get; set; }
        Boolean RBStatus_Activo { get; set; }
        Boolean RBStatus_Inactivo { get; set; }
        int idClase { set; get; }
    }
}
