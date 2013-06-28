using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio
{
    interface IAgregarEjercicio
    {
        string Nombre { get; set; }
        string Descripcion { get; set; }
        string Musculos { get; }
        string Exito { get; set; }
    }
}
