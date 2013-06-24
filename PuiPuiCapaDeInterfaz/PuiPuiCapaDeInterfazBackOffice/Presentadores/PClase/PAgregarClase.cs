using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTClase;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PClase
{
    public class PAgregarClase
    {
        IContratoAgregarClase agregarclase;

        public PAgregarClase(IContratoAgregarClase vistaAgregar) {

            agregarclase = vistaAgregar;
        
        }

        public Boolean InsertarClase()
        {

            throw new NotImplementedException();
        
        }



    }
}