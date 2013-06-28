using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio
{
    public interface IContratoModificarEjercicio
    {
        String NombreDeEjercicio { get; set;}
        String tbNombreEjercicio { get; set; }
        String tbDescripcionEjer { get; set; }
        String MusculoAEjercitar { get; set; }
    }
}
