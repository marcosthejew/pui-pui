using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTClase;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PClase
{
    public class PConsultarClase
    {
        IContratoConsultarClase consultar;

        public PConsultarClase(IContratoConsultarClase vista_consultar){
            consultar = vista_consultar;
        
        }

        public DataTable ConsultaClase() {

            throw new NotImplementedException();
        }

    }
}