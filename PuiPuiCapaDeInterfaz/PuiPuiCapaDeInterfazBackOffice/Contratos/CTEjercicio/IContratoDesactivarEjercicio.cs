using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio
{
    public interface IContratoDesactivarEjercicio
    {
        String ElegirEjercicio { get; }
        String NombreDelEjercicio { get; set; }
        String DescripcionDelEjercicio { get; set; }
        String NombreDelMusculo { get; set; }
    }
}
