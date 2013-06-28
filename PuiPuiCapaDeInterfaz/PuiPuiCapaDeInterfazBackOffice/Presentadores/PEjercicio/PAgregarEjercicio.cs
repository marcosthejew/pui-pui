using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Comandos;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PEjercicio
{
    public class PAgregarEjercicio
    {
        #region Atributos
        IAgregarEjercicio _vistaEjercicio;
        #endregion

        #region Constructor Inyector 
        public PAgregarEjercicio(IAgregarEjercicio vistaEjercicio)
        {
            _vistaEjercicio = vistaEjercicio;

        }
        #endregion

        #region Metodos

        public void CargarMusculos()
        {
            FabricaComando.CrearComandoCargarMusculos(_vistaEjercicio);
        }

        public string AgregarEjercicio(string nombre, string descripcion, string musculo)
        {
            return "exito";
        }

        #endregion
    }
}