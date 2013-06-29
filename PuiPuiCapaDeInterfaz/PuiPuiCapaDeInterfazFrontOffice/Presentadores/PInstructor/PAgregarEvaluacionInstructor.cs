using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazFrontOffice.Contratos.CTInstructor;
using PuiPuiCapaDeInterfazFrontOffice.FachadaInstructoresFrontOffice;

namespace PuiPuiCapaDeInterfazFrontOffice.Presentadores.PInstructor
{
    public class PAgregarEvaluacionInstructor
    {
        IContratoAgregarEvaluarInstructor _modificar;

        public PAgregarEvaluacionInstructor(IContratoAgregarEvaluarInstructor vista_consultar)
        {
            this._modificar = vista_consultar;
        
        }

         public int AgregarClase()
         {

             FachadaInstructoresSoapClient evaluacionModificar = new FachadaInstructoresSoapClient();

             String cas = _modificar.TXnombreInstructor;
             try
             {
                 if ((_modificar.TXCalificacion.Equals("5") || _modificar.TXCalificacion.Equals("4") || _modificar.TXCalificacion.Equals("3") ||
                        _modificar.TXCalificacion.Equals("2") || _modificar.TXCalificacion.Equals("1") || _modificar.TXCalificacion.Equals("0")) && _modificar.TXObservacion.Length <= 150)
                 return evaluacionModificar.ServicioComandoInsertarEvaluacionesInstructor(Convert.ToDateTime(_modificar.TXFecha), _modificar.TXObservacion, 0, _modificar.TXnombreCliente,_modificar.TXnombreInstructor, Convert.ToInt32(_modificar.TXCalificacion));
                   else
                     return 1;
             }
             catch (Exception e)
             {
                 return 1;
             }

         }
    }
}