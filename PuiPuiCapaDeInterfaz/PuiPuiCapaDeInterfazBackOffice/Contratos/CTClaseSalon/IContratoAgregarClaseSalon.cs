using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTClaseSalon
{
    interface IContratoAgregarClaseSalon
    {
        DropDownList salones { get; set; }
        DropDownList clase { get; set; }
        DropDownList instructores { get; set; }
        string hora_inicio { get; set; }
        string hora_fin { get; set; }
    }
}
