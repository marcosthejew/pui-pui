using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTReservarClase;
using PuiPuiCapaDeInterfazFrontOffice.LogicaReservarClase;

namespace PuiPuiCapaDeInterfazFrontOffice.Presentadores.PReservarClase
{
    public class PReservarClase
    {
        IContratoReservarClase _vistaReservarclase;
        String _reservaciones = "";
        FachadaReservarClasesFrontOffice _wsReservarClase;

        public PReservarClase(IContratoReservarClase vistaResevarClase)
        {

            _vistaReservarclase = vistaResevarClase;
            _wsReservarClase = new FachadaReservarClasesFrontOffice();
        
        }

        public String WSObtenerReservaciones()
        {
           
            _reservaciones = _wsReservarClase.ServicioConsultarTodosReservacionesClases();
            return _reservaciones;
        }


    }
}