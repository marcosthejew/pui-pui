using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuiPuiCapaDeInterfazFrontOffice.Comandos.Rutina
{
    public class ComandoConsultarRutina : AComando<string>
    {
        int idCliente;

        public ComandoConsultarRutina(int _idCliente)
        {
            this.idCliente = _idCliente;
        }
        public override string Ejecutar()
        {
            try
            {
                return new PuiPuiCapaDeInterfazFrontOffice.LogicaRutinasEjercicios.FachadaRutinasEjercicios().ConsultarRutinasPorIDCliente(idCliente);
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}
