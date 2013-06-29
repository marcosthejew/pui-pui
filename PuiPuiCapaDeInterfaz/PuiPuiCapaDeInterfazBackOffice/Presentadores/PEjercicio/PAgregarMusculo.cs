using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Comandos;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PEjercicio
{
    public class PAgregarMusculo
    {
        private IContratoAgregarMusculo _vistaAgregarMusculo;

        #region Constructor del Presentador
        public PAgregarMusculo(IContratoAgregarMusculo LaVista)
        {
            _vistaAgregarMusculo = LaVista;
        }
        #endregion

        public void AgregarMusculo()
        {
            String nombreMusculoAgregar = _vistaAgregarMusculo.nombreMusculo;

        }
        
    }
}