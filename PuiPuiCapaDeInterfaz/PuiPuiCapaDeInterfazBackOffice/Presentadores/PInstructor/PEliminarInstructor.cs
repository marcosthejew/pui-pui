using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTInstructor;
using PuiPuiCapaDeInterfazBackOffice.Comandos;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PInstructor
{
    public class PEliminarInstructor
    {
        private IContratoEliminarInstructor _vista;

        public PEliminarInstructor(IContratoEliminarInstructor vista)
        {
            _vista = vista;
        }

        /*public Boolean InsertarClase()
        {
            FachadaClasesSoapClient insertar = new FachadaClasesSoapClient();
            int seInserto = insertar.ServicioAgregarClase(agregarclase.TxtnombreClaseNueva, 0, agregarclase.TxtDescripcionClaseNueva, 0);
            if (seInserto == 0)
                return true;
            else
                return false;
        }*/
    }
}