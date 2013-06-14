using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PuiPuiCapaLogicaDeNegocios.Comandos;

namespace PuiPuiCapaLogicaDeNegocios.Fabricas
{
    /// <summary>
    /// Clase que instancia Comandos especificos casteados a la clase abstracta
    /// AComando.
    /// </summary>
    public class FabricaComando
    {
        /// <summary>
        /// Devuelve una instancia del comando ComandoHolaMundo.
        /// </summary>
        /// <returns></returns>
        public static AComando<string> CrearComandoHolaMundo()
        {
            return new ComandoHolaMundo();
        }
    }
}