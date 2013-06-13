using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Entidades;
using PuiPuiCapaLogicaDeNegocios.Entidades.EEvaluaciones;
using PuiPuiCapaLogicaDeNegocios.Entidades.EReservaciones;

namespace PuiPuiCapaLogicaDeNegocios.Entidades.EClases
{
    public class ClaseSalon : AEntidad, IEvaluable, IReservable
    {
        public void evaluar(int calificacion)
        {
        }

        public void reservar(EHorario.Horario horario)
        {
        }
    }
}