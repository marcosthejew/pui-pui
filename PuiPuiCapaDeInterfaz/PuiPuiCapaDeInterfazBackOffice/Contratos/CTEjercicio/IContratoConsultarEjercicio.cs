using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio
{
    public interface IContratoConsultarEjercicio
    {
        String NombreEjercicioAConsultar { get;}
        String NombreEjercicio { get; set; }
        String DescripcionMusculo { get; set; }
        String MusculoAEjercitar { get; set; } 
    }
}
