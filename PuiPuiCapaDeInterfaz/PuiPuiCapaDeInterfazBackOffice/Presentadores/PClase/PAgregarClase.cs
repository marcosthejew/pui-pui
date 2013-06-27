using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTClase;
using PuiPuiCapaDeInterfazBackOffice.LogicaClase;

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
            FachadaClasesSoapClient insertar = new FachadaClasesSoapClient();
           int seInserto= insertar.ServicioAgregarClase(agregarclase.TxtnombreClaseNueva, 0, agregarclase.TxtDescripcionClaseNueva, 0);
           if (seInserto == 0)
               return true;
           else
               return false;
        }



    }
}