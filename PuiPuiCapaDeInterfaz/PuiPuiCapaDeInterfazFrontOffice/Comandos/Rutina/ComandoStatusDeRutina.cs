using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuiPuiCapaDeInterfazFrontOffice.Comandos.Rutina
{
    public class ComandoStatusDeRutina: AComando<string>
    {
        int idRutina;

        public ComandoStatusDeRutina(int _idRutina)
        {
            this.idRutina = _idRutina+1;
        }
        public override string Ejecutar()
        {
            try
            {
                return new PuiPuiCapaDeInterfazFrontOffice.LogicaRutinasEjercicios.FachadaRutinasEjercicios().StatusDeRutina(idRutina);
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
