using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTInstructor;
using PuiPuiCapaDeInterfazBackOffice.Comandos;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PInstructor
{
    public class PConsultarInstructor
    {
        private IContratoConsultarInstructor _vista;

        public PConsultarInstructor(IContratoConsultarInstructor vista)
        {
            _vista = vista;
        }

        public void CargarInstructores()
        {
            FabricaComando.CrearComandoCargarInstructores(_vista);
        }
    }
}