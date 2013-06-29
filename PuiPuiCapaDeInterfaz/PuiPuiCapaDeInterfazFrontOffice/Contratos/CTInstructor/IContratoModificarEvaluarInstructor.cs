using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaDeInterfazFrontOffice.Contratos.CTInstructor
{
    public interface IContratoModificarEvaluarInstructor
    {

        int SessionID { set; get; }
        String TXnombreInstructor { set; get; }
        String TXnombreCliente { set; get; }
        String TXFecha { set; get; }
        String TXObservacion { set; get; }
        String TXCalificacion { set; get; }

    }
}