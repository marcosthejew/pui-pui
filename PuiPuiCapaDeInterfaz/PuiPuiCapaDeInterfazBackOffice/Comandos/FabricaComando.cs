using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaDeInterfazBackOffice.Comandos.ComandosEjercicio;
using PuiPuiCapaDeInterfazBackOffice.Contratos.CTEjercicio;

namespace PuiPuiCapaDeInterfazBackOffice.Comandos
{
    /// <summary>
    /// Clase que instancia Comandos especificos casteados a la clase abstracta
    /// AComando.
    /// </summary>
    public class FabricaComando
    {
        #region Ejercicio
        public static AComando<bool> CrearComandoCargarMusculos(IAgregarEjercicio vista)
        {
            return new ComandoCargarMusculos(vista);
        }

        #endregion
    }
}