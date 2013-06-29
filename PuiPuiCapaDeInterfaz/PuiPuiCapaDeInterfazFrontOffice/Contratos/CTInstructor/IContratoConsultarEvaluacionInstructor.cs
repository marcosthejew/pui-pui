using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace PuiPuiCapaDeInterfazFrontOffice.Contratos.CTInstructor
{
    public interface IContratoConsultarEvaluacionInstructor
    {

        Boolean RBConsultaCompleta { set; get; }
        Boolean RBconsultaInstructorPorNombres { set; get; }
        String TextNombreInstrutor { set; get; }
        int SessionID { set; get; }



    }
}