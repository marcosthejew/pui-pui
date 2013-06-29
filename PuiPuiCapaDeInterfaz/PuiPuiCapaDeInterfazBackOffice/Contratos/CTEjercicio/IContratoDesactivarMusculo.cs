using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio
{
   public interface IContratoDesactivarMusculo
    {
        String Musculo { get; }
        String Exito { get; set; }
        
    }
}
