using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PEjercicio
{
    public class PDesactivarMusculo
    {
        private IContratoDesactivarMusculo _vistaDesactivarMusculo;

        public PDesactivarMusculo(IContratoDesactivarMusculo vistaDesactivarMusculo)
        {
            _vistaDesactivarMusculo = vistaDesactivarMusculo;
        }

        public void Click_DesactivarMusculo()
        {
        }
    }
}