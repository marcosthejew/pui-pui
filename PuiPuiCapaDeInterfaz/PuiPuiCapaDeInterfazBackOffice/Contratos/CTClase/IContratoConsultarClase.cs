using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTClase
{
    /// <summary>
    /// Interfaz que implementa tods los de datos primitivos
    /// que pertenecen a las Vista consultar.
    /// </summary>
    public interface IContratoConsultarClase
    {
     
        Boolean RBConsultaCompleta { set; get; }
        Boolean RBconsultaClasePorNombres { set; get; }
        Boolean RBPorStatus { set; get; }
        String TextNombreClase { set; get; }
        String DPLStatus { set; get; }
         int SessionID { set; get; }
    }
}
