using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTReservarClase;
using PuiPuiCapaDeInterfazFrontOffice.LogicaReservarClase;

namespace PuiPuiCapaDeInterfazFrontOffice.Presentadores.PReservarClase
{
    public class PConsultarDetalleReservacionClase
    {
        IContratoConsultarDetalleReservacionClase _vistaConsultarDetalle;
        FachadaReservarClasesFrontOffice _wsConsultarDetalle;

          public PConsultarDetalleReservacionClase(IContratoConsultarDetalleReservacionClase vistaConsultarDetalle)
          {
              _vistaConsultarDetalle = vistaConsultarDetalle;
              _wsConsultarDetalle = new FachadaReservarClasesFrontOffice();
    
          }

           
    }
}