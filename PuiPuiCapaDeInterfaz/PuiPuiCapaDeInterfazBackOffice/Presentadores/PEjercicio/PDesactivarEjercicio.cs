using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PEjercicio
{
    public class PDesactivarEjercicio
    {
        private IContratoDesactivarEjercicio _vistaDescativarEjercicio;

        public PDesactivarEjercicio(IContratoDesactivarEjercicio laVistaDesactivarEjercicio)
        {
            _vistaDescativarEjercicio = laVistaDesactivarEjercicio;
        }

        public void Click_PDesactivarEjercicio()
        {
        }
    }
}