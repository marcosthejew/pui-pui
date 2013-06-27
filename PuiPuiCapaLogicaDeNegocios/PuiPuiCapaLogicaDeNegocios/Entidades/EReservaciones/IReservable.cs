using PuiPuiCapaLogicaDeNegocios.Entidades.EHorario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EReservaciones
{
    public interface IReservable
    {
        void reservar(Horario horario);
    }
}
