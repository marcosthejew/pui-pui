using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;

namespace PuiPuiCapaDeInterfazBackOffice.Presentadores.PEjercicio
{
    public class PAgregarEjercicio
    {
        #region Atributos
        IAgregarEjercicio _vistaEjercicio;
        #endregion

        #region Constructor Inyector 
       /* public PAgregarEjercicio(IAgregarEjercicio vistaEjercicio)
        {
            _vistaEjercicio = vistaEjercicio;

        }*/
        #endregion

        #region Metodos

        public void CargarMusculos()
        {

        }

        public string AgregarEjercicio(string nombre, string descripcion, string musculo)
        {
            return "exito";
        }

        #endregion
    }
}