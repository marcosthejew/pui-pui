using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Data;

namespace PuiPuiCapaDeInterfazFrontOffice.Contratos.CTRutina
{
    public interface IContratoAgregarRutina
    {
        Label Lerror { get; set; }
        TextBox nombre { get; set; }
        TextBox descripcion { get; set; }
        RadioButton Rduracion { get; set; }
        RadioButton Rrepeticion { get; set; }
        TextBox Tduracion { get; set; }
        TextBox Trepeticion { get; set; }
        ListBox ejercicioNoAsociado { get; set; }
        ListBox ejercicioAsociado { get; set; }

    }
}