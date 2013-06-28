using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTInstructor;

namespace PuiPuiCapaDeInterfazFrontOffice.Presentadores.PInstructor
{
    public class PConsultarEvaluacionInstructor
    {
        IContratoConsultarEvaluacionInstructor consultar;

        public PConsultarEvaluacionInstructor(IContratoConsultarEvaluacionInstructor vista_consultar)
        {
           this.consultar = vista_consultar;
        
        }

        public DataTable ConsultaClase() {

            throw new NotImplementedException();
        }
    }
}