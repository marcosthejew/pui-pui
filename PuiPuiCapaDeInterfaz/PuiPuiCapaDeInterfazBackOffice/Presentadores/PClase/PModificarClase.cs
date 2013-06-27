using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTClase;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PClase
{
    public class PModificarClase
    {
        IContratoModificaClase _modificar;
        public PModificarClase(IContratoModificaClase vista_modificar)
        {
            _modificar = vista_modificar;
        }
    }
}