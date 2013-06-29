using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Comandos;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PEjercicio
{
    public class PDesactivarEjercicio
    {
        private IContratoDesactivarEjercicio _vistaDescativarEjercicio;

        public PDesactivarEjercicio(IContratoDesactivarEjercicio laVistaDesactivarEjercicio)
        {
            _vistaDescativarEjercicio = laVistaDesactivarEjercicio;
        }

        public void CargarEjercicios()
        {
            FabricaComando.CrearComandoCargarEjercicios(_vistaDescativarEjercicio).Ejecutar();
        }

        public void Click_PDesactivarEjercicio()
        {
            if (FabricaComando.CrearComandoDesactivarEjercicio(0, _vistaDescativarEjercicio.Ejercicio).Ejecutar())
            {
                _vistaDescativarEjercicio.Exito = "Exitosa";
            }
            else
            {
                _vistaDescativarEjercicio.Exito = "Fallido";

            }
        }
    }
}