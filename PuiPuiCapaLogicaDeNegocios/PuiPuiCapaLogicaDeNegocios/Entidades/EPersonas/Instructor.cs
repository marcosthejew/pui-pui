using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones;
using PuiPuiCapaLogicaDeNegocios.Entidades.EReservaciones;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EPersonas
{
    public class Instructor : APersona, IEvaluable, IReservable
    {
        void IEvaluable.evaluar(int calificacion)
        {
        }

        void IReservable.reservar(EHorario.Horario horario)
        {
        }
    }
}