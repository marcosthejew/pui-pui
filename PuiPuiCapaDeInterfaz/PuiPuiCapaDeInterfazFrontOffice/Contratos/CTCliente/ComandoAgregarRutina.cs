using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaDeInterfazFrontOffice.Comandos.Rutina
{
    public class ComandoAgregarRutina : AComando<bool>
    {
        public ComandoAgregarRutina()
        {

        }

        public override bool Ejecutar()
        {
            try
            {
                bool respuesta = false;

                //respuesta = new PuiPuiCapaDeInterfazFrontOffice.LogicaRutinasEjercicios.FachadaRutinasEjercicios().AgregarRutina(parametros);
                
                
                    
                return respuesta;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}