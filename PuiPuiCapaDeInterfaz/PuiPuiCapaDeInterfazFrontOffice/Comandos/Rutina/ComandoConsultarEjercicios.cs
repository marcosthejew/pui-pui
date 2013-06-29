using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaDeInterfazFrontOffice.Comandos.Rutina
{
    public class ComandoConsultarEjercicios : AComando<string>
    {
        public ComandoConsultarEjercicios()
        {

        }

        public override string Ejecutar()
        {
            try
            {
                string respuesta ;

                respuesta = new PuiPuiCapaDeInterfazFrontOffice.LogicaRutinasEjercicios.FachadaRutinasEjercicios().ConsultarTodosEjerciciosR();

                return respuesta;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}