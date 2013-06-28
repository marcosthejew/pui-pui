using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazFrontOffice.Contratos.CTReservarClase
{
    public interface IContratoConsultarDetalleReservacionClase
    {
        String TextNombreCliente { set; get; }
        String TextDescripcionClase { set; get; }
        String TextFechaClase { set; get; }
        String TextInicioClase { set; get; }
        String TextFinalizaClase { set; get; }
        String TextNombreInstructor { set; get; }
        String TextEmailInstructor { set; get; }
        String TextUbicacionSalon { set; get; }
        String TextCapacidadSalon { set; get; }
        String TextEstatusReservacion { set; get; }
        int SessionID { set; get; }
    }
}
