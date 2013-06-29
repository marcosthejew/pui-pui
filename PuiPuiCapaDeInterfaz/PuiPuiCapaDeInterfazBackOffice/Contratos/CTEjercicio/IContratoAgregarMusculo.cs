using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio
{
    public interface IContratoAgregarMusculo
    {
        String nombreMusculo {get; set;}
        String descripcionMusculo { get; set; }
        String Exito { get; set; }
       
    }
}
