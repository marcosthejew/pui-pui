using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTClaseSalon
{
   public interface IContratoConsultarClaseSalon
    {
        Boolean RBTodos { set; get; }
       
        Boolean RBSalon { set; get; }
        Boolean RBClase { set; get; }
        Boolean RBInstructor { set; get; }
        String TXTSalon { set; get; }
        String TXTClase { set; get; }
        String TXTInstructor { set; get; }
       
    }
}
