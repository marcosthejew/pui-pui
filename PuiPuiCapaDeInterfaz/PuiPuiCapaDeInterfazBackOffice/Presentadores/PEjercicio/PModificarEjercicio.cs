using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Comandos;
using PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PEjercicio
{
    public class PModificarEjercicio
    {
        private IContratoModificarEjercicio _vistaModificarEjercicio;

        public PModificarEjercicio(IContratoModificarEjercicio vistaDeModificarEjercicio)
        {
            _vistaModificarEjercicio = vistaDeModificarEjercicio;
        }

        public void Click_ModificarEjercicio()
        {
            if (FabricaComando.CrearComandoModificarEjercicio(_vistaModificarEjercicio.NombreDeEjercicio, _vistaModificarEjercicio.tbDescripcionEjer, _vistaModificarEjercicio.MusculoAEjercitar).Ejecutar())
            {
                
            }

        }
        public void CagarCombos()
        {
            FabricaComando.CrearComandoCargarEjercicios(_vistaModificarEjercicio).Ejecutar();
            FabricaComando.CrearComandoCargarMusculos(_vistaModificarEjercicio).Ejecutar();
            
        }
    }
}