using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PEjercicio
{
    public class PModificarEjercicio
    {
        private IContratoModificarEjercicio _vistaModificarEjercicio;

        public PModificarEjercicio(IContratoModificarEjercicio vistaDeModificarEjercicio)
        {
            _vistaModificarEjercicio = vistaDeModificarEjercicio;
        }

        public void Click_ModificarEjercicio()
        {

        }
    }
}